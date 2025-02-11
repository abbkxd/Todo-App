using System.Windows.Input;

namespace Todo_UserControls.MVVM.Helper
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object,bool> canExecute;

        public RelayCommand()
        {
            this._execute = _execute!;
            this.canExecute = canExecute!;
        }
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return canExecute==null||canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
