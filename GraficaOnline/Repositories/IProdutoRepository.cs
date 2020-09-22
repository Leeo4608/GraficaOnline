using GraficaOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraficaOnline.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Produtos { get; }
        IEnumerable<Produto> ProdutosPreferidos { get; }
        Produto GetProdutoById(int produtoId);
    }
}
