using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



//importamos
using DbTikets.Service;
using DbTikets.Domain;
using PagedList;

namespace DbTikects.Web.Controllers
{
    public class ProductoController : Controller
    {
        private IProductoService _service;
        private ICategoriaService _categoriaServiceervice;

        public ProductoController(IProductoService productoService,
            ICategoriaService categoriaService)
        {
            _service = productoService;
            _categoriaServiceervice = categoriaService;
        }

        //public ProductoController()
        //{
        //    if (_service == null)
        //    {
        //        _service = new ProductoService();
        //    }

        //    if (_categoriaServiceervice == null)
        //    {
        //        _categoriaServiceervice = new CategoriaService();
        //    }
        //}
        
        // GET: Producto
        public ActionResult Index(string criterio, int? page)
        {
            var pageIndex = page ?? 1;
            ViewBag.Criterio = criterio;

            var lista = _service.GetProductosQueryable(criterio).ToPagedList(pageIndex, 3);

            return Request.IsAjaxRequest() ? (ActionResult)PartialView("_Index", lista) : View(lista);
        }

        [HttpPost]
        public ActionResult Index(string criterio)
        {
            var lista = _service.GetProductos(criterio);

            return PartialView("_Index", lista);
        }

        public ActionResult Create()
        {
            var categorias = _categoriaServiceervice.GetCategorias();

            ViewBag.Categorias = new SelectList(categorias, "Id", "Descripcion");
            return PartialView("_Create");
        }

        [HttpPost]
        public ActionResult Create(Producto producto)
        {

           // _context.Productos.Add(producto);
            //_context.SaveChanges();
            if (ModelState.IsValid)
            {
                _service.AddProducto(producto);

                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(Int32 id)
        {
            var producto = _service.GetProducto(id);

            var categorias = _categoriaServiceervice.GetCategorias();

            ViewBag.Categorias = new SelectList(categorias, "Id", "Descripcion",producto.CategoriaId);
            

            return PartialView("_Edit",producto);
        }
    }
}