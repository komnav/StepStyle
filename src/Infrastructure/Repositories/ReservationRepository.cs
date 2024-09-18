using Application.Repositories;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly ShoeDbContext _context;
        public ReservationRepository(ShoeDbContext context)
        {
            _context = context;
        }

        public void Create(Reservation reservation)
        {
            _context.Add(reservation);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }

        public void Update(Reservation reservation)
        {
            _context.Update(reservation);
            _context.SaveChanges();
        }
    }
}
