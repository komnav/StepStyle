using StepStyle.WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepStyle.WPF.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly ReservationView _reservationView;
        public MainViewModel(ReservationView reservationView)
        {
            _reservationView = reservationView;
        }

        int selectedOption=1;
        public int SelectedOption
        {
            get
            {
                return selectedOption;
            }
            set
            {
                selectedOption = value;
                if (selectedOption ==0)
                {
                    _reservationView.ShowDialog();
                }
            }
        }
    }
}
