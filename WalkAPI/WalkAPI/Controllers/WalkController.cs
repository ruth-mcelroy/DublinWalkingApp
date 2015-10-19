using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WalkAPI.Models;

namespace WalkAPI.Controllers
{
    [RoutePrefix("api")]
    public class WalkController : ApiController
    {
        [HttpGet]
        [Route("walks")]
        // GET api/walks
        public IHttpActionResult GetWalks()
        {
            WalkContext walkDb = new WalkContext();

            IEnumerable<Walk> walklist = walkDb.Walks.Where(w => w.Name != null);

            return Ok(walklist);
        }

        [HttpGet]
        [Route("location/{id}")]
        // GET api/location/1
        public IHttpActionResult GetLocation(int id)
        {
            WalkContext locDb = new WalkContext();

            Location loc = locDb.Locations.Where(l => l.WalkInfo.WalkID == 1 || l.WalkInfo.WalkID == null) 
                                          .First(l => l.Order == id);

            return Ok(loc) ;
        }




    }
}