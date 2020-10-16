using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace vkladki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Jaanuar : ContentPage
    {
        public Jaanuar()
        {
            InitializeComponent();
            Grid grd = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition {Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition {Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition {Height=new GridLength(1,GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
        };
            Label nimetus = new Label { Text = "Январь", FontSize = 30 };
            Image img = new Image { Source = "jaanuar.jpg" };
            Label kirjeldus = new Label { Text = "Первый месяц года в юлианском и григорианском календарях, одиннадцатый месяц староримского года, начинавшегося до реформы Цезаря с марта. " };
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }
    }
}