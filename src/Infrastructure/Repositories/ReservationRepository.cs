using Application.Repositories;
using Domain;

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

        public void Delete(Reservation reservation)
        {
            _context.Reservations.Remove(reservation);
            _context.SaveChanges();
        }

        public List<Reservation> GetAll(CatamaranType? catamaran)
        {
           

            return _context.Reservations
                .Where(x => x.TypeOfCatamaran == catamaran)
                .ToList();
        }

        public void Update(Reservation reservation)
        {
            _context.Update(reservation);
            _context.SaveChanges();
        }
    }
}
