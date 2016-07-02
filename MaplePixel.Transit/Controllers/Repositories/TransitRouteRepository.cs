using System.Collections.Generic;
using MaplePixel.Transit.Models;

namespace MaplePixel.Transit.Controllers.Repositories
{
    public class TransitRouteRepository
    {
        public int Save(TransitRoute route)
        {
            return -1;
        }

        public TransitRoute GetById(int id)
        {
            return null;
        }

        public IEnumerable<TransitRoute> GetAll()
        {
            return new List<TransitRoute>();
        }
    }
}