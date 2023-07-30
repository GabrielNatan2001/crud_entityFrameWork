using Crud.Data.Context;
using Crud_Domain.Entity;
using Crud_Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Repositories.Repository
{
    public class ContatoRepository : BaseRepository<EntidadeContato>, IContatoRepository
    {
        private readonly DataContext _dataContext;
        public ContatoRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<EntidadePessoa> GetPessoa(int id)
        {
            return await _dataContext.Set<EntidadePessoa>().FindAsync(id);
        }
    }
}
