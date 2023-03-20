﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Akropol.Veiw.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenegersArend.xaml
    /// </summary>
    public partial class MenegersArend : Page
    {
        public MenegersArend()
        {
            InitializeComponent();
            Dtg.ItemsSource = Models.ClassHelpers.balashov.Fond.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Classes.ClassFrame.frame2.Navigate(new dobPage());
        }
    }
}
