using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Model;
using MagicVilla_VillaAPI.Model.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillaAPI")] 
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet] // Retrieving the Entire VillaList from DTO
        public IEnumerable<VillaDTO> GetVillas ()
        {
            return VillaStore.villaList;
        }

        [HttpGet("id")] // Retrieving the Villa with particular ID
        public VillaDTO GetVilla(int id)
        {
            return VillaStore.villaList.FirstOrDefault(x => x.Id == id);
        }
    }
}
