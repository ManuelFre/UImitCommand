using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UImintCommand.Commands;

namespace UImintCommand.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public String InputValue { get; set; }
        private String outputValue;



        public String OutputValue
        {
            get { return outputValue; }
            set { outputValue = value; OnChange("OutoutValue"); }
        }

        public RelayCommand ButtonClickedCommand { get; set; }
        public MainViewModel()              //Shortcut : CTOR tab tab
        {
            //ButtonClickedCommand = new RelayCommand(new Informer(ButtonClicked));
            //InputValue = "Initial Value";       //Das funktionierte am Anfang irgendwie nicht! Warum?

            //Lambda expression:
            ButtonClickedCommand = new RelayCommand(() =>
            {
                outputValue = InputValue.ToUpper();
            });

        }

        //-----------------------------------Von Interface---------------------------------------->>>
        public event PropertyChangedEventHandler PropertyChanged;

        private void ButtonClicked()
        {
            outputValue = InputValue.ToUpper();
        }

        private void OnChange(string propName)
        {
            if(PropertyChanged != null)
            { 
                PropertyChanged(this,new PropertyChangedEventArgs(propName) );            //mit this übergebe ich den Objektnamen vom aufzurufenden Objekt
            }
        }

        //<<<-----------------------------------Von Interface----------------------------------------
    }
}
