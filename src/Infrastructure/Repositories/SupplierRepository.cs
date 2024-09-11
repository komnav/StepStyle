using Application.Repositories;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly ShoeDbContext _context;
        public SupplierRepository(ShoeDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Supplier> GetAllSupplier()
        {
            return _context.Suppliers.ToList();
        }

        public void NewSupplier(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }
    }
}
