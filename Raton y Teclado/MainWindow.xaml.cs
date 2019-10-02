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


namespace Raton_y_Teclado
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender == TextBox1)
            {
                FocusTextBox.Text  = "TextBox 1";
            }
            else if (sender == TextBox2)
            {
                FocusTextBox.Text = "TextBox 2";
            }
            else if (sender == TextBox3)
            {
                FocusTextBox.Text = "TextBox 3";
            }
            else
            {
                FocusTextBox.Text = "";
            }            
        }


        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {

            if (sender == TextBox1)
            {
                SobreTextBox.Text = "TextBox 1";
            }
            else if (sender == TextBox2)
            {
                SobreTextBox.Text = "TextBox 2";
            }
            else if (sender == TextBox3)
            {
                SobreTextBox.Text = "TextBox 3";
            }           
        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sender == TextBox1)
            {
                SobreTextBox.Text = " ";
            }
            else if (sender == TextBox2)
            {
                SobreTextBox.Text = " ";
            }
            else if (sender == TextBox3)
            {
                SobreTextBox.Text = " ";
            }
        }

        private void ClickIzquierdo_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ClickIzquierdo.Background = Brushes.Green;
        }

        private void ClickIzquierdo_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ClickIzquierdo.Background = Brushes.White;
        }

        private void ClickDerecho_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            ClickDerecho.Background = Brushes.Green;
        }

        private void ClickDerecho_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            ClickDerecho.Background = Brushes.White;
        }

        private void TextBox2_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                TextBox2.Text = "Ayuda";
            }
        }

        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
