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

namespace Pr_20._101_Ivanov_1var
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt_result_Click(object sender, RoutedEventArgs e)
        {
            string res = tb_vvod.Text;
            int[] sim;
            lb_result.Items.Clear();
            lb_test.Items.Clear();
            try
            {
                if (Int64.TryParse(tb_vvod.Text, out Int64 number))
                {
                    if (res.Length == 12)
                    {
                        int proiz = 1;
                        int summa = 0;
                        sim = number.ToString().ToCharArray().Select(x => Convert.ToInt32(x.ToString())).ToArray<int>();
                        for (int i = 0; i < sim.Length; i++)
                        {
                            if (i == 0 || i == 1 || i == 2)
                            {
                                proiz *= sim[i];
                            }
                            else
                            {
                                summa += sim[i];
                            }
                        }
                        lb_test.Items.Add($"Произведение первых 3: {proiz}\n Сумма 9 последних: {summa}");
                        if (proiz == summa)
                        {
                            lb_result.Items.Add($"Произведение первых 3 равняется сумме 9 последних");
                        }
                        else
                        {
                            lb_result.Items.Add($"Произведение первых 3 не равняется сумме 9 последних");
                        }
                    }
                    else
                    {
                        lb_result.Items.Add("Должно быть двенадцатизначное число");
                    }


                }
                else
                {
                    lb_result.Items.Add("Это не число");
                }
            }
            catch
            {
                lb_result.Items.Add("Что-то пошло не так ...");
            }
            
        }
    }
}