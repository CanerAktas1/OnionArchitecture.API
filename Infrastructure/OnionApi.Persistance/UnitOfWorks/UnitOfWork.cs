using OnionApi.Application.Interfaces.Repositories;
using OnionApi.Application.Interfaces.UnitOfWorks;
using OnionApi.Persistance.Context;
using OnionApi.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApi.Persistance.UnitOfWorks
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;

        public UnitOfWork(AppDbContext context)
        {
            this.context = context;
        }
        public async ValueTask DisposeAsync() => await context.DisposeAsync();

        public int Save() => context.SaveChanges();

        public async Task<int> SaveAsync() => await context.SaveChangesAsync();

        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(context);

        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>()=> new WriteRepository<T>(context);
    }
}
