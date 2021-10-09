using LondonApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LondonApi.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {

        private readonly HotelInfo hotelInfo;
        public InfoController(IOptions<HotelInfo> options)
        {
            hotelInfo = options.Value;
        }

        [HttpGet(Name =nameof(GetInfo))]
        public ActionResult<HotelInfo> GetInfo()
        {
            hotelInfo.Href = Url.Link(nameof(GetInfo), null);
            return (Ok(hotelInfo)); 
        }
    }
}
