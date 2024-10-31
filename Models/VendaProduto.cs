using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PetShop_Provei.Models
{
    public class VendaProduto
    {
        public int ID { get; set; }

        [ForeignKey("Venda")]
        public int VendaID { get; set; } 

        [ForeignKey("Produto")]
        public int ProdutoID { get; set; } 

        public int Quantidade { get; set; }
    }
}
