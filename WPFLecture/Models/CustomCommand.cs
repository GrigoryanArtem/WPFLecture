using System;
using System.Windows.Input;

namespace WPFLecture.Models
{
    public class CustomCommand : ICommand
    {
        private Action<object> mExecuteAction;
        private Func<object, bool> mCanExecute;

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public CustomCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            mExecuteAction = execute;
            mCanExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return mCanExecute == null || mCanExecute(parameter);
        }

        public void Execute(object parameter)
        {
            mExecuteAction(parameter);
        }
    }
}
