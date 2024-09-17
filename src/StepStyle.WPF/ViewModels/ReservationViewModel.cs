using Application.Repositories;
using Application.Services;
using Domain;
using StepStyle.WPF.Helpers;
using StepStyle.WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace StepStyle.WPF.ViewModels
{
    public class ReservationViewModel : BaseViewModel
    {
        private readonly IReservationService _typeOfCatamaran;

        public ReservationViewModel(IReservationService reservationService)
        {
            _typeOfCatamaran = reservationService;
        }

        public DateTime Date { get; set; } = DateTime.Now;
        public int Id { get; set; }
        public CatamaranType Catamaran { get; set; }
        public string ClientName { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public void SaveMethod()
        {
            Reservation reservation = new Reservation();
            reservation.Id = Id;
            reservation.ClientName = ClientName;
            reservation.PhoneNumber = PhoneNumber;
            reservation.PassportSeries = PassportSeries;
            reservation.PassportNumber = PassportNumber;
            reservation.Date = Date;
            reservation.TypeOfCatamaran = Catamaran;
            _typeOfCatamaran.Create(reservation);
        }

        ICommand save;
        public ICommand Save
        {
            get
            {
                if (save == null)
                {
                    save = new RelayCommand((obj) => SaveMethod());
                }

                return save;
            }
        }
    }
}
