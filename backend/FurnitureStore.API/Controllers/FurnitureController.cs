using AutoMapper;
using FurnitureStore.BusinessLayer.Services.Interface;
using FurnitureStore.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static FurnitureStore.Data.DTOs.FurnitureDto;

namespace FurnitureStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FurnitureController : ControllerBase
    {
        private readonly IFurnitureService _furnitureService;
        private IMapper _mapper;

        public FurnitureController(IFurnitureService furnitureService, IMapper mapper)
        {
            _mapper = mapper;
            _furnitureService = furnitureService;
        }

        [HttpGet("AllFurniture")]
        public async Task<ActionResult<FurnitureGetDto>> GetAllFurnitures()
        {
            var furnitures = await _furnitureService.GetAllFurnitures();
            var mapperFurnitures = _mapper.Map<List<FurnitureGetDto>>(furnitures);
            return Ok(mapperFurnitures);
        }

        [HttpGet("SearchFurnitureByName")]
        public async Task<ActionResult<FurnitureGetDto>> GetFurnitureByName([FromQuery] string name)
        {
            var furnitures = await _furnitureService.GetFurnitureByName(name);
            var mapperFurnitures = _mapper.Map<List<FurnitureGetDto>>(furnitures);
            return Ok(mapperFurnitures);
        }
    }
}
