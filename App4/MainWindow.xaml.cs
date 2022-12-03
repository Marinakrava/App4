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

namespace App4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString(); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resDouble = rateEuro * sumEuro;
            resSum1.Text = resDouble.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGr = Convert.ToDouble(rate2.Text);
            double sumGr = Convert.ToDouble(sum2.Text);
            double resDouble = rateGr * sumGr;
            resSum2.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateAr = Convert.ToDouble(rate3.Text);
            double sumAr = Convert.ToDouble(sum3.Text);
            double resDouble = rateAr * sumAr;
            resSum3.Text = resDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double duim = Convert.ToDouble(name1.Text);
            double cons = 0.0254;// постоянная величина. количетсво дюймов в одном метре
            double resDouble = duim * cons;
            res1.Text = resDouble.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double fut = Convert.ToDouble(name2.Text);
            double cons = 0.3048;// постоянная величина. количетсво футов в одном метре
            double resDouble = fut * cons;
            res2.Text = resDouble.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double mili = Convert.ToDouble(name3.Text);
            double cons = 1609.34;// постоянная величина. количетсво миль в одном метре
            double resDouble = mili * cons;
            res3.Text = resDouble.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double verst = Convert.ToDouble(name4.Text);
            double cons = 1066.80;// постоянная величина. количетсво верст в одном метре
            double resDouble = verst * cons;
            res4.Text = resDouble.ToString();
        }
    }
}
