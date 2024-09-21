using StepStyle.WPF.ViewModels;
using System.Windows.Controls;

namespace StepStyle.WPF.Views
{
    /// <summary>
    /// Interaction logic for UpdatReservation.xaml
    /// </summary>
    public partial class UpdatReservation : UserControl, ILeftMenuView
    {
        public UpdatReservation(UpdateReservationViewModel update)
        {
            InitializeComponent();
            DataContext = update;
        }

        public string Title => "Редактирование брони";

    }
}
