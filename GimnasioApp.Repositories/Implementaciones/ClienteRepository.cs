using GimnasioApp.DataAccess.Data;
using GimnasioApp.Entities;
using GimnasioApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioApp.Repositories.Implementaciones
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(GimnasioAppDbContext context) : base(context)
        {
        }
    }
}
