using HelloWorld.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HelloWorld.Data
{
    public class DutchContext : DbContext
    {
         public DbSet<Product> Products {set; get;}
         public DbSet<Order> Orders {set; get;}
    }
}