using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbTikets.Domain;

namespace DbTikects.Repository
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> GetCategorias();
    }
}
