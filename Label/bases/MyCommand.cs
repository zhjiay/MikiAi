using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Label.bases
{
    public class MyCommand<T> : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action<T> act;
        private Func<T, bool> func;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            this.act.Invoke((T)parameter);
        }

        public MyCommand(Action<T> act)
        {
            this.act = act;
        }
    }
}
