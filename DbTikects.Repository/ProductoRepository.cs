using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbTikets.Domain;

namespace DbTikects.Repository
{
    public class ProductoRepository:IProductoRepository
    {
        private DbTikectsContext _context;

        public ProductoRepository()
        {
            if (_context == null)
            {
                _context = new DbTikectsContext();
            }
        }

        public IEnumerable<Producto> GetProductos(string criterio)
        {
            var query = from c in _context.Productos.Include("Categoria")
                        select c;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from c in query
                    where c.Descripcion.ToUpper().Contains(criterio.ToUpper())
                    select c;


            }

            return query;
        }

        public Producto GetProducto(int id)
        {
           return _context.Productos.Find(id);
        }

        public void AddProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public void UpdateProducto(Producto producto)
        {
            _context.Entry(producto).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteProducto(int producto)
        {
            var prd = _context.Productos.Find(producto);

            if (prd != null)
            {
                _context.Entry(prd).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }


        public IQueryable<Producto> GetProductosQueryable(string criterio)
        {
            throw new NotImplementedException();
        }
    }
}
