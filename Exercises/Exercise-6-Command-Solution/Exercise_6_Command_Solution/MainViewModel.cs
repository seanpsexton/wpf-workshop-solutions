using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace Exercise_6_Command_Solution
{
    public class MainViewModel : ViewModelBase
    {
        private ICommand myCommand;
        private bool canMessage;

        public MainViewModel()
        {
            myCommand = new DelegateCommand(
                (_) => MessageBox.Show("Hello MTS"),
                (_) => CanMessage);
        }

        public ICommand MyCommand => myCommand;

        public bool CanMessage
        {
            get => canMessage;
            set => SetValue(ref canMessage, value);
        }
    }
}
