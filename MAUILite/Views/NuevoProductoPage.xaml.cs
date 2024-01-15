using MAUILite.ViewModels;

namespace MAUILite.Views;

public partial class NuevoProductoPage : ContentPage
{
	public NuevoProductoPage()
	{
		InitializeComponent();
        BindingContext = new NuevoProductoViewModel();
    }

    /*private async void OnClickVolver(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }*/
}
