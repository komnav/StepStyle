using Application.Repositories;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository reservationRepository;
        public ReservationService(IReservationRepository reservationRepository)
        {
            this.reservationRepository = reservationRepository;
        }

        public void Create(Reservation reservation)
        {
            reservationRepository.Create(reservation);
        }

        public void Delete(Reservation reservation)
        {
            reservationRepository.Delete(reservation);
        }

        public List<Reservation> GetAll(CatamaranType? catamaran)
        {
            return reservationRepository.GetAll(catamaran);
        }

        public void Update(Reservation reservation)
        {
            reservationRepository.Update(reservation);
        }
    }
}
