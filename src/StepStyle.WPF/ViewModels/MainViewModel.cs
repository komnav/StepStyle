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
        public IEnumerable<ILeftMenuView> AllLeftMenuViews { get; }
        public MainViewModel(IEnumerable<ILeftMenuView> allLeftMenuViews)
        {
            AllLeftMenuViews = allLeftMenuViews;
        }

        ILeftMenuView selectedOption;
        public ILeftMenuView SelectedOption
        {
            get
            {
                return selectedOption;
            }
            set
            {
                selectedOption = value;
                OnPropertyChanged();
            }
        }
    }
}
