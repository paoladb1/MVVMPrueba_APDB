using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMPrueba_APDB.ViewModel
{
    public class ComandosViewModel
    {
        public ICommand ClickComand { get; }
           
        public ComandosViewModel()
        {
            ClickComand = new Command(() =>
            {
                App.Current.MainPage.DisplayAlert("Hola", " Recibi tu mensaje", "Cancelar");
            });
        }
            
        private void Arlet() 
        {
            
        }
    }

}
