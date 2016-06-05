using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AutoSkola.Autoskola.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Grid raspored = (Grid)this.FindName("rasporedGrid");
            var stilDugme = new Style(typeof(Button))
            {
                Setters =
                {
                    new Setter { Property = BackgroundProperty, Value = Colors.Azure },
                    new Setter { Property = HeightProperty, Value = 50},
                    new Setter { Property = WidthProperty, Value = 70 },
                    new Setter { Property = BorderThicknessProperty, Value = 2 },
                    new Setter { Property = BorderBrushProperty, Value = Colors.Black }
                }
            };
            for(int i = 1; i < 4; i++)
                for(int j = 0; j < 9; j++)
                {
                    Button bat = new Button();
                    bat.Style = stilDugme;
                    Grid.SetRow(bat, i);
                    Grid.SetColumn(bat, j);
                    raspored.Children.Add(bat);
                }

        }
    }
}
