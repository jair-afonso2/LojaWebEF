using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaWebEF.Models
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduto { get; set; }
        [Required(ErrorMessage = "Insira o nome do produto")]
        [StringLength(100, MinimumLength = 2)]
        public string NomeProduto { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Descricao { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [Required]
        public int Quantidade { get; set; }

        public ICollection<Pedido> Pedido { get; set;}
    }
}