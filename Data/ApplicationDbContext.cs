using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetShop_Provei.Models;

namespace PetShop_Provei.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PetShop_Provei.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<PetShop_Provei.Models.Fornecedor> Fornecedor { get; set; } = default!;
        public DbSet<PetShop_Provei.Models.Produto> Produto { get; set; } = default!;
        public DbSet<PetShop_Provei.Models.Venda> Venda { get; set; } = default!;
        public DbSet<PetShop_Provei.Models.VendaProduto> VendaProduto { get; set; } = default!;
    }
}
