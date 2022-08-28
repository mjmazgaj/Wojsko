using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Wojsko.Core;

namespace Wojsko.Data
{
    public class SqlTankData : DbContext
    {
        public SqlTankData(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Tank> Tanks { get; set; }
    }
}
