using MagicVilla_VillaAPI.Model;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaRepository
    {
        Task<List<Villa>> GetAll(Expression<Func<Villa>> filter = null);
        Task<Villa> Get(Expression<Func<Villa>> filter = null,bool tracked = true);
        Task Create(Villa villa);
        Task Remove(Villa villa);
        Task Save();
    }
}
