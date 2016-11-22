using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DraftCleanerService.Tests
{
    [TestClass()]
    public class DraftCleanerServiceWcfTests
    {
        [TestMethod()]
        public void RemoveOldDraftsTest()
        {
            var service = new DraftCleanerServiceWcf(new Services.Services.DraftCleanerService());
            service.RemoveOldDrafts();
        }
    }
}