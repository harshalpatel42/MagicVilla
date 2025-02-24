﻿using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Model;
using MagicVilla_VillaAPI.Model.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    // [Route("api/[controller]")]
    [Route("api/VillaAPI")] 
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet] // Retrieving the Entire VillaList from DTO

        /*
         * [ProducesResponseType(200)]
         * [ProducesResponseType(400)]
         * [ProducesResponseType(404)]
         */

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VillaDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas ()
        {
            return Ok(VillaStore.villaList);
        }

        [HttpGet("id")] // Retrieving the Villa with particular ID
        [ProducesResponseType(StatusCodes.Status200OK , Type = typeof(VillaDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if(id < 0 || id == 0)
            {
                return BadRequest();
            }

            VillaDTO? VillaDetails = VillaStore.villaList.FirstOrDefault(x => x.Id == id);

            if(VillaDetails == null)
            {
                return NotFound();
            }
            return Ok(VillaDetails);
        }
    }
}
