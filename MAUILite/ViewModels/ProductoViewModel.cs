using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MAUILite.Models;
using MAUILite.Views;
using PropertyChanged;

namespace MAUILite.ViewModels
{
	[AddINotifyPropertyChangedInterface]
	public class ProductoViewModel
	{
		public ObservableCollection<Producto> ListaProductos { get; set; }

		public ProductoViewModel()
		{
			ListaProductos = new ObservableCollection<Producto>(App.ProductoRepository.GetAll());
		}

		public ICommand CrearProducto => new Command(() =>
		{
			App.Current.MainPage.Navigation.PushAsync(new NuevoProductoPage());
		});

        public async void DesplegarProductos()
        {
            ListaProductos = new ObservableCollection<Producto>(App.ProductoRepository.GetAll());
        }
    }
}

