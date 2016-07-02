using System.Linq;
using MaplePixel.Transit.Controllers;
using NUnit.Framework;

namespace MaplePixel.Transit.Tests.Controllers
{
    [TestFixture]
    public class TransitRouteControllerFixture
    {
        [Test]
        public void Can_Get_All_Transit_Routes()
        {
            // Given / When
            var controller = new TransitRouteController();
            var allRoutes = controller.Get().ToList();

            // Then
            Assert.That(allRoutes, Has.Count.GreaterThan(0));
        }

        [Test]
        public void Can_Get_Transit_Route_By_Id()
        {
            // Given 
            const int id = 1;

            // When
            var controller = new TransitRouteController();
            var route = controller.Get(id);

            // Then
            Assert.That(route.Id, Is.EqualTo(1));
            Assert.That(route.LongName, Is.EqualTo("Caboolture Line"));
            Assert.That(route.ShortName, Is.EqualTo("CAB"));
        }
    }
}
