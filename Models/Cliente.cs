using System.ComponentModel.DataAnnotations;

namespace PetShop_Provei.Models
{
    public class Cliente
    {
        [Key]
            public Guid ID { get; set; }

            [Required]
            [StringLength(100)]
            public string Nome { get; set; }

            [Required]
            [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve ter 11 dígitos.")]
            public string CPF { get; set; }

            [Required]
            [StringLength(200)]
            public string Endereco { get; set; }

            [Required]
            [Phone]
            public string Telefone { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            public bool Ativo { get; set; }
        }
    }

