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

namespace Unit7_Examples_Resources_Styles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Example1Window : Window
    {
        public Example1Window()
        {
            InitializeComponent();
            var win2 = new Example2Window();
            win2.Show();
            var win3 = new Example3Window();
            win3.Show();
            var win4 = new Example4Window();
            win4.Show();
            var win5 = new Example5Window();
            win5.Show();
        }
    }
}
