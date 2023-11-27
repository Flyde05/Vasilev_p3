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

namespace Vasilev_p3
{
        
        public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
            }

            private void Button_Click(object sender, RoutedEventArgs e)
            {
                if (!double.TryParse(tbA.Text, out double a))
                {
                    MessageBox.Show("Поле a только число");
                }

                if (!double.TryParse(tbB.Text, out double b))
                {
                    MessageBox.Show("Поле b только число");
                }
                double S = a * b;
                double P = 2 * (a + b);
                MessageBox.Show($"S={S,1:f1} P={P,2:f1}");

            }
        }
    }


