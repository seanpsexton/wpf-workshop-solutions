using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Exercise_6_Command_Solution
{
    public class DelegateCommand<T> : ICommand, INotifyPropertyChanged
    {
        private readonly Predicate<T> _canExecute;
        private readonly Action<T> _execute;

        public DelegateCommand(Action<T> execute)
          : this(execute, (Predicate<T>)(o => true))
        {
        }

        public DelegateCommand(Action<T> execute, Predicate<T> canExecute)
        {
            this._execute = execute;
            this._canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => this._canExecute == null || this._canExecute((T)parameter);

        public void Execute(object parameter) => this._execute((T)parameter);

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public void RaiseCanExecuteChanged() => CommandManager.InvalidateRequerySuggested();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyname = null)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged == null)
                return;
            propertyChanged((object)this, new PropertyChangedEventArgs(propertyname));
        }
    }

    public class DelegateCommand : DelegateCommand<object>
    {
        public DelegateCommand(Action<object> executeAction)
          : this(executeAction, (Predicate<object>)(o => true))
        {
        }

        public DelegateCommand(Action<object> executeAction, Predicate<object> canExecuteAction)
          : base(executeAction, canExecuteAction)
        {
        }
    }
}
