using demo.domain;
namespace demo.domain
{
    public interface IUnitOfWork
    {
        bool Commit();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private DbEntities dbContext;

        public UnitOfWork(DbEntities dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool Commit()
        {
            return dbContext.Commit() > 0;
        }
    }
}
