﻿using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string newText = textBox.Text.Trim();

            if (!string.IsNullOrEmpty(newText))
            {
                comboBox.Items.Add(textBox.Text);

                textBox.Text = string.Empty;
            }
        }

        /*
        private void ToRedOnHover(object sender, RoutedEventArgs e)
        {
            Button ToRed = FindName("ToRed") as Button;
            Button ToPurple = FindName("ToPurple") as Button;
            Button ToWhite = FindName("ToWhite") as Button;

            ToRed.Background = Brushes.Red;
            ToPurple.Background = Brushes.Red;
            ToWhite.Background = Brushes.Red;

        }

        private void ToPurpleOnPress(object sender, RoutedEventArgs e)
        {
            Button ToRed = FindName("ToRed") as Button;
            Button ToPurple = FindName("ToPurple") as Button;
            Button ToWhite = FindName("ToWhite") as Button;

            ToRed.Background = Brushes.Purple;
            ToPurple.Background = Brushes.Purple;
            ToWhite.Background = Brushes.Purple;
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            Button ToRed = FindName("ToRed") as Button;
            Button ToPurple = FindName("ToPurple") as Button;
            Button ToWhite = FindName("ToWhite") as Button;

            ToRed.Background = Brushes.White;
            ToPurple.Background = Brushes.White;
            ToWhite.Background = Brushes.White;
        }
        
        private void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            Button ToRed = FindName("ToRed") as Button;
            Button ToPurple = FindName("ToPurple") as Button;
            Button ToWhite = FindName("ToWhite") as Button;

            ToRed.Background = Brushes.Black;
            ToPurple.Background = Brushes.Black;
            ToWhite.Background = Brushes.Black;
        }
        */


    }

}

