#nullable enable
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ArcExtensions
{
public static Arc StartAngle(this Arc control, IBinding binding)
   => control._set(Arc.StartAngleProperty, binding);
public static Arc StartAngle(this Arc control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Arc.StartAngleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Arc StartAngle(this Arc control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Arc.StartAngleProperty, func, onChanged, expression);
public static Arc StartAngle(this Arc control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Arc.StartAngleProperty, ps, () => control.StartAngle = value, bindingMode, converter, bindingSource);
public static Arc StartAngle<TValue>(this Arc control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Arc.StartAngleProperty, ps, () => control.StartAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Arc SweepAngle(this Arc control, IBinding binding)
   => control._set(Arc.SweepAngleProperty, binding);
public static Arc SweepAngle(this Arc control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Arc.SweepAngleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Arc SweepAngle(this Arc control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Arc.SweepAngleProperty, func, onChanged, expression);
public static Arc SweepAngle(this Arc control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Arc.SweepAngleProperty, ps, () => control.SweepAngle = value, bindingMode, converter, bindingSource);
public static Arc SweepAngle<TValue>(this Arc control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Arc.SweepAngleProperty, ps, () => control.SweepAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

