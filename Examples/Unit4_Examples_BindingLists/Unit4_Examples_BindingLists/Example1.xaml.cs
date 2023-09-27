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

namespace Unit4_Examples_BindingLists
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Example1 : Window
    {
        public Example1()
        {
            InitializeComponent();
            DataContext = new Thing();

            var ex2 = new Example2();
            ex2.Show();
            var ex3 = new Example3();
            ex3.Show();
        }
    }
}
