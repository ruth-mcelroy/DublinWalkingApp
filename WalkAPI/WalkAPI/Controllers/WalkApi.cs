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
    public class WalkingAppAPI : ApiController
    {
        [HttpGet]
        [Route("walks")]
        // GET api/walks
        public IEnumerable<Walk> GetWalks()
        {
            WalkContext walkDb = new WalkContext();

            IEnumerable<Walk> walklist = walkDb.Walks.Where(w => w.Name != null);

            return walklist;
        }

        [HttpGet]
        [Route("walk/{walk}/location/{order}")]
        public Location GetLocation( int walk, int order)
        {
            WalkContext locDb = new WalkContext();

            Location loc = locDb.Locations.Where(l => l.WalkInfo.WalkID == walk || l.WalkInfo.WalkID == null) 
                                          .First(l => l.Order == order);

            return loc ;
        }




    }
}