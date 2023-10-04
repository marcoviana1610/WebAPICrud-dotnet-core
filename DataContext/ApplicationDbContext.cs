using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebAPICrud.Models;

namespace WebAPICrud.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<FuncionarioModel> Funcionarios {  get; set; } 

    }
}
