using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
        }

        public object Code { get; private set; }
        public object Name { get; private set; }
        public object Area { get; private set; }
        public object Lat { get; private set; }
        public object Long { get; private set; }
        public object Population { get; private set; }

        [HttpGet]
        public IActionResult GetAllRegions()
        {
            var regions = regionRepository.Getall();

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
    }
}
