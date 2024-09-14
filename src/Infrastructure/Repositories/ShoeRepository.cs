using Application.Repositories;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    //public class ShoeRepository : IShoeRepository
    //{
    //    private readonly ShoeDbContext _context;
    //    public void Create(Shoe entity)
    //    {
    //        _context.Shoes.Add(entity);
    //        _context.SaveChanges();
    //    }

    //    public void Delete(int id)
    //    {
    //        var deleteShoe = _context.Shoes.Where(x => x.Id == id);
    //        deleteShoe.ExecuteDelete();
    //        _context.SaveChanges();
    //    }

    //    public Shoe GetById(int id) => _context.Shoes.AsNoTracking().Single(x => x.Id == id);

    //    public Shoe GetByDate(DateTime dateTime) => _context.Shoes.AsNoTracking().Single(x => x.DateTime == dateTime);


    //    public void Update(int id, Shoe entity)
    //    {
    //        Shoe shoeUpdate = _context.Shoes.Single(x => x.Id == id);

    //        shoeUpdate.Name = entity.Name;
    //        shoeUpdate.Id = entity.Id;
    //        shoeUpdate.Price = entity.Price;
    //        shoeUpdate.Size = entity.Size;
    //        shoeUpdate.Quantity = entity.Quantity;
    //        shoeUpdate.DateTime = entity.DateTime;
    //        _context.SaveChanges();
    //    }
    //}
}
