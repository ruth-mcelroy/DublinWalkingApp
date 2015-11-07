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
        [Route("location/{order}")]
        // GET api/location/1
        public IHttpActionResult GetLocation(int order)
        {
            WalkContext locDb = new WalkContext();

            Location loc = locDb.Locations.First(l => l.Order == order);

            return Ok(loc) ;
        }
        [HttpGet]
        [Route("audio/{id}")]
        // GET api/location/1
        public IHttpActionResult GetAudio(int id)
        {
            WalkContext locDb = new WalkContext();

            Audio aud = locDb.Audios.First(l => l.AudioID == id);

            return Ok(aud);
        }




    }
}