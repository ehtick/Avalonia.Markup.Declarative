using System.Diagnostics.CodeAnalysis;
using Avalonia.Styling;

namespace MvuTemplate;

//prevent from trimming [injected] services by native aot compilation
[method: DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties, typeof(SimpleComponent))]
public class SimpleComponent(SampleDataService dataService) : ComponentBase //constructor dependency injection sample
{
    // You can also use Service injection into Property with DI container as follows:
    [Inject] public SampleDataService? DataService { get; set; }

    //Styles
    protected override StyleGroup? BuildStyles() =>
    [
        new Style<Button>(x => x.Class(":pointerover").Descendant())
            .Background(Brushes.LightBlue),

        new Style<Button>()
            .Margin(6)
            .Background(Brushes.DarkSalmon),

        new Style<TextBlock>(s => s.OfType<StackPanel>().Name("SideBar").Descendant())
            .FontSize(16)
            .Foreground(Brushes.White),

        new StyleGroup(x => x.Class("narrow").Descendant())
        {
            new Style<StackPanel>(s => s.Name("SideBar"))
                .IsVisible(false)
        }
    ];

    //Markup
    protected override object Build() =>
        new Grid().Cols("150, *")
            .BindClass(() => Bounds.Width < 400, "narrow")
            .Children(
                new StackPanel()
                    .Name("SideBar")
                    .Background(Brushes.CadetBlue)
                    .Children(
                        new TextBlock()
                            .Name("title")
                            .Margin(top: 16, left: 16) //partial margin defined with named arguments
                            .Text("Sidebar")
                    ),

                new StackPanel().Col(1)
                    .VerticalAlignment(VerticalAlignment.Center)
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Children(
                        new TextBlock().Ref(out _textBlock1)
                            .Text("Hello world"),
                        new TextBlock()
                            .Text(() => $"Counter: {(Counter == 0 ? "zero" : Counter)}"), //expression binding with dynamic string result
                        new NumericUpDown()
                            .Value(() => Counter, onChanged: v => Counter = v), //two-way binding sample
                        new Button()
                            .HorizontalAlignment(HorizontalAlignment.Center)
                            .Content("Click me")
                            .OnClick(OnButtonClick) //direct event callback
                    )
            );

    //Code
    private TextBlock _textBlock1 = null!;

    private decimal? Counter { get; set; } = 0;

    private void OnButtonClick(RoutedEventArgs e)
    {
        _textBlock1.Text = dataService?.GetData() ?? "Data service is `null`";
        StateHasChanged();
    }

    protected override void OnSizeChanged(SizeChangedEventArgs e)
    {
        //force recalculation on window width to check if it's Narrow state now
        StateHasChanged();
        base.OnSizeChanged(e);
    }
}