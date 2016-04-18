using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CloudBackend.Controllers
{
    public class BaseStationController : ApiController
    {
        // GET: api/BaseStation
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/BaseStation/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BaseStation
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/BaseStation/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BaseStation/5
        public void Delete(int id)
        {
        }
    }
}
