using Application.Services;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MigrationService : IMigrationService
    {
        private readonly ShoeDbContext _shoeDbContext;
        public MigrationService(ShoeDbContext shoeDbContext)
        {
            _shoeDbContext = shoeDbContext;
        }

        public void CreateDefaultData()
        {
            if (!_shoeDbContext.Users.Any())
            {
                _shoeDbContext.Add(new User
                {
                    UserName = "admin",
                    Password = "admin"
                });
                _shoeDbContext.SaveChanges();
            }
        }

        public void Migrate()
        {
            _shoeDbContext.Database.Migrate();
        }
    }
}
