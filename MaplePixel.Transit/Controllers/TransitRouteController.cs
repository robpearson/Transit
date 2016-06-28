using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using MaplePixel.Transit.Models;

namespace MaplePixel.Transit.Controllers
{
    public class TransitRouteController : ApiController
    {
        private readonly List<TransitRoute> transitRoutes = new List<TransitRoute>();

        public TransitRouteController()
        {
            // Test Data
            var route1 = new TransitRoute {Id = 1, LongName = "Caboolture Line", ShortName = "CAB"};
            var route2 = new TransitRoute {Id = 2, LongName = "Ipswitch Line", ShortName = "IPS"};
            var route3 = new TransitRoute {Id = 3, LongName = "Ferny Grove Line", ShortName = "FER"};
            transitRoutes.Add(route1);
            transitRoutes.Add(route2);
            transitRoutes.Add(route3);
        }

        // GET: api/TransitRoute
        public IEnumerable<TransitRoute> Get()
        {
            return transitRoutes;
        }

        // GET: api/TransitRoute/5
        public TransitRoute Get(int id)
        {
            return transitRoutes.FirstOrDefault(r => r.Id == id);
        }

        // POST: api/TransitRoute
        public void Post([FromBody]string value)
        {
            // TODO: Add support to create a new transit route
        }

        // PUT: api/TransitRoute/5
        public void Put(int id, [FromBody]string value)
        {
            // TODO: Add support to update a new transit route
        }

        // DELETE: api/TransitRoute/5
        public void Delete(int id)
        {
            // TODO: Add support to delete a new transit route
        }
    }
}
