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
public static partial class PathIcon_MarkupExtensions
{
//================= Properties ======================//
 // Data

/*ValueSetterGenerator*/
public static T Data<T>(this T control, Avalonia.Media.Geometry value) where T : Avalonia.Controls.PathIcon 
=> control._set(() => control.Data = value!);

/*BindFromExpressionSetterGenerator*/
public static T Data<T>(this T control, Func<Avalonia.Media.Geometry> func, Action<Avalonia.Media.Geometry>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.PathIcon 
   => control._set(Avalonia.Controls.PathIcon.DataProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Data<T>(this T control,Avalonia.Media.Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.PathIcon 
=> control._setEx(Avalonia.Controls.PathIcon.DataProperty, ps, () => control.Data = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Data<T>(this T control, IBinding binding) where T : Avalonia.Controls.PathIcon 
   => control._set(Avalonia.Controls.PathIcon.DataProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Data<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.PathIcon 
   => control._set(Avalonia.Controls.PathIcon.DataProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Data<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.PathIcon 
=> control._setEx(Avalonia.Controls.PathIcon.DataProperty, ps, () => control.Data = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Data

/*ValueStyleSetterGenerator*/
public static Style<T> Data<T>(this Style<T> style, Avalonia.Media.Geometry value) where T : Avalonia.Controls.PathIcon 
=> style._addSetter(Avalonia.Controls.PathIcon.DataProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Data<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.PathIcon 
=> style._addSetter(Avalonia.Controls.PathIcon.DataProperty, binding);



}
