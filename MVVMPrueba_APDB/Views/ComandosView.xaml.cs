using MVVMPrueba_APDB.ViewModel;

namespace MVVMPrueba_APDB.Views;

public partial class ComandosView : ContentPage
{
	public ComandosView()
	{
		InitializeComponent();
		BindingContext = new ComandosViewModel();
	}
}