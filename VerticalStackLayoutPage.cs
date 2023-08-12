using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AulaTres
{
    public class VerticalStackLayoutPage : ContentPage
    {
        public VerticalStackLayoutPage()
        {
            Title = "Vertical StackLayout demo";

            StackLayout stackLayout = new StackLayout { Margin = new Thickness(20) };

            stackLayout.Add(new Label { Text = "Primary Colors" });
            stackLayout.Add(new BoxView { Color = Colors.Red, HeightRequest = 40 });
            stackLayout.Add(new BoxView { Color = Colors.Yellow, HeightRequest = 40 });
            stackLayout.Add(new BoxView { Color = Colors.Blue, HeightRequest = 40 });

            stackLayout.Add(new Label { Text = "Secundary Colors" });
            stackLayout.Add(new BoxView { Color = Colors.Green, HeightRequest = 40 });
            stackLayout.Add(new BoxView { Color = Colors.Orange, HeightRequest = 40 });
            stackLayout.Add(new BoxView { Color = Colors.Purple, HeightRequest = 40 });

            Content = stackLayout;
        }
    }
}