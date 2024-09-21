using Application.Repositories;
using Application.Services;
using Domain;
using StepStyle.WPF.Helpers;
using StepStyle.WPF.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            CatamaranTypes = Enum.GetValues(typeof(CatamaranType)).Cast<CatamaranType>().ToList();
        }
        private DateTime date = DateTime.Now;
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                OnPropertyChanged();
            }
        }
        private DateTime time = DateTime.Now;
        public DateTime Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
                OnPropertyChanged();
            }
        }

        private CatamaranType? catamaran;
        public CatamaranType? Catamaran
        {
            get
            {
                return catamaran;
            }
            set
            {
                catamaran = value;
                OnPropertyChanged();
            }
        }
        private string clientName;
        public string ClientName
        {
            get
            {
                return clientName;
            }
            set
            {
                clientName = value;
                OnPropertyChanged();
            }
        }
        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
                OnPropertyChanged();
            }
        }
        private string passportSeries;
        public string PassportSeries
        {
            get
            {
                return passportSeries;
            }
            set
            {
                passportSeries = value;
                OnPropertyChanged();
            }
        }
        private string passportNumber;
        public string PassportNumber
        {
            get
            {
                return passportSeries;
            }
            set
            {
                passportSeries = value;
                OnPropertyChanged();
            }
        }

        public List<CatamaranType> CatamaranTypes { get; set; }

        public void SaveMethod()
        {
            try
            {
                Reservation reservation = new Reservation();
                reservation.ClientName = ClientName;
                reservation.PhoneNumber = PhoneNumber;
                reservation.PassportSeries = PassportSeries;
                reservation.PassportNumber = PassportNumber;
                reservation.Date = new DateTime(DateOnly.FromDateTime(Date), TimeOnly.FromDateTime(Time));
                reservation.TypeOfCatamaran = Catamaran;
                _typeOfCatamaran.Create(reservation);
                MessageBox.Show("Катамаран забронироватнь");
                ClearMethod();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ClearMethod()
        {
            Catamaran = null;
            ClientName = string.Empty;
            PhoneNumber = string.Empty;
            PassportNumber = string.Empty;
            PassportSeries = string.Empty;
            Date = DateTime.Now;
            Time = DateTime.Now;
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
