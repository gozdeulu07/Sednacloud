using Microsoft.EntityFrameworkCore;
using SednaReservationAPI.Application.Repositories;
using SednaReservationAPI.Domain.Entities.Common;
using SednaReservationAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntitity
    {
        private readonly SednaReservationAPIDbContext _context;

        public ReadRepository(SednaReservationAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table;
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
            => Table.Where(method);
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
            => await Table.FirstOrDefaultAsync(method);

        public async Task<T> GetByIdAsync(string id)
            => await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
    }
}
