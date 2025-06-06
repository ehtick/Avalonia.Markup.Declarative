using System.Diagnostics.CodeAnalysis;
using LiveChartsCore.SkiaSharpView.Avalonia;

namespace ExternalLibrarySample;

//prevent from trimming [injected] services by native aot compilation
[method: DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties, typeof(ChartsComponent))]
public class ChartsComponent() : ComponentBase
{
    //Styles
    protected override StyleGroup? BuildStyles() => [];

    //Markup
    protected override object Build() =>
        new Grid().Cols("Auto, *")
            .Children(
                new StackPanel().Children(
                    new Button()
                        .Content("Update data")
                        .VerticalAlignment(VerticalAlignment.Top)
                        .HorizontalAlignment(HorizontalAlignment.Center)
                        .Margin(top: 16)
                        .OnClick(_ =>
                        {
                            ViewModel?.UpdateData();
                            StateHasChanged();
                        }),

                    new ColorPicker()
                        .Margin(0, 16)
                        .OnColorChanged(c =>
                        {
                            ViewModel?.UpdateColor(c);
                            StateHasChanged();
                        })
                        .BorderThickness(1)
                        .BorderBrush(Brushes.Gray)
                ),

                new CartesianChart().Col(1)
                    .Series(() => ViewModel?.Series)
                    .Background(Brushes.WhiteSmoke)
                    .AnimationsSpeed(TimeSpan.FromMilliseconds(1500))
            );

    //Code
    public ChartViewModel? ViewModel { get; set; } = new();
}