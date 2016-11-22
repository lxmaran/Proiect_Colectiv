using System;
using System.Threading;

namespace DraftCleanerRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new DraftCleanerService.DraftCleanerServiceWcfClient();
            while (true)
            {
                service.Open();
                service.RemoveOldDrafts();
                service.Close();
                Thread.Sleep(TimeSpan.FromDays(1));
            }
        }
    }
}
