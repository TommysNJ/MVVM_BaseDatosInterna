using System;
using System.Windows.Input;
using MAUILite.Models;

namespace MAUILite.ViewModels
{
	public class NuevoProductoViewModel
	{
		public string Nombre { get; set; }
		public string Descripcion { get; set; }
		public int Cantidad { get; set; }

		public ICommand GuardarProducto =>
			new Command(async () =>
			{
				Producto producto = new Producto
				{
					Nombre = Nombre,
					Descripcion = Descripcion,
					Cantidad = Cantidad
				};
				App.ProductoRepository.Add(producto);
				await App.Current.MainPage.Navigation.PopAsync();
			});
	}
}

