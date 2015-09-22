using CommU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CommU.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class VehiclesController : ApiController
    {
        [HttpGet]
        public IEnumerable<Vehicle> Get()
        {
            return new Vehicle[]
            {
                new Vehicle { Id = 1, Description = "redish", Owner = "some old broad", IsAwesome = true },
                new Vehicle { Id = 2, Description = "rusty af", Owner = "dirty mike (and the boys)", IsAwesome = false},
                new Vehicle { Id = 3, Description = "bronze benz", Owner = "David", IsAwesome = true }
            };
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] Vehicle vehicle)
        {
            return Request.CreateResponse(HttpStatusCode.Accepted);
        }

    }
}
