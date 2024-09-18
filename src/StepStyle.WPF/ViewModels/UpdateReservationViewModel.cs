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
    public class UpdateReservation : BaseViewModel
    {
        private readonly IReservationService _reservationService;
        public UpdateReservation(IReservationService reservationService)
        {
            _reservationService = reservationService;
            CatamaranTypes = Enum.GetValues(typeof(CatamaranType)).Cast<CatamaranType>().ToList();
        }
        public DateTime Date { get; set; } = DateTime.Now;
        public DateTime Time { get; set; } = DateTime.Now;
        public int Id { get; set; }
        public CatamaranType Catamaran { get; set; }
        public string ClientName { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public List<CatamaranType> CatamaranTypes { get; set; }

        public void UpdateMethod()
        {
            try
            {
                Reservation reservation = new Reservation();
                reservation.Id = Id;
                reservation.ClientName = ClientName;
                reservation.PhoneNumber = PhoneNumber;
                reservation.PassportSeries = PassportSeries;
                reservation.PassportNumber = PassportNumber;
                reservation.Date = new DateTime(DateOnly.FromDateTime(Date), TimeOnly.FromDateTime(Time));
                reservation.TypeOfCatamaran = Catamaran;
                _reservationService.Update(reservation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteMethod()
        {
            try
            {
                _reservationService.Delete(Id);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Could not delete {ex}");
            }
        }
        ICommand delete;
        public ICommand DeleteCommand
        {
            get
            {
                if (delete == null)
                {
                    update = new RelayCommand((obj) => DeleteMethod());
                }
                return delete;
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

