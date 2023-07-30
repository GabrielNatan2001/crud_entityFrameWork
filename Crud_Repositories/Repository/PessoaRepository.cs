using Crud.Data.Context;
using Crud_Domain.Entity;
using Crud_Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Crud_Repositories.Repository
{
    public class PessoaRepository : BaseRepository<EntidadePessoa>, IPessoaRepository
    {
        private readonly DataContext _dataContext;
        public PessoaRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<EntidadePessoa> GetById(int id)
        {
            return await _dataContext.Pessoa.Include(x => x.Contatos).FirstAsync();
        }

        public async Task<IEnumerable<EntidadePessoa>> GetAll()
        {
            return await _dataContext.Pessoa.Include(x => x.Contatos).ToListAsync();
        }
    }
}
