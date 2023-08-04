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
        public ContatoRepository(DataContext dataContext) : base(dataContext)
        {
            
        }
    }
}
