using MVVMPrueba_APDB.ViewModel;

namespace MVVMPrueba_APDB.Views;

public partial class GenteView : ContentPage
{
	public GenteView()
	{
		InitializeComponent();
		BindingContext = new GenteviewModel();
	}
}