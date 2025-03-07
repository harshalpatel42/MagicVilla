﻿using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>

    {
        #region Update for VillaNumber
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
        #endregion
    }
}
