using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IReservationService
    {
        public void Create(Reservation reservation);
        public void Update(Reservation reservation);
        public void Delete(int id);
        public List<Reservation> GetAll(CatamaranType catamaranType);

    }
}
