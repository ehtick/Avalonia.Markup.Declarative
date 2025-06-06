#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class ItemsControl_MarkupExtensions
{
//================= Properties ======================//
 // ItemContainerTheme

/*ValueSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, Avalonia.Styling.ControlTheme value) where T : Avalonia.Controls.ItemsControl 
=> control._set(() => control.ItemContainerTheme = value!);

/*BindFromExpressionSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme> func, Action<Avalonia.Styling.ControlTheme>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ItemContainerTheme<T>(this T control,Avalonia.Styling.ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ItemsControl 
=> control._setEx(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, ps, () => control.ItemContainerTheme = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, IBinding binding) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemContainerTheme<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ItemContainerTheme<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Styling.ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ItemsControl 
=> control._setEx(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, ps, () => control.ItemContainerTheme = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ItemsPanel

/*ValueSetterGenerator*/
public static T ItemsPanel<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value) where T : Avalonia.Controls.ItemsControl 
=> control._set(() => control.ItemsPanel = value!);

/*BindFromExpressionSetterGenerator*/
public static T ItemsPanel<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsPanelProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ItemsPanel<T>(this T control,Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ItemsControl 
=> control._setEx(Avalonia.Controls.ItemsControl.ItemsPanelProperty, ps, () => control.ItemsPanel = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ItemsPanel<T>(this T control, IBinding binding) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsPanelProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemsPanel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsPanelProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ItemsPanel<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ItemsControl 
=> control._setEx(Avalonia.Controls.ItemsControl.ItemsPanelProperty, ps, () => control.ItemsPanel = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ItemsSource

/*ValueSetterGenerator*/
public static T ItemsSource<T>(this T control, System.Collections.IEnumerable value) where T : Avalonia.Controls.ItemsControl 
=> control._set(() => control.ItemsSource = value!);

/*BindFromExpressionSetterGenerator*/
public static T ItemsSource<T>(this T control, Func<System.Collections.IEnumerable> func, Action<System.Collections.IEnumerable>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsSourceProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ItemsSource<T>(this T control,System.Collections.IEnumerable value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ItemsControl 
=> control._setEx(Avalonia.Controls.ItemsControl.ItemsSourceProperty, ps, () => control.ItemsSource = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ItemsSource<T>(this T control, IBinding binding) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsSourceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemsSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemsSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ItemsSource<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.IEnumerable> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ItemsControl 
=> control._setEx(Avalonia.Controls.ItemsControl.ItemsSourceProperty, ps, () => control.ItemsSource = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ItemTemplate

/*ValueSetterGenerator*/
public static T ItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ItemsControl 
=> control._set(() => control.ItemTemplate = value!);

/*BindFromExpressionSetterGenerator*/
public static T ItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ItemTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ItemsControl 
=> control._setEx(Avalonia.Controls.ItemsControl.ItemTemplateProperty, ps, () => control.ItemTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ItemTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.ItemTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ItemTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ItemsControl 
=> control._setEx(Avalonia.Controls.ItemsControl.ItemTemplateProperty, ps, () => control.ItemTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // DisplayMemberBinding

/*ValueSetterGenerator*/
public static T DisplayMemberBinding<T>(this T control, Avalonia.Data.IBinding value) where T : Avalonia.Controls.ItemsControl 
=> control._set(() => control.DisplayMemberBinding = value!);

/*BindFromExpressionSetterGenerator*/
public static T DisplayMemberBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T DisplayMemberBinding<T>(this T control,Avalonia.Data.IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ItemsControl 
=> control._setEx(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty, ps, () => control.DisplayMemberBinding = value!, bindingMode, converter, bindingSource);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DisplayMemberBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ItemsControl 
   => control._set(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T DisplayMemberBinding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ItemsControl 
=> control._setEx(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty, ps, () => control.DisplayMemberBinding = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // PreparingContainer

/*ActionToEventGenerator*/
public static T OnPreparingContainer<T>(this T control, Action<Avalonia.Controls.ContainerPreparedEventArgs> action) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerPreparedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PreparingContainer += h);


 // ContainerPrepared

/*ActionToEventGenerator*/
public static T OnContainerPrepared<T>(this T control, Action<Avalonia.Controls.ContainerPreparedEventArgs> action) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerPreparedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ContainerPrepared += h);


 // ContainerIndexChanged

/*ActionToEventGenerator*/
public static T OnContainerIndexChanged<T>(this T control, Action<Avalonia.Controls.ContainerIndexChangedEventArgs> action) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerIndexChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ContainerIndexChanged += h);


 // ContainerClearing

/*ActionToEventGenerator*/
public static T OnContainerClearing<T>(this T control, Action<Avalonia.Controls.ContainerClearingEventArgs> action) where T : Avalonia.Controls.ItemsControl  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ContainerClearingEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ContainerClearing += h);



//================= Styles ======================//
 // ItemContainerTheme

/*ValueStyleSetterGenerator*/
public static Style<T> ItemContainerTheme<T>(this Style<T> style, Avalonia.Styling.ControlTheme value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemContainerTheme<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemContainerThemeProperty, binding);


 // ItemsPanel

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsPanel<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Panel> value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsPanelProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsPanel<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsPanelProperty, binding);


 // ItemsSource

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsSource<T>(this Style<T> style, System.Collections.IEnumerable value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsSourceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsSource<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemsSourceProperty, binding);


 // ItemTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ItemTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.ItemTemplateProperty, binding);


 // DisplayMemberBinding

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayMemberBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Avalonia.Controls.ItemsControl 
=> style._addSetter(Avalonia.Controls.ItemsControl.DisplayMemberBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped DisplayMemberBinding because already exist in value setters



}
