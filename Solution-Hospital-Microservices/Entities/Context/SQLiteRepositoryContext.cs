namespace Entities.Context
{
    using Microsoft.EntityFrameworkCore;

    public class SQLiteRepositoryContext : RepositoryContext
    {
        public SQLiteRepositoryContext()
        {

        }

        public SQLiteRepositoryContext(DbContextOptions<SQLiteRepositoryContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Data Source = RepositoryPatternDB.db;");
        //}
    }
}
