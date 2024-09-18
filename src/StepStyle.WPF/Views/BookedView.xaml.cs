using StepStyle.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StepStyle.WPF.Views
{
    /// <summary>
    /// Interaction logic for BookedView.xaml
    /// </summary>
    public partial class BookedView : UserControl, ILeftMenuView
    {
        public BookedView(GetReservationsViewModel get)
        {
            InitializeComponent();
            DataContext = get;
        }

        public string Title => "Просмотрь забронированного";

        private void BookingsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
