using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Resources;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        string firstnum;
        string secondnum;
        bool num = true;
        char op = 'o';
        double r = 0;
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!num)
            {
                y.Text += "8";
                firstnum += "8";
            }
            if (num)
            {
                y.Text += "8";
                secondnum += "8";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            y.Text += "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            y.Text += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            y.Text += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            y.Text += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            y.Text += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            y.Text += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            y.Text += "7";
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            y.Text += "9";
        }
        private void plus_Click(object sender, RoutedEventArgs e)
        {
            op = 'p';
            num = true;
            y.Text += " + ";
        }
        public void calcul()
        {

            double first = Convert.ToInt32(firstnum);
            double second = Convert.ToInt32(secondnum);
            switch (op)
            {
                case 'p':
                    r = first + second;
                    result.Text = r.ToString();
                    break;
                case 'm':
                    r = Convert.ToDouble(firstnum) - Convert.ToDouble(secondnum);
                    result.Text = r.ToString();
                    break;
                case 'k':
                    r = Convert.ToDouble(firstnum) * Convert.ToDouble(secondnum);
                    result.Text = r.ToString();
                    break;
                case 'd':
                    r = Convert.ToDouble(firstnum) / Convert.ToDouble(secondnum);
                    result.Text = r.ToString();
                    break;
            }
            firstnum = r.ToString();
        }
        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            calcul();
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {

        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}
