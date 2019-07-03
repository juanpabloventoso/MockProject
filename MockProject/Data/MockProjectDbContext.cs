using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MockProject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace MockProject.Data
{

    public interface IMockProjectDbContext
    {
        DbSet<User> Users { get; set; }
    }

    public class MockProjectDbContext : DbContext, IMockProjectDbContext
    {

        public MockProjectDbContext(DbContextOptions<MockProjectDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }

    }
}