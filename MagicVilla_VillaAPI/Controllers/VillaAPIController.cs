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
        [HttpGet] // GET End Point
        public IEnumerable<VillaDTO> GetVillas ()
        {
            return VillaStore.villaList;
        }
    }
}
