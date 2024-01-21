using MAUILite.ViewModels;

namespace MAUILite.Views;

public partial class NuevoProductoPage : ContentPage
{
	public NuevoProductoPage()
	{
		InitializeComponent();
        BindingContext = new NuevoProductoViewModel();
    }

}
