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
    public class MembresiaRepository : RepositoryBase<Membresia>, IMembresiaRepository
    {
        public MembresiaRepository(GimnasioAppDbContext context) : base(context)
        {
        }
    }
}
