using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTikets.Domain
{
    public class Producto
    {
        public Int32 Id { get; set; }
        public Int32 CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
        public string  Codigo{ get; set; }
        public string Descripcion { get; set; }
        public decimal  Precio{ get; set; }
        public decimal  Stock{ get; set; }
        public string  Foto{ get; set; }
        public bool Descontinuado { get; set; }
      
    }
}
