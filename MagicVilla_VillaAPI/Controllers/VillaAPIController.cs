using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetAllVillas() 
        {
            return VillaStore.VillaList;
        }

        [HttpGet("{id:int}")] 
        public VillaDTO GetAllVilla(int id)
        {
            return VillaStore.VillaList.FirstOrDefault(u => u.Id == id);
        }
    }
}
