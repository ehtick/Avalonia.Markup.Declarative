#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DrawingImageExtensions
{
public static DrawingImage Drawing(this DrawingImage control, IBinding binding)
   => control._set(DrawingImage.DrawingProperty, binding);
public static DrawingImage Drawing(this DrawingImage control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DrawingImage.DrawingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DrawingImage Drawing(this DrawingImage control, Func<Drawing> func, Action<Drawing>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DrawingImage.DrawingProperty, func, onChanged, expression);
public static DrawingImage Drawing(this DrawingImage control, Drawing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingImage.DrawingProperty, ps, () => control.Drawing = value, bindingMode, converter, bindingSource);
public static DrawingImage Drawing<TValue>(this DrawingImage control, TValue value, FuncValueConverter<TValue, Drawing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingImage.DrawingProperty, ps, () => control.Drawing = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

