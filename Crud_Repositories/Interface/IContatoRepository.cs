using Crud_Domain.Entity;
using Crud_Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Repositories.Interface
{
    public interface IContatoRepository : IBaseRepository <EntidadeContato>
    {
        Task<EntidadePessoa> GetPessoa(int id);
    }
}
