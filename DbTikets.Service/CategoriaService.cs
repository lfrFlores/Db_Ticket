using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbTikects.Repository;
using DbTikets.Domain;

namespace DbTikets.Service
{
    public class CategoriaService:ICategoriaService
    {
        private ICategoriaRepository _repository;

        //public CategoriaService()
        //{
        //    if (_repository == null)
        //    {
        //        _repository = new CategoriaRepository();
        //    }
        //}

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _repository = categoriaRepository;
        }
       
        public IEnumerable<Domain.Categoria> GetCategorias()
        {
            return _repository.GetCategorias();
        }
    }
}
