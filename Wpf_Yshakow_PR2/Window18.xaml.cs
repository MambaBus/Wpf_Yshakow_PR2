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
    /// Логика взаимодействия для Window18.xaml
    /// </summary>
    public partial class Window18 : Window
    {
        public Window18()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            this.planhet.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            planhet.DefaultDrawingAttributes.Width = ((Slider)sender).Value;
            planhet.DefaultDrawingAttributes.Height = ((Slider)sender).Value;
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            planhet.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            planhet.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            planhet.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void Black_Click(object sender, RoutedEventArgs e)
        {
            planhet.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void lastik_Checked(object sender, RoutedEventArgs e)
        {
            if (planhet.EditingMode == InkCanvasEditingMode.Ink)
                planhet.EditingMode = InkCanvasEditingMode.EraseByPoint;
            else
                planhet.EditingMode = InkCanvasEditingMode.Ink;
        }
    }
}
