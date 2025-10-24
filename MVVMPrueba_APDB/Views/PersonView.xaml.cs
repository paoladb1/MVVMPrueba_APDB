using MVVMPrueba_APDB.ViewModel;

namespace MVVMPrueba_APDB.Views;

public partial class PersonView : ContentPage
{
    public PersonView()
    {
        InitializeComponent();

        BindingContext = new PersonviewModel();
    }
}