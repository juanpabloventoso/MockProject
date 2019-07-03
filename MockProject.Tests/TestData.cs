using System;
using System.Collections.Generic;
using System.Linq;
using MockProject.Model;

namespace MockProject.Tests
{

    public static class TestData
    {

        // Test data for the DbSet<User> getter
        public static IQueryable<User> Users
        {
            get
            {
                return new List<User>
                {
                    new User { ID = 1, Username = "admin", Email = "admin@host.com" },
                    new User { ID = 2, Username = "guest", Email = "guest@host.com" }
                }
                .AsQueryable();
            }
        }
    }

}