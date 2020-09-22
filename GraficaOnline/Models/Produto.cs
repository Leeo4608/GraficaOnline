using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraficaOnline.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(300)]
        public string Descricao { get; set; }
        [StringLength(300)]
        [Display(Name = "Imagem")]
        public string ImagemUrl { get; set; }
        [StringLength(300)]
        public string ImagemThumbnailUrl { get; set; }
        [StringLength(100)]
        public string Marca { get; set; }
        public int Quantidade { get; set; }
        public bool IsProdutoPreferida { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorCompra { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorVenda { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
