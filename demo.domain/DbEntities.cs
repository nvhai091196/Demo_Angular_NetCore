using demo.domain.Mappers.Administration;
using Microsoft.EntityFrameworkCore;

namespace demo.domain
{
    public class DbEntities : DbContext
    {
        public DbEntities(DbContextOptions<DbEntities> options) : base(options)
        {

        }

        public virtual int Commit()
        {
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            #region Administration
          modelBuilder.ApplyConfiguration(new UserMapper()); 
            #endregion
        }
    }
}
