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
    public class CatamaranViewModel:BaseViewModel
    {
        private readonly ICatamaranService _typeOfCatamaran;
        private readonly ModelCatamarans _catamaran;

        public CatamaranViewModel(ICatamaranService typeOfCatamaran, ModelCatamarans catamaran)
        {
            _typeOfCatamaran = typeOfCatamaran;
            _catamaran = catamaran;
        }
        CatamaranModel catamaranModel { get; set; }

        public void Catamaran()
        {
            var catamaranExists = _typeOfCatamaran.Create(catamaranModel);
            if (catamaranExists)
            {
                _catamaran.Activate();
                Close();
            }
            else
            {
                MessageBox.Show("Неправильный ввод");
            }
        }

        ICommand catamaranCommand;
        public ICommand LoginCommand
        {
            get
            {
                if (catamaranCommand == null)
                {
                    catamaranCommand = new RelayCommand((obj) => Catamaran());
                }

                return catamaranCommand;
            }
        }
    }
}
