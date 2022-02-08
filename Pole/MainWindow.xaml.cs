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

namespace Pole
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a;
        int b;
        int[] pole = new int[100];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            //a = random.Next(1, 100);
            //b = random.Next(1, 100);
            //txtvypis.Text = a.ToString() + "; " + b.ToString();

            pole[8] = 25;
            pole[42] = 77;
            for(int i = 0; i < pole.Length; i++)
            {
                pole[i] = random.Next(1, 10000);
            }
            txtvypis.Text = "";
            for(int i = 0; i < pole.Length; i++)
            {
                txtvypis.Text += pole[i].ToString() + "; ";
            }
            txtvypis.Text = string.Join("; ", pole); 
        }
    }
}
