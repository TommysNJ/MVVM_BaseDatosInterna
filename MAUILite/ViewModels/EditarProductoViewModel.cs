using System;
using System.Windows.Input;
using MAUILite.Models;
using PropertyChanged;

namespace MAUILite.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class EditarProductoViewModel
	{
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public Producto InfProducto { get; set; }

        public EditarProductoViewModel(Producto producto)
		{
            if (producto != null)
            {
                Nombre = producto.Nombre;
                Descripcion = producto.Descripcion;
                Cantidad = producto.Cantidad;
                InfProducto = producto;
            }
        }

        //se debe enviar el IdProducto para saber cuál debemos editar
        public ICommand Editar =>
            new Command(async () =>
            {
                Producto producto = new Producto
                {
                    Nombre = Nombre,
                    Descripcion = Descripcion,
                    Cantidad = Cantidad,
                    IdProducto = InfProducto.IdProducto
                };
                App.ProductoRepository.Update(producto);
                await App.Current.MainPage.Navigation.PopAsync();
            });

    }
}

