using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*
            optionsBuilder.UseSqlServer(
                "Server =aspnetcore5-blogsite.database.windows.net;" +
                "database=CoreBlogApiDb;" +
                "User ID=serkanadmin;" +
                "Password=Azureserkan_006;");
            */
            optionsBuilder.UseSqlServer(
               "Server =.;" +
               "database=CoreBlogApiDb;" +
               "Integrated Security=True;");
        }
        public DbSet<Employee> Employees { get; set; }


    }
}
