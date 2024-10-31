using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShop_Provei.Models
{
    public class Venda
    {
        [Key]
        public Guid ID { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Data_Emissao { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Valor_Total { get; set; }
    }
}
