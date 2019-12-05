namespace SaipherLucas.Infra.Transactions
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
