using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Services;

namespace ServicesTests.Services
{
    [TestClass()]
    public class DraftCleanerServiceTests
    {
        [TestMethod()]
        public void RemoveDraftsThatPassedNrOfDaysTest()
        {
            var service = new DraftCleanerService();
            service.RemoveDraftsThatPassedNrOfDays(10);
        }
    }
}