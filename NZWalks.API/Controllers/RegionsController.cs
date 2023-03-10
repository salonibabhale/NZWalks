using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repository;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private object mapper;

        public RegionsController(IRegionRepository regionRepository IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        public object Code { get; private set; }
        public object Name { get; private set; }
        public object Area { get; private set; }
        public object Lat { get; private set; }
        public object Long { get; private set; }
        public object Population { get; private set; }

        [HttpGet]
        public async Task<IActionResult> GetAllRegionsAsync()

        {
            var regions = await regionRepository.GetAllasync();

            //return DTO regions
            //var regionsDTO = new List<Models.DTO.Region>();
            //region.ToList().ForEach(region =>)
            //{
            //  var regionDTO = new Models.DTO.Region();
            //{
            //  Id = region.Id;
            //Code = region.Code;
            //Name = region.Name;
            //Area = region.Area;
            //Lat = region.Lat;
            //Long = region.Long;
            //Population = region.Population;

            //}

            //};
            var regionsDTO = mapper.Map<List<Models.DTO.Region>>(regions);

            return Ok(regionsDTO);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetRegionAsync(Guid id)
        {
            var region = await regionRepository.GetAsync(id);

            if (region == null)
            {
                return NotFound();
            }
            var regionDTO = mapper.Map<Models.DTO.Region>(region);

            return Ok(regionDTO);
        }

        [HttpPost]
        public async Task<IActionResult> AddRegionAsync(Models.DTO.AddRegionRequest AddRegionRequest);
        {
         //Request(DTO) to Domain model
         var region = new Models.Domain.Region()
         {

         }

         //pass detail to Repository 

        //Convert back to DTO
        }
    }
}
