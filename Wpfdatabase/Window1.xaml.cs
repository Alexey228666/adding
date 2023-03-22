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
using WpfApp1.KRINGEDataSetTableAdapters;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        DepartmentTableAdapter dep = new DepartmentTableAdapter();
        public Window1()
        {
            InitializeComponent();
            chicken.ItemsSource = dep.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dep.InsertQuery(myaso.Text);
            chicken.ItemsSource = dep.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window2 verst = new Window2();
            verst.Show();
        }
    }
}