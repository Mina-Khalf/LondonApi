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
            var reponse = new
            {
                href = Url.Link(nameof(GetRoots), null),
                Rooms = new
                {
                    href=Url.Link(nameof(RoomsController.GetRooms),null)
                },
                info = new
                {
                    href= Url.Link(nameof(InfoController.GetInfo), null)
                }
            };
            return Ok(reponse);
        }
    }
}
