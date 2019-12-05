using SaipherLucas.Infra.Persistence;

namespace SaipherLucas.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SaipherLucasContext _context;

        public UnitOfWork(SaipherLucasContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
