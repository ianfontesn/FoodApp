using FoodApp.Menu.Context;

namespace FoodApp.Menu.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnityOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            _context.Dispose();
        }
    }
}
