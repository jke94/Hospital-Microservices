namespace Entities.Context
{
    using Microsoft.EntityFrameworkCore;

    public class SQLServerRepositoryContext : RepositoryContext
    {
        public SQLServerRepositoryContext()
        {

        }

        public SQLServerRepositoryContext(DbContextOptions<SQLServerRepositoryContext> options)
            : base (options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Initial Catalog=RepositoryPatternDB;Trusted_Connection=True;");
        //}
    }
}
