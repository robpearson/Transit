using System.Collections.Generic;
using System.Web.Http;

namespace MaplePixel.Transit.Controllers
{
    public class TransitRouteController : ApiController
    {
        // GET: api/TransitRoute
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TransitRoute/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TransitRoute
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TransitRoute/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TransitRoute/5
        public void Delete(int id)
        {
        }
    }
}
