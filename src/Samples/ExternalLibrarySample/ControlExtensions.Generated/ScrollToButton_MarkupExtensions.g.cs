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
public static partial class ScrollToButton_MarkupExtensions
{
//================= Properties ======================//
 // Target

/*ValueSetterGenerator*/
public static T Target<T>(this T control, Avalonia.Controls.Control value) where T : Ursa.Controls.ScrollToButton 
=> control._set(() => control.Target = value!);

/*BindFromExpressionSetterGenerator*/
public static T Target<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.ScrollToButton 
   => control._set(Ursa.Controls.ScrollToButton.TargetProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Target<T>(this T control,Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ScrollToButton 
=> control._setEx(Ursa.Controls.ScrollToButton.TargetProperty, ps, () => control.Target = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Target<T>(this T control, IBinding binding) where T : Ursa.Controls.ScrollToButton 
   => control._set(Ursa.Controls.ScrollToButton.TargetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Target<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ScrollToButton 
   => control._set(Ursa.Controls.ScrollToButton.TargetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Target<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ScrollToButton 
=> control._setEx(Ursa.Controls.ScrollToButton.TargetProperty, ps, () => control.Target = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Direction

/*ValueSetterGenerator*/
public static T Direction<T>(this T control, Ursa.Common.Position value) where T : Ursa.Controls.ScrollToButton 
=> control._set(() => control.Direction = value!);

/*BindFromExpressionSetterGenerator*/
public static T Direction<T>(this T control, Func<Ursa.Common.Position> func, Action<Ursa.Common.Position>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.ScrollToButton 
   => control._set(Ursa.Controls.ScrollToButton.DirectionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Direction<T>(this T control,Ursa.Common.Position value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ScrollToButton 
=> control._setEx(Ursa.Controls.ScrollToButton.DirectionProperty, ps, () => control.Direction = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Direction<T>(this T control, IBinding binding) where T : Ursa.Controls.ScrollToButton 
   => control._set(Ursa.Controls.ScrollToButton.DirectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Direction<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ScrollToButton 
   => control._set(Ursa.Controls.ScrollToButton.DirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Direction<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Ursa.Common.Position> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ScrollToButton 
=> control._setEx(Ursa.Controls.ScrollToButton.DirectionProperty, ps, () => control.Direction = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Target

/*ValueStyleSetterGenerator*/
public static Style<T> Target<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Ursa.Controls.ScrollToButton 
=> style._addSetter(Ursa.Controls.ScrollToButton.TargetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Target<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.ScrollToButton 
=> style._addSetter(Ursa.Controls.ScrollToButton.TargetProperty, binding);


 // Direction

/*ValueStyleSetterGenerator*/
public static Style<T> Direction<T>(this Style<T> style, Ursa.Common.Position value) where T : Ursa.Controls.ScrollToButton 
=> style._addSetter(Ursa.Controls.ScrollToButton.DirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Direction<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.ScrollToButton 
=> style._addSetter(Ursa.Controls.ScrollToButton.DirectionProperty, binding);



}
