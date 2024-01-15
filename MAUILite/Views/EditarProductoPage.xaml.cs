using MAUILite.Models;
using MAUILite.ViewModels;

namespace MAUILite.Views;

public partial class EditarProductoPage : ContentPage
{
	public EditarProductoPage(Producto producto)
	{
		InitializeComponent();
        BindingContext = new EditarProductoViewModel(producto);
    }
}
