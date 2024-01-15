using System;
using System.Windows.Input;
using Android.Widget;
using MAUILite.Models;
using MAUILite.Views;
using PropertyChanged;

namespace MAUILite.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class DetalleProductoViewModel
	{
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public Producto InfProducto { get; set; }

        public DetalleProductoViewModel(Producto producto)
		{
            if (producto != null)
            {
                Nombre = producto.Nombre;
                Descripcion = producto.Descripcion;
                Cantidad = producto.Cantidad;
                InfProducto = producto;
            }
        }

        public async void DesplegarProductos()
        {
            Producto nuevoProducto = App.ProductoRepository.Get(InfProducto.IdProducto);
            Nombre = nuevoProducto.Nombre;
            Descripcion = nuevoProducto.Descripcion;
            Cantidad = nuevoProducto.Cantidad;
            InfProducto = nuevoProducto;

        }

        public ICommand Eliminar =>
            new Command(async () =>
            {

                App.ProductoRepository.Delete(InfProducto.IdProducto);
                await App.Current.MainPage.Navigation.PopAsync();
            });

        public ICommand Editar =>
            new Command(async () =>
            {

                await App.Current.MainPage.Navigation.PushAsync(new EditarProductoPage(InfProducto));
            });

    }
}

