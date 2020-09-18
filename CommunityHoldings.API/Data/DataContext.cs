using Microsoft.EntityFrameworkCore;
using CommunityHoldings.API.DataModels;

namespace CommunityHoldings.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<User> Users { get; set; }
    }
}