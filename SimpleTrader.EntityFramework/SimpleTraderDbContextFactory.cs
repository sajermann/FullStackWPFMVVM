using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrader.EntityFramework
{
    public class SimpleTraderDbContextFactory : IDesignTimeDbContextFactory<SimpleTraderDbContext>
    {
        public SimpleTraderDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<SimpleTraderDbContext>();
            options.UseSqlServer("Data Source=localhost; Database=SimpleTraderDB; Uid=sa; Pwd=Bruno123456%;", b => b.MigrationsAssembly("SimpleTrader.EntityFramework"));

            return new SimpleTraderDbContext(options.Options);
        }
    }
}
