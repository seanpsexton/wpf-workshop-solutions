using System.Windows;

namespace Exercise1_Layout
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Part1Window : Window
    {
        public Part1Window()
        {
            InitializeComponent();
            var part2 = new Part2Window();
            part2.Show();
            var experiments = new Experiments();
            experiments.Show();
        }
    }
}
