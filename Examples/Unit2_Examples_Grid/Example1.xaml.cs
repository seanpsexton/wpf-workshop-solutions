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

namespace Unit2_Examples_Grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Example1 : Window
    {
        public Example1()
        {
            InitializeComponent();
            var ex2 = new Example2();
            ex2.Show();
            var ex3 = new Example3();
            ex3.Show();
            var ex4 = new Example4();
            ex4.Show();
            var ex5 = new Example5();
            ex5.Show();
        }
    }
}
