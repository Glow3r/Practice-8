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

namespace Practice_8
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

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            Pair pair = new Pair(int.Parse(firsttriadA.Text), int.Parse(secondtriadA.Text));
            outputResult.Text = pair.Sum();
        }

        private void DIfference_Click(object sender, RoutedEventArgs e)
        {
            Pair pair = new Pair(int.Parse(firsttriadA.Text), int.Parse(secondtriadA.Text));
            outputResult.Text = pair.Difference();
        }

        private void Product_Click(object sender, RoutedEventArgs e)
        {
            Pair pair = new Pair(int.Parse(firsttriadA.Text), int.Parse(secondtriadA.Text));
            outputResult.Text = pair.Product();
        }

        private void Quotient_Click(object sender, RoutedEventArgs e)
        {
            Pair pair = new Pair(int.Parse(firsttriadA.Text), int.Parse(secondtriadA.Text));
            outputResult.Text = pair.Quotient();
        }

        private void Compare_Click(object sender, RoutedEventArgs e)
        {
            Pair firstpair = new Pair(int.Parse(firsttriadA.Text), int.Parse(secondtriadA.Text));
            Pair secondpair = new Pair(int.Parse(firsttriadB.Text), int.Parse(secondtriadB.Text));

            int result = firstpair.CompareTo(secondpair);

            if (result < 0) MessageBox.Show("Пара А меньше пары Б");
            if (result > 0) MessageBox.Show("Пара А больше пары Б");
            if (result == 0) MessageBox.Show("Пара А равна паре Б");
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Гаврюшин К. А. ИСП-34.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
