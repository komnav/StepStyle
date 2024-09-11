using Application.Repositories;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ShoeDbContext _context;

        public User? GetUser(string userName, string password)
        {
            var pass = _context.Users.FirstOrDefault(x => x.UserName == userName && x.Password == password);
            return pass;
        }
    }
}
