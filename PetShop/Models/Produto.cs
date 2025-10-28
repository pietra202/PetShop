using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShop.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O Nome do produto é obrigatório.")]
        [StringLength(100)]
        [Display(Name = "Nome do Produto")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "A Marca do produto é obrigatória.")]
        [StringLength(100)]
        [Display(Name = "Marca")]
        public string? Marca { get; set; }

        [Required(ErrorMessage = "A Categoria do produto é obrigatória.")]
        [StringLength(100)]
        [Display(Name = "Categoria")]
        public string? Categoria { get; set; }

        [StringLength(100)]
        public string? Animal { get; set; }

        [StringLength(100)]
        public string? Porte { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "A Idade não pode ser negativa.")]
        [Display(Name = "Idade (Meses)")]
        public int? Idade { get; set; }

        [Display(Name = "Variações")]
        [DataType(DataType.MultilineText)]
        public string? Variacao { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "O Estoque Atual não pode ser negativo.")]
        [Display(Name = "Estoque Atual")]
        public int EstoqueAtual { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "O Estoque Mínimo não pode ser negativo.")]
        [Display(Name = "Estoque Mínimo")]
        public int EstoqueMinimo { get; set; }

        [Required]
        [Display(Name = "Preço de Custo")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal PrecoCusto { get; set; }

        [Required]
        [Display(Name = "Preço de Venda")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal PrecoVenda { get; set; }
    }
}
