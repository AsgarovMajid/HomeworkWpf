using System;
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



        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));
            button1.Background = brush;
        }
        private void button1_Right(object sender, RoutedEventArgs e)
        {
            button1.Visibility = Visibility.Collapsed;
            Widow1.Title = button1.Content.ToString();  
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));
            button2.Background = brush;
        }
        private void button2_Right(object sender, RoutedEventArgs e)
        {
            button2.Visibility = Visibility.Collapsed;
            Widow1.Title = button2.Content.ToString();
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));
            button3.Background = brush;
        }
        private void button3_Right(object sender, RoutedEventArgs e)
        {
            button3.Visibility = Visibility.Collapsed;
            Widow1.Title = button3.Content.ToString();
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));
            button4.Background = brush;
        }
        private void button4_Right(object sender, RoutedEventArgs e)
        {
            button4.Visibility = Visibility.Collapsed;
            Widow1.Title = button4.Content.ToString();
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));
            button5.Background = brush;
        }
        private void button5_Right(object sender, RoutedEventArgs e)
        {
            button5.Visibility = Visibility.Collapsed;
            Widow1.Title = button5.Content.ToString();
        }
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));
            button6.Background = brush;
        }
        private void button6_Right(object sender, RoutedEventArgs e)
        {
            button6.Visibility = Visibility.Collapsed;
            Widow1.Title = button6.Content.ToString();
        }
    }
}
