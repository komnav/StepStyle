using Application.Services;
using Domain;
using StepStyle.WPF.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace StepStyle.WPF.ViewModels
{
    public class UpdateReservationViewModel : BaseViewModel
    {
        private readonly IReservationService _reservationService;

        public UpdateReservationViewModel(IReservationService reservationService)
        {
            _reservationService = reservationService;
            CatamaranTypes = Enum.GetValues(typeof(CatamaranType)).Cast<CatamaranType>().ToList();
        }

        public List<CatamaranType> CatamaranTypes { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
        public DateTime Time { get; set; } = DateTime.Now;


        private Reservation reservation;
        public Reservation Reservation
        {
            get
            {
                return reservation;
            }
            set
            {
                reservation = value;
                Date = reservation.Date.Date;
                Time = reservation.Date;
                OnPropertyChanged(nameof(Date));
                OnPropertyChanged(nameof(Time));
                OnPropertyChanged();
            }
        }

        public void UpdateMethod()
        {
            try
            {
                Reservation.Date = new DateTime(DateOnly.FromDateTime(Date), TimeOnly.FromDateTime(Time));
                _reservationService.Update(Reservation);
                MessageBox.Show("Бронирование изменено");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        ICommand update;
        public ICommand Update
        {
            get
            {
                if (update == null)
                {
                    update = new RelayCommand((obj) => UpdateMethod());
                }

                return update;
            }
        }
    }
}

