﻿using GimnasioApp.DataAccess.Data;
using GimnasioApp.Entities;
using GimnasioApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioApp.Repositories.Implementaciones
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        private readonly GimnasioAppDbContext Context;

        protected RepositoryBase(GimnasioAppDbContext context)
        {
            Context = context;
        }

        public async Task<ICollection<TEntity>> ListAsync()

        {
            return await Context.Set<TEntity>()
                .Where(x => x.Estado)
               .AsNoTracking()
               .ToListAsync();
        }
        public async Task<ICollection<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Context.Set<TEntity>()
                .Where(predicate)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<TEntity?> FindAsync(int id)
        {
            return await Context.Set<TEntity>().FindAsync(id);
                
        }
        public async Task AddAsync(TEntity entity)
        {
            await Context.Set<TEntity>().AddAsync(entity);
            await Context.SaveChangesAsync();
           
        }
        public async Task UpdateAsync()
        {
            await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var registro = await FindAsync(id);
            if (registro != null)
            {
                registro.Estado = false;
                await UpdateAsync();
            }
        }

        

       

       
       
    }
}
