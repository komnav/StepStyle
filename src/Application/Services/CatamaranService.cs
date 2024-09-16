using Application.Repositories;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CatamaranService : ICatamaranService
    {
        private readonly ITypeOfCatamaranRepository _typeOfCatamaran;
        public CatamaranService(ITypeOfCatamaranRepository typeOfCatamaran)
        {
            _typeOfCatamaran = typeOfCatamaran;
        }

        public bool Create(CatamaranModel catamaranModel)
        {
            try
            {
                _typeOfCatamaran.Create(catamaranModel);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
