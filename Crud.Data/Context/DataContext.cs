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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EntidadePessoa>(new PessoaConfiguration().Configure);
            base.OnModelCreating(builder);
        }
    }
}
