using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Mango.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        //DbContext is from Microsoft.EntityFrameworkCore, DbContetxts is a folder we created
        //ctor+Tab twice => to create constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products {get;set;}
    }
}
