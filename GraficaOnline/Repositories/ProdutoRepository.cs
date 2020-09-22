using GraficaOnline.Context;
using GraficaOnline.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GraficaOnline.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Produto> Produtos => _context.Produtos.Include(c => c.Categoria);

        public IEnumerable<Produto> ProdutosPreferidos => _context.Produtos.Where(p => p.IsProdutoPreferida).Include(c => c.Categoria);

        public Produto GetProdutoById(int produtoId)
        {
            return _context.Produtos.FirstOrDefault(l => l.ProdutoId == produtoId);

        }
    }
}
