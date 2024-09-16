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
        private readonly IReservationRepository _typeOfCatamaran;
        public ReservationService(IReservationRepository typeOfCatamaran)
        {
            _typeOfCatamaran = typeOfCatamaran;
        }

        public void Create(Reservation reservation)
        {
            _typeOfCatamaran.Create(reservation);
        }
    }
}
