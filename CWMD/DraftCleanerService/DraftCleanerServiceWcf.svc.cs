using System;
using Contracts.IServices;

namespace DraftCleanerService
{
    public class DraftCleanerServiceWcf : IDraftCleanerServiceWcf
    {
        private IDraftCleanerService draftCleanerService { get; }
        public DraftCleanerServiceWcf(IDraftCleanerService draftCleanerService)
        {
            this.draftCleanerService = draftCleanerService;
        }
        public void RemoveOldDrafts()
        {
            draftCleanerService.RemoveDraftsThatPassedNrOfDays(30);
        }
    }
}
