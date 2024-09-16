using Application.Repositories;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TypeOfCatamaranRepository : ITypeOfCatamaranRepository
    {
        private readonly ShoeDbContext _context;
        public TypeOfCatamaranRepository(ShoeDbContext context)
        {
            _context = context;
        }

        public void Create(CatamaranModel catamaranModel)
        {
            _context.Add(catamaranModel);
            _context.SaveChanges();
        }
    }
}
