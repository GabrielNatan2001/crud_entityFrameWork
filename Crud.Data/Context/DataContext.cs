using Crud.Data.DataConfiguration;
using Crud_Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Crud.Data.Context
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<EntidadePessoa> Pessoa { get; set; }
        public DbSet<EntidadeContato> Contato { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EntidadePessoa>(new PessoaConfiguration().Configure);
            builder.Entity<EntidadeContato>(new ContatoConfiguration().Configure);
            base.OnModelCreating(builder);
        }
    }
}
