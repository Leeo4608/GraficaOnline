using GraficaOnline.Models;
using System.Collections.Generic;

namespace GraficaOnline.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Produto> ProdutosPreferidos { get; set; }
    }
}
