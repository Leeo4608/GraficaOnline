using GraficaOnline.Models;
using System.Collections.Generic;

namespace GraficaOnline.Repositories
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
