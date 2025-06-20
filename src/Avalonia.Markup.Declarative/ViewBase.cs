﻿using Avalonia.Controls;
using Avalonia.Threading;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Avalonia.Markup.Declarative;


public abstract class ViewBase<TViewModel> : ViewBase
{
    public virtual TViewModel? ViewModel
    {
        get => (TViewModel)DataContext!;
        set => DataContext = value;
    }

    protected ViewBase(TViewModel viewModel)
        : base(true)
    {
        DataContext = viewModel;
        OnCreatedCore();
        Initialize();
    }

    protected abstract object Build(TViewModel? vm);

    protected override object Build() => Build(ViewModel);
}

/// <summary>
/// Base view class used like UserControl in XAML
/// </summary>
public abstract class ViewBase : Decorator, IReloadable, IDeclarativeViewBase
{
    internal List<ViewPropertyComputedState> __viewComputedStates { get; set; } = [];
    private INotifyPropertyChanged? _currentObservedDataContext;


    private INameScope? _nameScope;

    /// <summary>
    /// Current NameScope of this view
    /// </summary>
    protected INameScope Scope => _nameScope ??= new NameScope();

    public event Action? ViewInitialized;

    protected abstract object Build();

    protected virtual StyleGroup? BuildStyles() => null;

    protected ViewBase() : this(false)
    {

    }

    protected ViewBase(bool deferredLoading)
    {
        if (!deferredLoading)
        {
            OnCreatedCore();
            Initialize();
        }
    }

    protected virtual void OnAfterInitialized() { }

    protected internal void OnCreatedCore() => OnCreated();

    /// <summary>
    /// Called from constructor, right before initialization and building UI
    /// Override this method when you want to run some stuff before creation of children controls
    /// </summary>
    protected virtual void OnCreated()
    {
    }

    public void Initialize()
    {
        try
        {
            NameScope.SetNameScope(this, Scope);

            using (var context = new ViewBuildContext(this))
            {
                context.SetState(ViewBuildContextState.StyleBuilding);
                if (BuildStyles() is { } styleGroup)
                {
                    context.SetState(ViewBuildContextState.StyleSelectorUpdating);
                    var viewStyles = StyleBuilder.StylesToRange(styleGroup).ToImmutableList();
                    Styles.AddRange(viewStyles);
                }

                context.SetState(ViewBuildContextState.ViewBuilding);
                var content = Build();
                Child = content as Control;
            }

            ViewInitialized?.Invoke();
            OnAfterInitialized();
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            Debug.WriteLine(ex.StackTrace);
            throw new ViewBuildingException($"Build error in {GetType().Name} : {ex.Message}", ex);
        }
    }

    /// <summary>
    /// Overrides Avalonia's OnDataContextChanged to handle ViewModel property changes.
    /// </summary>
    protected override void OnDataContextChanged(EventArgs e)
    {
        base.OnDataContextChanged(e); // Вызываем базовый метод

        if (_currentObservedDataContext != null)
        {
            _currentObservedDataContext.PropertyChanged -= OnViewModelPropertyChanged;
            _currentObservedDataContext = null;
        }

        if (DataContext is INotifyPropertyChanged newContext)
        {
            _currentObservedDataContext = newContext;
            _currentObservedDataContext.PropertyChanged += OnViewModelPropertyChanged;
        }

        RecomputeAllBindings();
    }
    /// <summary>
    /// Handles PropertyChanged event from the DataContext.
    /// </summary>
    protected void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        Dispatcher.UIThread.Invoke(RecomputeAllBindings, DispatcherPriority.Normal);
    }

    /// <summary>
    /// Recomputes all registered computed bindings in the view.
    /// </summary>
    protected void RecomputeAllBindings()
    {
        foreach (var state in __viewComputedStates.ToList()) 
            state.OnPropertyChanged();
    }

    #region Hot reload stuff
    public void Reload()
    {
        Dispatcher.UIThread.InvokeAsync(() =>
        {
            // clean DataContext subscriptions and clear all computed states
            if (_currentObservedDataContext != null)
            {
                _currentObservedDataContext.PropertyChanged -= OnViewModelPropertyChanged;
                _currentObservedDataContext = null;
            }

            __viewComputedStates.Clear();
            OnBeforeReload();
            Child = null;
            VisualChildren.Clear();
            _nameScope = null;

            var oldDataContext = DataContext; 
            DataContext = null; // guarantee that OnDataContextChanged is called

            OnCreatedCore();
            Initialize();
            DataContext = oldDataContext; // set DataContext back

            InvalidateArrange();
            InvalidateMeasure();
            InvalidateVisual();
        });
    }

    protected virtual void OnBeforeReload()
    {
    }

    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);
        HotReloadManager.RegisterInstance(this);
    }

    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnDetachedFromVisualTree(e);
        HotReloadManager.UnregisterInstance(this);

        if (_currentObservedDataContext == null) return;

        _currentObservedDataContext.PropertyChanged -= OnViewModelPropertyChanged;
        _currentObservedDataContext = null;
    }
    #endregion

}

internal class ViewBuildContext : IDisposable
{
    private static readonly Stack<ViewBuildContext> ViewsStack = new();
    private static ViewBuildContext? _currentContext;

    internal static ViewBase? CurrentView => _currentContext?._view;
    internal static ViewBuildContextState? CurrentState => _currentContext?._state;

    private readonly ViewBase _view;
    private ViewBuildContextState _state;

    public ViewBuildContext(ViewBase view)
    {
        _view = view;

        if (_currentContext != null)
            ViewsStack.Push(_currentContext);

        _currentContext = this;

        //Debug.WriteLine($"Pushed view {view.GetType().Name}");
    }

    internal void SetState(ViewBuildContextState state)
    {
        _state = state;
    }

    public void Dispose()
    {
        _currentContext = ViewsStack.Count > 0 ? ViewsStack.Pop() : null;

        //if( _currentContext != null )
        //    Debug.WriteLine($"Poped view {_currentContext._view.GetType().Name}");
    }

    public static string GetViewStackString() => string.Join("/", ViewsStack.ToArray().Reverse().Select(x => x._view.GetType().Name));
}

internal enum ViewBuildContextState
{
    None,
    StyleBuilding,
    StyleSelectorUpdating,
    ViewBuilding
}

public class ViewBuildingException(string message, Exception innerException) : Exception(message, innerException);