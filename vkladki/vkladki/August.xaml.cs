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
    public partial class August : ContentPage
    {
        public August()
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
            Label nimetus = new Label { Text = "Август", FontSize = 30 };
            Image img = new Image { Source = "august.jpg" };
            Label kirjeldus = new Label { Text = "Восьмой месяц года в юлианском и григорианском календарях, шестой месяц староримского года, начинавшегося до реформы Цезаря с марта. Один из семи месяцев длиной в 31 день." };
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }
    }
}