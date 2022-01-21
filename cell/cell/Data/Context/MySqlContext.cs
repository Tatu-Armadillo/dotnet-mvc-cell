
using Microsoft.EntityFrameworkCore;
using cell.Models;

namespace cell.Data.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }
        public DbSet<Cell> Cells { get; set; }

    }
}
