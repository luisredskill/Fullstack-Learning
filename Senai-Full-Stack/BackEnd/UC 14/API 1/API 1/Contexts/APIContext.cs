using API_1.Models;
using Microsoft.EntityFrameworkCore;

namespace API_1.Contexts
{
    public class APIContext : DbContext
    {

        public APIContext()
        {
        }
        public APIContext(DbContextOptions<APIContext> options) : base(options)
        {
        }
        // vamos utilizar esse método para configurar o banco de dados
        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                // cada provedor tem sua sintaxe para especificação
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-PRA0PSD\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Livros> Livro { get; set; }
    }
}


