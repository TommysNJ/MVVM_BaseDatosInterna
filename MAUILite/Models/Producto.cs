using System;
using PropertyChanged;
using SQLite;

namespace MAUILite.Models
{
    [Table("Productos")]
    [AddINotifyPropertyChangedInterface]
    public class Producto
    {
        [PrimaryKey, AutoIncrement]
		public int IdProducto { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
        [Column("descripción")]
        public string Descripcion { get; set; }
        [Column("cantidad")]
        public int Cantidad { get; set; }
    }
}

