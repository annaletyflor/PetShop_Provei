using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PetShop_Provei.Models
{
    public class Produto
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [Required]
        public int Quantidade_Estoque { get; set; }

        [ForeignKey("Fornecedor")]
        public int FornecedorID { get; set; } 
    }
}
