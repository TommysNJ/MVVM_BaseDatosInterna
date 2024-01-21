using MAUILite.Models;
using MAUILite.ViewModels;

namespace MAUILite.Views;

public partial class ProductoPage : ContentPage
{
    private readonly ProductoViewModel _viewModel;

    public ProductoPage()
	{
		InitializeComponent();
        _viewModel = new ProductoViewModel();
        BindingContext = _viewModel;
    }

    protected override async void OnAppearing() 
    {
        base.OnAppearing();
        _viewModel.DesplegarProductos();
    }

    private async void DetalleProducto(object sender, SelectedItemChangedEventArgs e)
    {

        Producto producto = e.SelectedItem as Producto;
        await Navigation.PushAsync(new DetalleProductoPage(producto));
    }

}