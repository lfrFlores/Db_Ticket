using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbTikets.Domain;

namespace DbTikets.Service
{
    public interface ICategoriaService
    {
        IEnumerable<Categoria> GetCategorias();
    }
}
