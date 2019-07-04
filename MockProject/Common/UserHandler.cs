using MockProject.Data;
using MockProject.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MockProject.Common
{

    public class UserHandler
    {

        private IMockProjectDbContext _DbContext;

        public UserHandler(IMockProjectDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public async Task<int?> GetUserIDByEmail(string Email)
        {
            var User = await _DbContext.Users.Where(x => x.Email.Equals(Email)).FirstOrDefaultAsync();
            if (User != null)
                return User.ID;
            return null;
        }

    }
}
