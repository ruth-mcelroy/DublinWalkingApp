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

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}