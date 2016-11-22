using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbTikets.Domain;

namespace DbTikects.Repository
{
    public interface IProductoRepository
    {
        IEnumerable<Producto> GetProductos(string criterio);

        IQueryable<Producto> GetProductosQueryable(string criterio);

        Producto GetProducto(Int32 id);

        void AddProducto(Producto producto);

        void UpdateProducto(Producto producto);

        void DeleteProducto(Int32 producto);
    }
}
