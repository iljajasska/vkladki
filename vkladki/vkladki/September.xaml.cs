﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace vkladki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class September : ContentPage
    {
        public September()
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
            Label nimetus = new Label { Text = "Сентябрь", FontSize = 30 };
            Image img = new Image { Source = "september.jpg" };
            Label kirjeldus = new Label { Text = "Девятый месяц григорианского календаря, один из четырёх григорианских месяцев с тридцатью днями. Сентябрь — начало осени в северном полушарии Земли и начало весны в южном." };
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }
    }
}