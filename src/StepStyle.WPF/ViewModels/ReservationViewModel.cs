﻿using Application.Repositories;
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
        public void SaveMethod()
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
                _typeOfCatamaran.Create(reservation);
                MessageBox.Show("Катамаран забронироватнь");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
