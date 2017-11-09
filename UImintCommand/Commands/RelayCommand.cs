using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;                             //wird für Interface Icommand verwendet

namespace UImintCommand.Commands
{
    public class RelayCommand : ICommand                //Einbinden des Interfaces Icommand (Wird später von mvvmlight gemacht)
        //Leitet nur Informationen zwischen View und ViewModel weiter
    {
        public event EventHandler CanExecuteChanged;
        Informer doIt;
        public RelayCommand(Informer doIt)
        {
            this.doIt = doIt;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            doIt();
        }
    }
}
