using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShop.Models
{
    public class Movimentacao
    {
        public int MovimentacaoId { get; set; }

        //Relacionamento com o Produto
        [Required(ErrorMessage = "O Produto é Obrigatório")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        //Relacionamento com a Tabela de Usuarios (Identiy Framework)
        public string? UsuarioId { get; set; }
        public IdentityUser? Usuario { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Digite uma quantidade válida.")]
        public int Quantidade { get; set; }

        [Required]
        [AllowedValues("E", "S", ErrorMessage = "Selecione o Tipo de Movimentação entre Entradas ou Saídas.")]
        [Display(Name = "Tipo de Movimentação")]
        public string? Tipo { get; set; } // Tipo de Movimentação (Entrada ou Saída)

        [Display(Name = "Valor Total")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorTotal { get; set; }
        // Saída => PrecoVenda * Quantidade
        // Entrada => PrecoCusto * Quantidade
    }
}
