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
public static partial class GeoMap_MarkupExtensions
{
//================= Properties ======================//
 // ActiveMap

/*ValueSetterGenerator*/
public static T ActiveMap<T>(this T control, LiveChartsCore.Geo.CoreMap<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._set(() => control.ActiveMap = value!);

/*BindFromExpressionSetterGenerator*/
public static T ActiveMap<T>(this T control, Func<LiveChartsCore.Geo.CoreMap<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.Geo.CoreMap<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ActiveMapProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ActiveMap<T>(this T control,LiveChartsCore.Geo.CoreMap<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ActiveMapProperty, ps, () => control.ActiveMap = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ActiveMap<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ActiveMapProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ActiveMap<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ActiveMapProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ActiveMap<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Geo.CoreMap<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ActiveMapProperty, ps, () => control.ActiveMap = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SyncContext

/*ValueSetterGenerator*/
public static T SyncContext<T>(this T control, System.Object value) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._set(() => control.SyncContext = value!);

/*BindFromExpressionSetterGenerator*/
public static T SyncContext<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SyncContextProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SyncContext<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SyncContextProperty, ps, () => control.SyncContext = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SyncContext<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SyncContextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SyncContext<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SyncContextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SyncContext<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SyncContextProperty, ps, () => control.SyncContext = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ViewCommand

/*ValueSetterGenerator*/
public static T ViewCommand<T>(this T control, System.Object value) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._set(() => control.ViewCommand = value!);

/*BindFromExpressionSetterGenerator*/
public static T ViewCommand<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ViewCommandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ViewCommand<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ViewCommandProperty, ps, () => control.ViewCommand = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ViewCommand<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ViewCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ViewCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ViewCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ViewCommand<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.ViewCommandProperty, ps, () => control.ViewCommand = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MapProjection

/*ValueSetterGenerator*/
public static T MapProjection<T>(this T control, LiveChartsCore.Geo.MapProjection value) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._set(() => control.MapProjection = value!);

/*BindFromExpressionSetterGenerator*/
public static T MapProjection<T>(this T control, Func<LiveChartsCore.Geo.MapProjection> func, Action<LiveChartsCore.Geo.MapProjection>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.MapProjectionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MapProjection<T>(this T control,LiveChartsCore.Geo.MapProjection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.MapProjectionProperty, ps, () => control.MapProjection = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MapProjection<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.MapProjectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MapProjection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.MapProjectionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MapProjection<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Geo.MapProjection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.MapProjectionProperty, ps, () => control.MapProjection = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Series

/*ValueSetterGenerator*/
public static T Series<T>(this T control, System.Collections.Generic.IEnumerable<LiveChartsCore.Geo.IGeoSeries> value) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._set(() => control.Series = value!);

/*BindFromExpressionSetterGenerator*/
public static T Series<T>(this T control, Func<System.Collections.Generic.IEnumerable<LiveChartsCore.Geo.IGeoSeries>> func, Action<System.Collections.Generic.IEnumerable<LiveChartsCore.Geo.IGeoSeries>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SeriesProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Series<T>(this T control,System.Collections.Generic.IEnumerable<LiveChartsCore.Geo.IGeoSeries> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SeriesProperty, ps, () => control.Series = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Series<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SeriesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Series<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SeriesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Series<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IEnumerable<LiveChartsCore.Geo.IGeoSeries>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.SeriesProperty, ps, () => control.Series = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Stroke

/*ValueSetterGenerator*/
public static T Stroke<T>(this T control, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._set(() => control.Stroke = value!);

/*BindFromExpressionSetterGenerator*/
public static T Stroke<T>(this T control, Func<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.StrokeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Stroke<T>(this T control,LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.StrokeProperty, ps, () => control.Stroke = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Stroke<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.StrokeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Stroke<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.StrokeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Stroke<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.StrokeProperty, ps, () => control.Stroke = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Fill

/*ValueSetterGenerator*/
public static T Fill<T>(this T control, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._set(() => control.Fill = value!);

/*BindFromExpressionSetterGenerator*/
public static T Fill<T>(this T control, Func<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> func, Action<LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.FillProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Fill<T>(this T control,LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.FillProperty, ps, () => control.Fill = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Fill<T>(this T control, IBinding binding) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.FillProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Fill<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
   => control._set(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.FillProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Fill<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, LiveChartsCore.Drawing.IPaint<LiveChartsCore.SkiaSharpView.Drawing.SkiaSharpDrawingContext>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : LiveChartsCore.SkiaSharpView.Avalonia.GeoMap 
=> control._setEx(LiveChartsCore.SkiaSharpView.Avalonia.GeoMap.FillProperty, ps, () => control.Fill = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



}
