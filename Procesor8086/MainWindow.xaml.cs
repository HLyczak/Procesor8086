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
            this.AX_input_reg.Clear();
            this.BX_input_reg.Clear();
            this.CX_input_reg.Clear();
            this.DX_input_reg.Clear();

            this.SI_input_default.Clear();
            this.DI_input_default.Clear();
            this.BP_input_default.Clear();
            this.BX_input_default.Clear();
            this.Offset_input.Clear();
            this.Adres_result.Clear();
            this.Nr_rejestru_result.Clear();
            this.Adres_result_Copy.Clear();
            al_result.Visibility = Visibility.Hidden;
            ah_result.Visibility = Visibility.Hidden;

            this.AX_input_reg.Background = Brushes.White;
            this.BX_input_reg.Background = Brushes.White;
            this.CX_input_reg.Background = Brushes.White;
            this.DX_input_reg.Background = Brushes.White;
            this.Nr_rejestru_result.Background = Brushes.White;
            this.Adres_result.Background = Brushes.White;
            this.Adres_result_Copy.Background = Brushes.White;
        }

        private string GetRandom()
        {
            Random random = new Random();
            int num = random.Next(5000, 10000);
            string hexString = num.ToString("X");

            return hexString;
        }

        private void RandomRegister(object sender, RoutedEventArgs e)
        {
            this.AX_input_reg.Text = GetRandom();
            this.BX_input_reg.Text = GetRandom();
            this.CX_input_reg.Text = GetRandom();
            this.DX_input_reg.Text = GetRandom();

            this.SI_input_default.Text = GetRandom();
            this.DI_input_default.Text = GetRandom();
            this.BP_input_default.Text = GetRandom();
            this.BX_input_default.Text = GetRandom();
        }

        private void ChangedColor(object sender, TextChangedEventArgs e)
        {
            this.AX_input_reg.Background = Brushes.White;
            this.BX_input_reg.Background = Brushes.White;
            this.CX_input_reg.Background = Brushes.White;
            this.DX_input_reg.Background = Brushes.White;

            if (sender is TextBox box)
            {
                box.Background = Brushes.White;
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

        /* if (reg_mem.IsChecked == true)
             swap(AX_input_reg, BX_input_mem);
         else
             swap(AX_input_mem, BX_input_reg);*/

        private void move_click(object sender, RoutedEventArgs e)
        {
            if (mem_reg.IsChecked == true)
            {
                if (indeksowy.IsChecked == true && Si.IsChecked == true && AX_check.IsChecked == true)
                    this.Adres_result.Text = AddHex(SI_input_default.Text, Offset_input.Text);
                else if (indeksowy.IsChecked == true && Si.IsChecked == true && BX_check.IsChecked == true)
                    this.Adres_result.Text = AddHex(SI_input_default.Text, Offset_input.Text);
                else if (indeksowy.IsChecked == true && Si.IsChecked == true && CX_check.IsChecked == true)
                    this.Adres_result.Text = AddHex(SI_input_default.Text, Offset_input.Text);
                else if (indeksowy.IsChecked == true && Si.IsChecked == true && DX_check.IsChecked == true)
                    this.Adres_result.Text = AddHex(SI_input_default.Text, Offset_input.Text);
                //
                else if (indeksowy.IsChecked == true && Di.IsChecked == true && AX_check.IsChecked == true)
                    this.Adres_result.Text = AddHex(DI_input_default.Text, Offset_input.Text);
                else if (indeksowy.IsChecked == true && Di.IsChecked == true && BX_check.IsChecked == true)
                    this.Adres_result.Text = AddHex(DI_input_default.Text, Offset_input.Text);
                else if (indeksowy.IsChecked == true && Di.IsChecked == true && CX_check.IsChecked == true)
                    this.Adres_result.Text = AddHex(DI_input_default.Text, Offset_input.Text);
                else if (indeksowy.IsChecked == true && Di.IsChecked == true && DX_check.IsChecked == true)
                    this.Adres_result.Text = AddHex(DI_input_default.Text, Offset_input.Text);

                //
                else if (bazowy.IsChecked == true && Bx.IsChecked == true && AX_check.IsChecked == true)
                    this.Adres_result.Text = AddHex(BX_input_default.Text, Offset_input.Text);
                else if (bazowy.IsChecked == true && Bx.IsChecked == true && BX_check.IsChecked == true)
                    this.Adres_result.Text = AddHex(BX_input_default.Text, Offset_input.Text);
                else if (bazowy.IsChecked == true && Bx.IsChecked == true && CX_check.IsChecked == true)
                    this.Adres_result.Text = AddHex(BX_input_default.Text, Offset_input.Text);
                else if (bazowy.IsChecked == true && Bx.IsChecked == true && DX_check.IsChecked == true)
                    this.Adres_result.Text = AddHex(BX_input_default.Text, Offset_input.Text);
                //
                else if (bazowy.IsChecked == true && Bp.IsChecked == true && AX_check.IsChecked == true)
                    this.Adres_result.Text = AddHex(BP_input_default.Text, Offset_input.Text);
                else if (bazowy.IsChecked == true && Bp.IsChecked == true && BX_check.IsChecked == true)
                    this.Adres_result.Text = AddHex(BP_input_default.Text, Offset_input.Text);
                else if (bazowy.IsChecked == true && Bp.IsChecked == true && CX_check.IsChecked == true)
                    this.Adres_result.Text = AddHex(BP_input_default.Text, Offset_input.Text);
                else if (bazowy.IsChecked == true && Bp.IsChecked == true && DX_check.IsChecked == true)
                    this.Adres_result.Text = AddHex(BP_input_default.Text, Offset_input.Text);
                //
                else if (indeksowo_bazowy.IsChecked == true && Si.IsChecked == true && Bp.IsChecked == true)
                    this.Adres_result.Text = AddHex(SI_input_default.Text, Offset_input.Text + BP_input_default.Text);
                else if (indeksowo_bazowy.IsChecked == true && Si.IsChecked == true && Bx.IsChecked == true)
                    this.Adres_result.Text = AddHex(SI_input_default.Text, Offset_input.Text + BX_input_default.Text);

                //
                else if (indeksowo_bazowy.IsChecked == true && Di.IsChecked == true && Bp.IsChecked == true)
                    this.Adres_result.Text = AddHex(DI_input_default.Text, Offset_input.Text, BP_input_default.Text);
                else if (indeksowo_bazowy.IsChecked == true && Di.IsChecked == true && Bx.IsChecked == true)
                    this.Adres_result.Text = AddHex(DI_input_default.Text, Offset_input.Text, BX_input_default.Text);
            }
            // tryb bazowy suma rejestru bazowego bp lub bx + przemieszczenie wzor (Np. MOV AX, [BP+2])
            // tryb bazowy suma rejestru bazowego bp lub bx + przemieszczenie wzor (Np. MOV AX, [BP+2])
            else
            {
                if (indeksowy.IsChecked == true && Si.IsChecked == true && AX_check.IsChecked == true)
                {
                    this.SI_input_default.Text = SubstractHex(Adres_result.Text, Offset_input.Text);
                    this.AX_input_reg.Text = Nr_rejestru_result.Text;
                }
                if (indeksowy.IsChecked == true && Si.IsChecked == true && BX_check.IsChecked == true)
                {
                    this.SI_input_default.Text = SubstractHex(Adres_result.Text, Offset_input.Text);
                    this.BX_input_reg.Text = Nr_rejestru_result.Text;
                }
                if (indeksowy.IsChecked == true && Si.IsChecked == true && CX_check.IsChecked == true)
                {
                    this.SI_input_default.Text = SubstractHex(Adres_result.Text, Offset_input.Text);
                    this.CX_input_reg.Text = Nr_rejestru_result.Text;
                }
                if (indeksowy.IsChecked == true && Si.IsChecked == true && DX_check.IsChecked == true)
                {
                    this.SI_input_default.Text = SubstractHex(Adres_result.Text, Offset_input.Text);
                    this.DX_input_reg.Text = Nr_rejestru_result.Text;
                }
                //
                if (indeksowy.IsChecked == true && Di.IsChecked == true && AX_check.IsChecked == true)
                {
                    this.DI_input_default.Text = SubstractHex(Adres_result.Text, Offset_input.Text);
                    this.AX_input_reg.Text = Nr_rejestru_result.Text;
                }
                if (indeksowy.IsChecked == true && Di.IsChecked == true && BX_check.IsChecked == true)
                {
                    this.DI_input_default.Text = SubstractHex(Adres_result.Text, Offset_input.Text);
                    this.BX_input_reg.Text = Nr_rejestru_result.Text;
                }
                if (indeksowy.IsChecked == true && Di.IsChecked == true && CX_check.IsChecked == true)
                {
                    this.DI_input_default.Text = SubstractHex(Adres_result.Text, Offset_input.Text);
                    this.CX_input_reg.Text = Nr_rejestru_result.Text;
                }
                if (indeksowy.IsChecked == true && Di.IsChecked == true && DX_check.IsChecked == true)
                {
                    this.DI_input_default.Text = SubstractHex(Adres_result.Text, Offset_input.Text);
                    this.DX_input_reg.Text = Nr_rejestru_result.Text;
                }

                //
                if (indeksowy.IsChecked == true && Si.IsChecked == true && AX_check.IsChecked == true)
                {
                    this.SI_input_default.Text = SubstractHex(Adres_result.Text, Offset_input.Text);
                    this.AX_input_reg.Text = Nr_rejestru_result.Text;
                }
                if (bazowy.IsChecked == true && Bp.IsChecked == true && AX_check.IsChecked == true)
                {
                    this.BP_input_default.Text = SubstractHex(Adres_result.Text, Offset_input.Text);
                    this.AX_input_reg.Text = Nr_rejestru_result.Text;
                }
                if (bazowy.IsChecked == true && Bp.IsChecked == true && BX_check.IsChecked == true)
                {
                    this.BP_input_default.Text = SubstractHex(Adres_result.Text, Offset_input.Text);
                    this.BX_input_reg.Text = Nr_rejestru_result.Text;
                }
                if (bazowy.IsChecked == true && Bp.IsChecked == true && CX_check.IsChecked == true)
                {
                    this.BP_input_default.Text = SubstractHex(Adres_result.Text, Offset_input.Text);
                    this.CX_input_reg.Text = Nr_rejestru_result.Text;
                }
                if (bazowy.IsChecked == true && Bp.IsChecked == true && DX_check.IsChecked == true)
                {
                    this.BP_input_default.Text = SubstractHex(Adres_result.Text, Offset_input.Text);
                    this.DX_input_reg.Text = Nr_rejestru_result.Text;
                }
                //
                if (bazowy.IsChecked == true && Bx.IsChecked == true && AX_check.IsChecked == true)
                {
                    this.BX_input_default.Text = SubstractHex(Adres_result.Text, Offset_input.Text);
                    this.AX_input_reg.Text = Nr_rejestru_result.Text;
                }
                if (bazowy.IsChecked == true && Bx.IsChecked == true && BX_check.IsChecked == true)
                {
                    this.BX_input_default.Text = SubstractHex(Adres_result.Text, Offset_input.Text);
                    this.BX_input_reg.Text = Nr_rejestru_result.Text;
                }
                if (bazowy.IsChecked == true && Bx.IsChecked == true && CX_check.IsChecked == true)
                {
                    this.BX_input_default.Text = SubstractHex(Adres_result.Text, Offset_input.Text);
                    this.CX_input_reg.Text = Nr_rejestru_result.Text;
                }
                if (bazowy.IsChecked == true && Bx.IsChecked == true && DX_check.IsChecked == true)
                {
                    this.BX_input_default.Text = SubstractHex(Adres_result.Text, Offset_input.Text);
                    this.DX_input_reg.Text = Nr_rejestru_result.Text;
                }
                //
                else if (indeksowo_bazowy.IsChecked == true && (Di.IsChecked == true || Si.IsChecked == true) && (Bp.IsChecked == true || Bx.IsChecked == true) && AX_check.IsChecked == true)
                {
                    this.AX_input_reg.Text = Nr_rejestru_result.Text;
                }
                else if (indeksowo_bazowy.IsChecked == true && (Di.IsChecked == true || Si.IsChecked == true) && (Bp.IsChecked == true || Bx.IsChecked == true) && BX_check.IsChecked == true)
                {
                    this.BX_input_reg.Text = Nr_rejestru_result.Text;
                }
                else if (indeksowo_bazowy.IsChecked == true && (Di.IsChecked == true || Si.IsChecked == true) && (Bp.IsChecked == true || Bx.IsChecked == true) && CX_check.IsChecked == true)
                {
                    this.CX_input_reg.Text = Nr_rejestru_result.Text;
                }
                else if (indeksowo_bazowy.IsChecked == true && (Di.IsChecked == true || Si.IsChecked == true) && (Bp.IsChecked == true || Bx.IsChecked == true) && DX_check.IsChecked == true)
                {
                    this.DX_input_reg.Text = Nr_rejestru_result.Text;
                }
            }
        }

        private string AddHex(string a, string b)
        {
            return (int.Parse(a, NumberStyles.HexNumber) + int.Parse(b, NumberStyles.HexNumber)).ToString("X");
        }

        private string AddHex(string a, string b, string c)
        {
            return (int.Parse(a, NumberStyles.HexNumber) + int.Parse(b, NumberStyles.HexNumber) + int.Parse(c, NumberStyles.HexNumber)).ToString("X");
        }

        private string SubstractHex(string a, string b)
        {
            return (int.Parse(a, NumberStyles.HexNumber) - int.Parse(b, NumberStyles.HexNumber)).ToString("X");
        }

        private string SubstractHex(string a, string b, string c)
        {
            return (int.Parse(a, NumberStyles.HexNumber) - int.Parse(b, NumberStyles.HexNumber) - int.Parse(c, NumberStyles.HexNumber)).ToString("X");
        }

        private void dropdown_move_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void MOV2(object sender, RoutedEventArgs e)
        {
            var inputA = GetInput(dropdown_move.Text);
            var inputB = GetInput(dropdown_move2.Text);

            inputA.Text = inputB.Text;
        }

        private TextBox GetInput(string name)
        {
            if (name == "AX")
            {
                return AX_input_reg;
            }
            if (name == "BX")
            {
                return BX_input_reg;
            }
            if (name == "CX")
            {
                return CX_input_reg;
            }

            return DX_input_reg;
        }

        private void AX_check_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void BX_check_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void CX_check_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void DX_check_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void Bx_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void Bp_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void XCHG_Click(object sender, RoutedEventArgs e)
        {
            var inputA = GetInput(dropdown_xchg.Text);
            var inputB = GetInput(dropdown_xchg2.Text);

            swap(inputA, inputB);
        }

        private void dropdown_move2_Selected_1(object sender, RoutedEventArgs e)
        {
            if (dropdown_move.Text == dropdown_move2.Text)
            {
                dropdown_move2.SelectedItem = null;
            }
        }

        private void dropdown_move2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void dropdown_move2_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
        }

        private void dropdown_move2_DropDownClosed(object sender, EventArgs e)
        {
            if (dropdown_move.Text == dropdown_move2.Text)
            {
                dropdown_move2.SelectedItem = null;
            }
        }

        private void dropdown_move_DropDownClosed(object sender, EventArgs e)
        {
            if (dropdown_move.Text == dropdown_move2.Text)
            {
                dropdown_move.SelectedItem = null;
            }
        }

        private void dropdown_xchg_DropDownClosed(object sender, EventArgs e)
        {
            if (dropdown_xchg.Text == dropdown_xchg2.Text)
            {
                dropdown_xchg.SelectedItem = null;
            }
        }

        private void dropdown_xchg2_DropDownClosed(object sender, EventArgs e)
        {
            if (dropdown_xchg.Text == dropdown_xchg2.Text)
            {
                dropdown_xchg2.SelectedItem = null;
            }
        }

        private void indeksowy_Checked(object sender, RoutedEventArgs e)
        {
            if (Bp != null && Bx != null)
            {
                Bp.Visibility = Visibility.Hidden;
                Bx.Visibility = Visibility.Hidden;

                Si.Visibility = Visibility.Visible;
                Di.Visibility = Visibility.Visible;
            }
        }

        private void bazowy_Checked(object sender, RoutedEventArgs e)
        {
            if (Si != null && Di != null)
            {
                Si.Visibility = Visibility.Hidden;
                Di.Visibility = Visibility.Hidden;

                Bp.Visibility = Visibility.Visible;
                Bx.Visibility = Visibility.Visible;
            }
        }

        private void indeksowo_bazowy_Checked(object sender, RoutedEventArgs e)
        {
            if (Si != null && Di != null && Bp != null && Bx != null)
            {
                Si.Visibility = Visibility.Visible;
                Di.Visibility = Visibility.Visible;

                Bp.Visibility = Visibility.Visible;
                Bx.Visibility = Visibility.Visible;
            }
        }

        private void AX_check_Click(object sender, RoutedEventArgs e)
        {
            if (mem_reg.IsChecked == true)
                this.Nr_rejestru_result.Text = AX_input_reg.Text;

            Al_text.Visibility = Visibility.Hidden;
            Ah_text.Visibility = Visibility.Hidden;
            Adres_result_Copy.Visibility = Visibility.Hidden;
            al_result.Visibility = Visibility.Hidden;
            ah_result.Visibility = Visibility.Hidden;
        }

        private void BX_check_Click(object sender, RoutedEventArgs e)
        {
            if (mem_reg.IsChecked == true)
                this.Nr_rejestru_result.Text = BX_input_reg.Text;

            Al_text.Visibility = Visibility.Hidden;
            Ah_text.Visibility = Visibility.Hidden;
            Adres_result_Copy.Visibility = Visibility.Hidden;
            al_result.Visibility = Visibility.Hidden;
            ah_result.Visibility = Visibility.Hidden;
        }

        private void DX_check_Click(object sender, RoutedEventArgs e)
        {
            if (mem_reg.IsChecked == true)
                this.Nr_rejestru_result.Text = DX_input_reg.Text;

            Al_text.Visibility = Visibility.Hidden;
            Ah_text.Visibility = Visibility.Hidden;
            Adres_result_Copy.Visibility = Visibility.Hidden;
            al_result.Visibility = Visibility.Hidden;
            ah_result.Visibility = Visibility.Hidden;
        }

        private void CX_check_Click(object sender, RoutedEventArgs e)
        {
            if (mem_reg.IsChecked == true)
                this.Nr_rejestru_result.Text = CX_input_reg.Text;
            Al_text.Visibility = Visibility.Hidden;
            Ah_text.Visibility = Visibility.Hidden;
            Adres_result_Copy.Visibility = Visibility.Hidden;
            al_result.Visibility = Visibility.Hidden;
            ah_result.Visibility = Visibility.Hidden;
        }

        private void Random_register_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void reg_mem_Click(object sender, RoutedEventArgs e)
        {
            Nr_rejestru_result.Clear();
            Adres_result.Clear();
            Adres_result.Text = GetRandom();
            Nr_rejestru_result.Text = GetRandom();
            Adres_result_Copy.Visibility = Visibility.Hidden;
            Al_text.Visibility = Visibility.Hidden;
            Ah_text.Visibility = Visibility.Hidden;
            al_result.Visibility = Visibility.Hidden;
            ah_result.Visibility = Visibility.Hidden;
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Adres_result_Copy.Clear();
            this.Adres_result_Copy.Text = AddHex(Adres_result.Text, "1");
            Adres_result_Copy.Visibility = Visibility.Visible;
            Al_text.Visibility = Visibility.Visible;
            Ah_text.Visibility = Visibility.Visible;
            ah_result.Visibility = Visibility.Visible;
            al_result.Visibility = Visibility.Visible;
            //ah+al
            ah_result.Text = Nr_rejestru_result.Text.Substring(0, 2);
            al_result.Text = Nr_rejestru_result.Text.Substring(2);
        }

        private void mem_reg_Click(object sender, RoutedEventArgs e)
        {
            Adres_result_Copy.Visibility = Visibility.Hidden;
            Al_text.Visibility = Visibility.Hidden;
            Ah_text.Visibility = Visibility.Hidden;
            al_result.Visibility = Visibility.Hidden;
            ah_result.Visibility = Visibility.Hidden;
        }

        private void indeksowy_Click(object sender, RoutedEventArgs e)
        {
            Adres_result_Copy.Visibility = Visibility.Hidden;
            Al_text.Visibility = Visibility.Hidden;
            Ah_text.Visibility = Visibility.Hidden;
            al_result.Visibility = Visibility.Hidden;
            ah_result.Visibility = Visibility.Hidden;
        }

        private void bazowy_Click(object sender, RoutedEventArgs e)
        {
            Adres_result_Copy.Visibility = Visibility.Hidden;
            Al_text.Visibility = Visibility.Hidden;
            Ah_text.Visibility = Visibility.Hidden;
            al_result.Visibility = Visibility.Hidden;
            ah_result.Visibility = Visibility.Hidden;
        }

        private void indeksowo_bazowy_Click(object sender, RoutedEventArgs e)
        {
            Adres_result_Copy.Visibility = Visibility.Hidden;
            Al_text.Visibility = Visibility.Hidden;
            Ah_text.Visibility = Visibility.Hidden;
            al_result.Visibility = Visibility.Hidden;
            ah_result.Visibility = Visibility.Hidden;
        }

        private void Si_Click(object sender, RoutedEventArgs e)
        {
            Adres_result_Copy.Visibility = Visibility.Hidden;
            Al_text.Visibility = Visibility.Hidden;
            Ah_text.Visibility = Visibility.Hidden;
            al_result.Visibility = Visibility.Hidden;
            ah_result.Visibility = Visibility.Hidden;
        }

        private void Di_Click(object sender, RoutedEventArgs e)
        {
            Adres_result_Copy.Visibility = Visibility.Hidden;
            Al_text.Visibility = Visibility.Hidden;
            Ah_text.Visibility = Visibility.Hidden;
            al_result.Visibility = Visibility.Hidden;
            ah_result.Visibility = Visibility.Hidden;
        }

        private void Bp_Click(object sender, RoutedEventArgs e)
        {
            Adres_result_Copy.Visibility = Visibility.Hidden;
            Al_text.Visibility = Visibility.Hidden;
            Ah_text.Visibility = Visibility.Hidden;
            al_result.Visibility = Visibility.Hidden;
            ah_result.Visibility = Visibility.Hidden;
        }

        private void Bx_Click(object sender, RoutedEventArgs e)
        {
            Adres_result_Copy.Visibility = Visibility.Hidden;
            Al_text.Visibility = Visibility.Hidden;
            Ah_text.Visibility = Visibility.Hidden;
            al_result.Visibility = Visibility.Hidden;
            ah_result.Visibility = Visibility.Hidden;
        }
    }
}