using Application.Services;
using Domain;
using MaterialDesignThemes.Wpf;
using StepStyle.WPF.Helpers;
using StepStyle.WPF.Views;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace StepStyle.WPF.ViewModels
{
    public class GetReservationsViewModel : BaseViewModel
    {
        private readonly IReservationService _reservationService;
        private readonly UpdateReservationView _updateReservationView;


        public GetReservationsViewModel(IReservationService reservationService, UpdateReservationView updateReservationView)
        {
            _reservationService = reservationService;
            _updateReservationView = updateReservationView;


            CatamaranTypes = Enum.GetValues(typeof(CatamaranType)).Cast<CatamaranType>().ToList();

            RefreshMethod();
        }

        public List<CatamaranType> CatamaranTypes { get; set; }
        public CatamaranType? SelectedCatamaranType { get; set; }
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
        public void DeleteMethod(Reservation reservation)
        {
            _reservationService.Delete(reservation);
            RefreshMethod();

        }
        public void UpdateMethod(Reservation reservation)
        {
            ((UpdateReservationViewModel)_updateReservationView.DataContext).Reservation = reservation;
            _updateReservationView.ShowDialog();
            _updateReservationView.Close();
        }
      
        ICommand delete;
        public ICommand Delete
        {
            get
            {
                if (delete == null)
                {
                    delete = new RelayCommand((obj) =>
                    {
                        var reservation = obj as Reservation;
                        if (reservation != null)
                        {
                            DeleteMethod(reservation);
                        }
                    });
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
                    update = new RelayCommand((obj) =>
                    {
                        var reservation = obj as Reservation;
                        if (reservation != null)
                        {
                            UpdateMethod(reservation);
                        }
                    });
                }
                return update;
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