using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDBContext _db;


        // VillaRepository inherits Repository<T> T = Villa here so it needs to send db to its base class so that
        // Repository knows what db is being worked with to know what it should pass to base methods
        public VillaRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }

         public async Task<Villa> UpdateAsync(Villa entity)
         {
            entity.UpdateDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
         }
    }
}
