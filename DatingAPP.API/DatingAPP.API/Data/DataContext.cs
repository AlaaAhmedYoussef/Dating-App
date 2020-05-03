using DatingAPP.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAPP.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public virtual DbSet<Value> Values { get; set; }
        public virtual DbSet<User> Users { get; set; }  
        public virtual DbSet<Xxx> Xxxes { get; set; }
    }
}
