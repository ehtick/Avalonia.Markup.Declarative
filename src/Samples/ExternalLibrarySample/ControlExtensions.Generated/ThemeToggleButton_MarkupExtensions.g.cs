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
public static partial class ThemeToggleButton_MarkupExtensions
{
//================= Properties ======================//
 // IsThreeState

/*ValueSetterGenerator*/
public static T IsThreeState<T>(this T control, System.Boolean value) where T : Ursa.Controls.ThemeToggleButton 
=> control._set(() => control.IsThreeState = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsThreeState<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.ThemeToggleButton 
   => control._set(Ursa.Controls.ThemeToggleButton.IsThreeStateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsThreeState<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ThemeToggleButton 
=> control._setEx(Ursa.Controls.ThemeToggleButton.IsThreeStateProperty, ps, () => control.IsThreeState = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsThreeState<T>(this T control, IBinding binding) where T : Ursa.Controls.ThemeToggleButton 
   => control._set(Ursa.Controls.ThemeToggleButton.IsThreeStateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsThreeState<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ThemeToggleButton 
   => control._set(Ursa.Controls.ThemeToggleButton.IsThreeStateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsThreeState<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ThemeToggleButton 
=> control._setEx(Ursa.Controls.ThemeToggleButton.IsThreeStateProperty, ps, () => control.IsThreeState = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // IsThreeState

/*ValueStyleSetterGenerator*/
public static Style<T> IsThreeState<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.ThemeToggleButton 
=> style._addSetter(Ursa.Controls.ThemeToggleButton.IsThreeStateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsThreeState<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.ThemeToggleButton 
=> style._addSetter(Ursa.Controls.ThemeToggleButton.IsThreeStateProperty, binding);



}
