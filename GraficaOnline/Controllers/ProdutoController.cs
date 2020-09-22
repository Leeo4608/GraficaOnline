using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraficaOnline.Models;
using GraficaOnline.Repositories;
using GraficaOnline.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GraficaOnline.Controllers
{
    public class ProdutoController : Controller
    {
        private ICategoriaRepository _categoriaRepository { get; }
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoController(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository)
        {

            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult List(string categoria)
        {
            //string _categoria = categoria;
            IEnumerable<Produto> produtos;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                produtos = _produtoRepository.Produtos.OrderBy(p => p.ProdutoId);
                categoriaAtual = "Todos os produtos";
            }
            else
            {
                //if (string.Equals("Personalizado", _categoria, StringComparison.OrdinalIgnoreCase))
                //    produtos = _produtoRepository.Produtos
                //.Where(p => p.Categoria.CategoriaNome.Equals("Personalizado")).OrderBy(p => p.Nome);
                //else
                //    produtos = _produtoRepository.Produtos
                //.Where(p => p.Categoria.CategoriaNome.Equals("Não personalizado")).OrderBy(p => p.Nome);

                produtos = _produtoRepository.Produtos
                .Where(p => p.Categoria.CategoriaNome.Equals(categoria)).OrderBy(p => p.Nome);

                categoriaAtual = categoria;
            }

            var ProdutoListViewModel = new ProdutoListViewModel
            {
                Produtos = produtos,
                CategoriaAtual = categoriaAtual
            };

            return View(ProdutoListViewModel);
        }



        public ViewResult Details(int produtoId)
        {
            var produto = _produtoRepository.Produtos.FirstOrDefault(d => d.ProdutoId == produtoId);
            if (produto == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(produto);
        }
        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Produto> produtos;
            string currentCategory = string.Empty;
            //Se o usuário nao digitar nada, traz todos os produtos, se nao traz o produto pesquisado
            if (string.IsNullOrEmpty(_searchString))
            {
                produtos = _produtoRepository.Produtos.OrderBy(p => p.ProdutoId);
            }
            else
            {
                produtos = _produtoRepository.Produtos.Where(p => p.Nome.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Produto/List.cshtml", new ProdutoListViewModel { Produtos = produtos, CategoriaAtual = "Todos os produtos" });
        }
    }
}
