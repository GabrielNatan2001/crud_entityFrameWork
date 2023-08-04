using Crud.Data.Context;
using Crud_Domain.Entity;
using Crud_Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Repositories.Repository
{
    public class UsuarioRepository : BaseRepository<EntidadeUsuario>, IUsuarioRepository
    {
        private readonly DataContext _dataContext;
        public UsuarioRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<EntidadeUsuario> Authenticate(EntidadeUsuario user)
        {
            return await _dataContext.Usuario.Where(x => x.Usuario == user.Usuario && x.Senha == user.Senha).FirstAsync();
        }
    }
}
