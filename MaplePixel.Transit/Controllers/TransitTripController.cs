using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using MaplePixel.Transit.Models;

namespace MaplePixel.Transit.Controllers
{
    public class TransitTripController : ApiController
    {
        private List<TransitTrip> trips = new List<TransitTrip>();

        public TransitTripController()
        {
            var route1 = new TransitRoute {Id = 1, LongName = "Caboolture Line", ShortName = "CABL"};

            trips.Add(new TransitTrip
            {
                Id = 1,
                Route = route1,
                DepartingLocation = "Bald Hills",
                DepartingTime = new DateTime(2016, 07, 01, 06, 00, 00),
                ArrivingLocation = "Central Station",
                ArrivingTime = new DateTime(2016, 07, 01, 06, 32, 00)
            });
            trips.Add(new TransitTrip
            {
                Id = 2,
                Route = route1,
                DepartingLocation = "Bald Hills",
                DepartingTime = new DateTime(2016, 07, 01, 06, 37, 00),
                ArrivingLocation = "Central Station",
                ArrivingTime = new DateTime(2016, 07, 01, 07, 09, 00)
            });

        }

        // GET: api/TransitTrip
        public IEnumerable<TransitTrip> Get()
        {
            return trips;
        }

        // GET: api/TransitTrip/5
        public TransitTrip Get(int id)
        {
            return trips.FirstOrDefault(t => t.Id == id);
        }

        // POST: api/TransitTrip
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TransitTrip/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TransitTrip/5
        public void Delete(int id)
        {
        }
    }
}
