using System;
using System.Collections.Generic;
using System.Globalization;
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
            //BP_input_result

            this.AX_input_reg.Clear();
            this.BX_input_reg.Clear();
            this.CX_input_reg.Clear();
            this.DX_input_reg.Clear();

            this.AX_input_mem.Clear();
            this.BX_input_mem.Clear();
            this.CX_input_mem.Clear();
            this.DX_input_mem.Clear();

            this.SI_input_default.Clear();
            this.DI_input_default.Clear();
            this.BP_input_default.Clear();
            this.SP_input_default.Clear();

            this.SI_input_result.Clear();
            this.DI_input_result.Clear();
            this.BP_input_result.Clear();
            this.SP_input_result.Clear();





            this.AX_input_reg.Background = Brushes.White;
            this.BX_input_reg.Background = Brushes.White;
            this.CX_input_reg.Background = Brushes.White;
            this.DX_input_reg.Background = Brushes.White;

            this.AX_input_mem.Background = Brushes.White;
            this.BX_input_mem.Background = Brushes.White;
            this.CX_input_mem.Background = Brushes.White;
            this.DX_input_mem.Background = Brushes.White;
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
            this.AX_input_reg.Text = GetRandom();
            this.BX_input_reg.Text = GetRandom();
            this.CX_input_reg.Text = GetRandom();
            this.DX_input_reg.Text = GetRandom();

            this.AX_input_mem.Text = GetRandom();
            this.BX_input_mem.Text = GetRandom();
            this.CX_input_mem.Text = GetRandom();
            this.DX_input_mem.Text = GetRandom();


            this.SI_input_default.Text = GetRandom();
            this.DI_input_default.Text = GetRandom();
            this.BP_input_default.Text = GetRandom();
            this.SP_input_default.Text = GetRandom();
        }

        private void MOV_AX_BX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                this.AX_input_reg.Text = this.BX_input_mem.Text;
            else
                this.AX_input_mem.Text = this.BX_input_reg.Text;
        }

        private void MOV_AX_CX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                this.AX_input_reg.Text = this.CX_input_mem.Text;
            else
                this.AX_input_mem.Text = this.CX_input_reg.Text;
        }

        private void MOV_AX_DX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                this.AX_input_reg.Text = this.DX_input_mem.Text;
            else
                this.AX_input_mem.Text = this.DX_input_reg.Text;
        }

        private void MOV_BX_AX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                this.BX_input_reg.Text = this.AX_input_mem.Text;
            else
                this.BX_input_mem.Text = this.AX_input_reg.Text;
        }

        private void MOV_BX_CX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                this.BX_input_reg.Text = this.CX_input_mem.Text;
            else
                this.BX_input_mem.Text = this.CX_input_reg.Text;
        }

        private void MOV_BX_DX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                this.BX_input_reg.Text = this.DX_input_mem.Text;
            else
                this.BX_input_mem.Text = this.DX_input_reg.Text;
        }

        private void MOV_CX_AX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                this.CX_input_reg.Text = this.AX_input_mem.Text;
            else
                this.CX_input_mem.Text = this.AX_input_reg.Text;
        }

        private void MOV_CX_BX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                this.CX_input_reg.Text = this.BX_input_mem.Text;
            else
                this.CX_input_mem.Text = this.BX_input_reg.Text;
        }

        private void MOV_CX_DX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                this.CX_input_reg.Text = this.DX_input_mem.Text;
            else
                this.CX_input_reg.Text = this.DX_input_mem.Text;
        }

        private void MOV_DX_AX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                this.DX_input_reg.Text = this.AX_input_mem.Text;
            else
                this.DX_input_mem.Text = this.AX_input_reg.Text;
        }

        private void MOV_DX_BX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                this.DX_input_reg.Text = this.BX_input_mem.Text;
            else
                this.DX_input_reg.Text = this.BX_input_mem.Text;
        }

        private void MOV_DX_CX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                this.DX_input_reg.Text = this.CX_input_mem.Text;
            else
                this.DX_input_reg.Text = this.CX_input_mem.Text;
        }

        private void ChangedColor(object sender, TextChangedEventArgs e)
        {
            this.AX_input_reg.Background = Brushes.White;
            this.BX_input_reg.Background = Brushes.White;
            this.CX_input_reg.Background = Brushes.White;
            this.DX_input_reg.Background = Brushes.White;

            this.AX_input_mem.Background = Brushes.White;
            this.BX_input_mem.Background = Brushes.White;
            this.CX_input_mem.Background = Brushes.White;
            this.DX_input_mem.Background = Brushes.White;

            if (sender is TextBox box)
            {
                box.Background = Brushes.PowderBlue;
            }
        }

        private void CheckIsHex(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out _);
        }

        private void swap(TextBox a, TextBox b)
        {
            string temp = a.Text;

            a.Text = b.Text;
            b.Text = temp;
        }

        private void XCHG_AX_BX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                swap(AX_input_reg, BX_input_mem);
            else
                swap(AX_input_mem, BX_input_reg);
        }

        private void XCHG_AX_CX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                swap(AX_input_reg, CX_input_mem);
            else
                swap(AX_input_mem, CX_input_reg);
        }

        private void XCHG_AX_DX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                swap(AX_input_reg, DX_input_mem);
            else
                swap(AX_input_mem, DX_input_reg);
        }

        private void XCHG_BX_AX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                swap(BX_input_reg, AX_input_mem);
            else
                swap(BX_input_mem, AX_input_reg);
        }

        private void XCHG_BX_CX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                swap(BX_input_reg, CX_input_mem);
            else
                swap(BX_input_mem, CX_input_reg);
        }

        private void XCHG_BX_DX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                swap(BX_input_reg, DX_input_mem);
            else
                swap(BX_input_reg, DX_input_mem);
        }

        private void XCHG_CX_AX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                swap(CX_input_reg, AX_input_mem);
            else
                swap(CX_input_mem, AX_input_reg);
        }

        private void XCHG_CX_BX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                swap(CX_input_reg, BX_input_mem);
            else
                swap(CX_input_mem, BX_input_reg);
        }

        private void XCHG_CX_DX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                swap(CX_input_reg, DX_input_mem);
            else
                swap(CX_input_mem, DX_input_reg);
        }

        private void XCHG_DX_AX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                swap(DX_input_reg, AX_input_mem);
            else
                swap(DX_input_mem, AX_input_reg);
        }

        private void XCHG_DX_BX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                swap(DX_input_reg, BX_input_mem);
            else
                swap(DX_input_mem, BX_input_reg);
        }

        private void XCHG_DX_CX_Click(object sender, RoutedEventArgs e)
        {
            if (reg_mem.IsChecked == true)
                swap(DX_input_reg, CX_input_mem);
            else
                swap(DX_input_mem, CX_input_reg);
        }

        private void bazowy_Checked(object sender, RoutedEventArgs e)
        {
            string result = "";
            if(Bx.IsChecked == true)
                result = BP_input_default.Text+





        }

       

        // tryb bazowy suma rejestru bazowego bp lub bx + przemieszczenie wzor (Np. MOV AX, [BP+2])

    }
}