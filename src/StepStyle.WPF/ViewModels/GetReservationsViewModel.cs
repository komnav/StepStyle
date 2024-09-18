using Application.Services;
using Domain;
using StepStyle.WPF.Helpers;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace StepStyle.WPF.ViewModels
{
    public class GetReservationsViewModel : BaseViewModel
    {
        private readonly IReservationService _reservationService;


        public GetReservationsViewModel(IReservationService reservationService)
        {
            _reservationService = reservationService;
            CatamaranTypes = Enum.GetValues(typeof(CatamaranType)).Cast<CatamaranType>().ToList();
            RefreshMethod();
        }

        public List<CatamaranType> CatamaranTypes { get; set; }
        public CatamaranType SelectedCatamaranType { get; set; }
        public ObservableCollection<Reservation> AllReservations { get; set; } = [];
        public void RefreshMethod()
        {
            AllReservations.Clear();
            var allReservation = _reservationService.GetAll(SelectedCatamaranType);
            foreach (var reservation in allReservation)
            {
                AllReservations.Add(reservation);
            }

        }
        ICommand refresh;
        public ICommand Refresh
        {
            get
            {
                if (refresh == null)
                {
                    refresh = new RelayCommand((obj) => RefreshMethod());
                }

                return refresh;
            }
        }
    }

}