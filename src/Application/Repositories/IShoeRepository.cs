using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IShoeRepository
    {
        public void Create(Shoe entity);
        public Shoe GetById(int id);
        public Shoe GetByDate(DateTime dateTime);
        public void Update(int id, Shoe entity);
        public void Delete(int id);
    }
}
