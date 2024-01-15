using MAUILite.Models;
using MAUILite.ViewModels;

namespace MAUILite.Views;

public partial class DetalleProductoPage : ContentPage
{
    private readonly DetalleProductoViewModel _viewModel;

    public DetalleProductoPage(Producto producto)
	{
		InitializeComponent();
        _viewModel = new DetalleProductoViewModel(producto);
        BindingContext = _viewModel;
    }

    protected override async void OnAppearing() 
    {
        base.OnAppearing();
        _viewModel.DesplegarProductos();
    }

}
