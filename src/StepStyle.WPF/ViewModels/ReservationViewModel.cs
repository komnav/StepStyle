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

        public void SaveMethod()
        {

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
