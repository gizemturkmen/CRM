using Microsoft.EntityFrameworkCore;
using Mobitek.CRM.Data.Context;
using System.Threading.Tasks;

namespace Mobitek.CRM.Data.UoW
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly DbContext _context;

        public UnitOfWork(CRMDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
