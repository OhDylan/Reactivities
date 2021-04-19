using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        // The name of this property is going to map to table name in db, e.g. Activities
        public DbSet<Activity> Activities { get; set; }
    }
}
