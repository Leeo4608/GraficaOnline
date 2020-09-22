using GraficaOnline.Models;
using System.Collections.Generic;

namespace GraficaOnline.ViewModels
{
    public class PedidoProdutoViewModel
    {
        public Pedido Pedido { get; set; }
        public IEnumerable<PedidoDetalhe> PedidoDetalhes { get; set; }
    }
}
