using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NZWalks.API.Models.Domain;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

     

        [HttpGet]
        public IActionResult GetAllRegions()
        {
            var regions = regionRepository.GetAll;

            //return DTO region 
            //var regionsDTO = new List<Models.DTO.Region>();
            //regions.ToList().ForEach(Region => 

            //{
            //  var regionDTO = new Models.DTO.Region() 
            //{
            //  Id = Region.Id,
            //Code = Region.Code,
            //Name = Region.Name,
            //Area= Region.Area,
            //Lat= Region.Lat,
            //Long= Region.Long,
            //Population = Region.Population,
            //};
            //regionsDTO.Add(regionDTO);
            //});

            var regionsDTO = mapper.Map<List<Models.DTO.Region>>(regions);

            return Ok(regions);
        }
    }
}
