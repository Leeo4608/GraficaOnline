using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraficaOnline.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [StringLength(100)]
        [Display(Name = "Nome")]
        public string CategoriaNome { get; set; }
        [StringLength(250)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
