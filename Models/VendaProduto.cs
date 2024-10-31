using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PetShop_Provei.Models
{
    public class VendaProduto
    {
        [Key]
        public Guid ID { get; set; } = Guid.NewGuid();

        [ForeignKey("Venda")]
        public int VendaID { get; set; } 

        [ForeignKey("Produto")]
        public int ProdutoID { get; set; } 

        public int Quantidade { get; set; }
    }
}
