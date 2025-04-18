﻿using MagicVilla_VillaAPI.Controllers;
using MagicVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        //Task<List<Villa>> GetAllAsync(Expression<Func<Villa,bool>> filter = null);
        //Task<Villa> GetAsync(Expression<Func<Villa,bool>> filter = null,bool tracked = true);
        //Task CreateAsync(Villa villa);
        //Task RemoveAsync(Villa villa);
        Task<Villa> UpdateAsync(Villa villa);
        //Task SaveAsync();
    }
}
