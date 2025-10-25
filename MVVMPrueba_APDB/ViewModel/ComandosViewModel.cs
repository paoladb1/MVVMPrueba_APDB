using System.Windows.Input;

namespace MVVMPrueba_APDB.ViewModel
{
    public class ComandosViewModel
    {
        public ICommand ClickComand { get; }
        public ICommand SearchCommand { get; }
        public string SearchData { get; set; }

        public ComandosViewModel()
        {
            ClickComand = new Command(() =>
            {
                App.Current.MainPage.DisplayAlert("Hola", " Recibi tu mensaje", "Cancelar");
            });

            SearchCommand = new Command((s) =>
            {
                var data = s;

            });
        }
            
        private void Arlet() 
        {
            
        }
    }

}
