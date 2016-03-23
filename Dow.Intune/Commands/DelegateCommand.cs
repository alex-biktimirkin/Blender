using Dow.Intune.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Dow.Intune.ViewModels.Base
{
    public class DelegateCommand : ICommand
    {
        private readonly Action execute = null;
        private readonly Func<bool> canExecute = null;

        public DelegateCommand(Action execute)
            : this(execute, null) { }

        public DelegateCommand(Action execute, Func<bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return this.canExecute != null ? this.canExecute() : true;
        }

        public void Execute(object parameter)
        {
            if (this.execute != null)
                this.execute();
        }

        public void OnCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }
    }

    public class DelegateCommand<T> : ICommand
    {
        private readonly Action<T> execute = null;
        private readonly Predicate<T> canExecute = null;

        public DelegateCommand(Action<T> execute)
            : this(execute, null) { }

        public DelegateCommand(Action<T> execute, Predicate<T> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            var typedParameter = (T)parameter;
            return CanExecute(typedParameter);
        }

        public void Execute(object parameter)
        {
            var typedParameter = (T)parameter;
            Execute(typedParameter);
        }

        public void OnCanExecuteChanged()
        {
            var tmp = CanExecuteChanged;
            if (tmp != null)
                tmp(this, EventArgs.Empty);
        }

        private bool CanExecute(T parameter)
        {
            return this.canExecute != null ? this.canExecute(parameter) : true;
        }

        private void Execute(T parameter)
        {
            if (this.execute != null)
                this.execute(parameter);
        }
    }
}
