using MVVMPrueba_APDB.Views;

namespace MVVMPrueba_APDB
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ComandosView();
        }
    }
}
