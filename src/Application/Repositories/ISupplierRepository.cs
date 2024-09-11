﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface ISupplierRepository
    {
        public void NewSupplier(Supplier supplier);
        public IEnumerable<Supplier> GetAllSupplier();
    }
}
