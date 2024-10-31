using System.ComponentModel.DataAnnotations;

namespace PetShop_Provei.Models
{
    public class Fornecedor
    {
        [Key]
        public Guid ID { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(100)]
        public string Nome_Empresa { get; set; }

        [Required]
        [RegularExpression(@"^\d{14}$", ErrorMessage = "O CNPJ deve ter 14 dígitos.")]
        public string CNPJ { get; set; }

        [Required]
        [StringLength(200)]
        public string Endereco { get; set; }

        [Required]
        [Phone]
        public string Telefone { get; set; }
    }
}
