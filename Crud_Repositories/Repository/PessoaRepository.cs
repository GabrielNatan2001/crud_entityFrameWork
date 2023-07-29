using Crud.Data.Context;
using Crud_Domain.Entity;
using Crud_Repositories.Interface;

namespace Crud_Repositories.Repository
{
    public class PessoaRepository : BaseRepository<EntidadePessoa>, IPessoaRepository
    {
        public PessoaRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
