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
using System.Windows.Shapes;

namespace Wpf_Yshakow_PR2
{
    /// <summary>
    /// Логика взаимодействия для Window17.xaml
    /// </summary>
    public partial class Window17 : Window
    {
        public Window17()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.LightBlue);
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Visible;
            TextBlock.Text = "Перекрашивает фон в серый цвет";
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил работу\n  Ушаков Сергей 402");
        }

        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Visible;
            TextBlock.Text = "Показывает информацию о разработчике программы";
        }

        private void Button_MouseLeave_1(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window18 window18 = new Window18();
            window18.Show();
        }

        private void Button_MouseEnter_2(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Visible;
            TextBlock.Text = "Задание 2";
        }

        private void Button_MouseLeave_2(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Collapsed;
        }

        private void Button_MouseEnter_3(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Visible;
            TextBlock.Text = "Закрывает программу";
        }

        private void Button_MouseLeave_3(object sender, MouseEventArgs e)
        {
            StatusBar.Visibility = Visibility.Collapsed;
        }
    }
}
