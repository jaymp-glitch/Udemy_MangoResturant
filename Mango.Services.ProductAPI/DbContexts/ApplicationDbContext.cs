using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext:DbContext
    {
        //DbContext is from Microsoft.EntityFrameworkCore, DbContetxts is a folder we created
        //ctor+Tab twice => to create constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
    }
}
