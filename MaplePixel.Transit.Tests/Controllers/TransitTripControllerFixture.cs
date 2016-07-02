using System.Linq;
using MaplePixel.Transit.Controllers;
using NUnit.Framework;

namespace MaplePixel.Transit.Tests.Controllers
{
    internal class TransitTripControllerFixture
    {
        [Test]
        public void Can_Get_All_Transit_Routes()
        {
            // Given / When
            var controller = new TransitTripController();
            var allTrips = controller.Get().ToList();

            // Then
            Assert.That(allTrips, Has.Count.GreaterThan(0));
        }

        [Test]
        public void Can_Get_Transit_Route_By_Id()
        {
            // Given 
            const int id = 1;

            // When
            var controller = new TransitTripController();
            var trip = controller.Get(id);

            // Then
            Assert.That(trip.Id, Is.EqualTo(1));
            Assert.That(trip.Route.Id, Is.EqualTo(1)); // Relationship is correct!
            Assert.That(trip.DepartingLocation, Is.EqualTo("Bald Hills"));
            Assert.That(trip.DepartingTime.ToShortTimeString(), Is.EqualTo("6:00 AM"));
            Assert.That(trip.ArrivingLocation, Is.EqualTo("Central Station"));
            Assert.That(trip.ArrivingTime.ToShortTimeString(), Is.EqualTo("6:32 AM"));
        }
    }
}