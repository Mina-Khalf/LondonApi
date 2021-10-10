using LondonApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LondonApi.Controllers
{
    [Route("/")]
    [ApiController]
    public class RootController : ControllerBase
    {
        [HttpGet(Name =nameof(GetRoots))]
        public  IActionResult GetRoots()
        {
            var reponse = new RootResponse()
            {
                Self = Link.To(nameof(GetRoots)),
                Rooms = Link.To(nameof(RoomsController.GetRooms)),
                Info = Link.To(nameof(InfoController.GetInfo))
            };
            return Ok(reponse);
        }
    }
}
