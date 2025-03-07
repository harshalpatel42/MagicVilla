using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web.Services.IServices
{
    public interface IVillaService
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int Id);
        Task<T> CreateVillaAsync<T>(VillaCreateDTO dto);
        Task<T> UpdateVillaAsync<T>(VillaUpdateDTO dto);
        Task<T> DeleteVillaAsync<T>(int Id);
    }
}
