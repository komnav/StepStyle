using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public CatamaranType? TypeOfCatamaran { get; set; }
        public string ClientName { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
    }
}
