using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Unit6_Examples_Command
{
    internal class MainViewModel : ViewModelBase
    {
        private ICommand myCommand;

        public MainViewModel()
        {
            myCommand = new DelegateCommand(
                (_) => MessageBox.Show("Hello MTS"),
                (_) => true);
        }

        public ICommand MyCommand => myCommand;
    }
}
