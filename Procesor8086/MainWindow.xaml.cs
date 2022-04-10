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

namespace Procesor8086
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void ResetRegister(object sender, RoutedEventArgs e)
        {
            this.AX_input.Clear();
            this.BX_input.Clear();
            this.CX_input.Clear();
            this.DX_input.Clear();

            this.AX_input.Background = Brushes.White;
            this.BX_input.Background = Brushes.White;
            this.CX_input.Background = Brushes.White;
            this.DX_input.Background = Brushes.White;
        }

        private string GetRandom()
        {
            Random random = new Random();
            int num = random.Next(65535);
            string hexString = num.ToString("X");

            return hexString;
        }

        private void RandomRegister(object sender, RoutedEventArgs e)
        {
            this.AX_input.Text = GetRandom();
            this.BX_input.Text = GetRandom();
            this.CX_input.Text = GetRandom();
            this.DX_input.Text = GetRandom();
        }

        private void MOV_AX_BX_Click(object sender, RoutedEventArgs e)
        {
            this.AX_input.Text = this.BX_input.Text;
        }

        private void MOV_AX_CX_Click(object sender, RoutedEventArgs e)
        {
            this.AX_input.Text = this.CX_input.Text;
        }

        private void MOV_AX_DX_Click(object sender, RoutedEventArgs e)
        {
            this.AX_input.Text = this.DX_input.Text;
        }

        private void MOV_BX_AX_Click(object sender, RoutedEventArgs e)
        {
            this.BX_input.Text = this.AX_input.Text;
        }

        private void MOV_BX_CX_Click(object sender, RoutedEventArgs e)
        {
            this.BX_input.Text = this.CX_input.Text;
        }

        private void MOV_BX_DX_Click(object sender, RoutedEventArgs e)
        {
            this.BX_input.Text = this.DX_input.Text;
        }

        private void MOV_CX_AX_Click(object sender, RoutedEventArgs e)
        {
            this.CX_input.Text = this.AX_input.Text;
        }

        private void MOV_CX_BX_Click(object sender, RoutedEventArgs e)
        {
            this.CX_input.Text = this.BX_input.Text;
        }

        private void MOV_CX_DX_Click(object sender, RoutedEventArgs e)
        {
            this.CX_input.Text = this.DX_input.Text;
        }

        private void MOV_DX_AX_Click(object sender, RoutedEventArgs e)
        {
            this.DX_input.Text = this.AX_input.Text;
        }

        private void MOV_DX_BX_Click(object sender, RoutedEventArgs e)
        {
            this.DX_input.Text = this.BX_input.Text;
        }

        private void MOV_DX_CX_Click(object sender, RoutedEventArgs e)
        {
            this.DX_input.Text = this.CX_input.Text;
        }

        private void ChangedColor(object sender, TextChangedEventArgs e)
        {
            this.AX_input.Background = Brushes.White;
            this.BX_input.Background = Brushes.White;
            this.CX_input.Background = Brushes.White;
            this.DX_input.Background = Brushes.White;

            if (sender is TextBox box)
            {
                box.Background = Brushes.PowderBlue;
            }
        }
    }
}