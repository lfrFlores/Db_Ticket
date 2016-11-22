using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  DbTikets.Domain;

namespace DbTikects.Repository
{
    public class CategoriaRepository:ICategoriaRepository
    {
        private DbTikectsContext _context;

        public CategoriaRepository()
        {
            if (_context == null)
            {
                _context = new DbTikectsContext();
            }
        }
        public IEnumerable<Categoria> GetCategorias()
        {
            return _context.Categorias;
        }
    }
}
