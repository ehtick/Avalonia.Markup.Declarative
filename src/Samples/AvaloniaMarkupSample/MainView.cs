﻿using Avalonia.Controls.Primitives;
using Avalonia.Styling;
using AvaloniaMarkupSample.CommonSamples;
using AvaloniaMarkupSample.MvuSample;
using AvaloniaMarkupSample.MvvmSample;

namespace AvaloniaMarkupSample;

public class MainView : ViewBase
{
    protected override StyleGroup? BuildStyles() =>
    [
        new Style<Border>(s => s.OfType<TabItem>().Child())
            .BorderBrush(Brushes.Gray)
            .BorderThickness(1)
    ];

    protected override object Build() =>
        new TabControl()
            .SelectedIndex(0)
            .TabStripPlacement(Dock.Left)
            .Items(
                new TabItem()
                    .Header("Hot reload")
                    .Content(
                        new StackPanel()
                            .Children(
                                new TextBlock()
                                    .Ref(out var textBlock)
                                    .Padding(12)
                                    .FontSize(30)
                                    .HorizontalAlignment(HorizontalAlignment.Center)
                                    .Text("Hello Hot Reload!")
                                    .Foreground("SystemAccentColor".GetDynamicResource()),

                                new Button()
                                    .Name("HotReloadButton", Scope)
                                    .Content("click me!")
                                    .HorizontalAlignment(HorizontalAlignment.Center)
                                    .OnClick(_ =>
                                    {
                                        textBlock.Text("Button clicked!");

                                        var button = this.FindControl<Button>("HotReloadButton");
                                        if (button != null)
                                            button.Content = "Found by Name";
                                    }),
                                new HyperlinkButton()
                                    .HorizontalAlignment(HorizontalAlignment.Center)
                                    .NavigateUri(new Uri("https://github.com/AvaloniaUI/Avalonia.Markup.Declarative"))
                                    .Content("Open on github")
                            )
                    ),

                new TabItem()
                    .Header("Dock sample")
                    .Content(
                        new Border().Child(
                            new DockPanel()
                                .LastChildFill(true)
                                .Children(
                                    new TextBox().Text("Left1").Dock(Dock.Left),
                                    new TextBox().Text("Right").Dock(Dock.Right),
                                    new TextBox().Text("Left2").Dock(Dock.Left)))
                    ),

                new TabItem()
                    .Header("MVVM")
                    .Content(new Border().Child(new MvvmSampleView())
                    ),

                new TabItem()
                    .Header("MVU")
                    .Content(new Border().Child(new SampleMvuView())
                    ),

                new TabItem()
                    .Header("Canvas sample")
                    .Content(new Border().Child(new CanvasSampleMvuView())
                    ),

                new TabItem()
                    .Header("Styles")
                    .Content(new Border().Child(new StylesSampleView())),

                new TabItem()
                    .Header("Treeview control")
                    .Content(new Border().Child(new TreeViewSampleView())),

                new TabItem()
                    .Header("Item control")
                    .Content(new Border().Child(new ItemControlSampleView())),

                new TabItem()
                    .Header("OpenGL view")
                    .Content(new Border().Child(new OpenGlView())),


                new TabItem().Header("Custom controls")
                    .Content(
                        new StackPanel()
                            .Width(300)
                            .Children(
                                new TextBlock()
                                    .Text("Custom control example:"),

                                new Border()
                                    .BorderBrush(Brushes.Gray)
                                    .BorderThickness(1)
                                    .Child(
                                        new MyCustomControl()
                                            .Margin(20)
                                    ),

                                new TextBlock()
                                    .Text("Custom templated control example:"),

                                new Border()
                                    .BorderBrush(Brushes.Gray)
                                    .BorderThickness(1)
                                    .Child(
                                        new MyCustomTemplatedControl()
                                            .Ref(out var myCustomTemplatedControl)
                                            .Margin(20)
                                            .Template(StaticResources.Templates.MyControlTemplate)
                                    ),
                                new ToggleButton()
                                    .Ref(out var tb)
                                    .Content("Change template")
                                    .OnClick(args =>
                                    {
                                        myCustomTemplatedControl.Template = !(tb.IsChecked ?? false)
                                            ? StaticResources.Templates.MyControlTemplate
                                            : StaticResources.Templates.MyAnotherControlTemplate;
                                    })
                            )
                    ));

}