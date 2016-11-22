using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importamos
using DbTikects.Repository;
using DbTikets.Domain;

namespace DbTikets.Service
{
    public class ProductoService:IProductoService
    {
        private IProductoRepository _repository;

        //public ProductoService()
        //{
        //    if (_repository == null)
        //    {
        //        _repository = new ProductoRepositoryOracle();
        //    }
        //}

        public ProductoService(IProductoRepository productoRepository)
        {
            _repository = productoRepository;
        }
        public IEnumerable<Producto> GetProductos(string criterio)
        {
            return _repository.GetProductos(criterio);
        }

        public Producto GetProducto(int id)
        {
            return _repository.GetProducto(id);
        }

        public void AddProducto(Producto producto)
        {
            _repository.AddProducto(producto);
        }

        public void UpdateProducto(Producto producto)
        {
            _repository.UpdateProducto(producto);
        }

        public void DeleteProducto(int producto)
        {
            _repository.DeleteProducto(producto);
        }


        public IQueryable<Producto> GetProductosQueryable(string criterio)
        {
            return _repository.GetProductosQueryable(criterio);
        }
    }
}
