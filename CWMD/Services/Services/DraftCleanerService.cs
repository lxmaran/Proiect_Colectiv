using System;
using System.Linq;
using Contracts.IServices;
using Dal;
using Microsoft.Practices.ObjectBuilder2;

namespace Services.Services
{
    public class DraftCleanerService : IDraftCleanerService
    {
        public IMyDbContext context { get; set; }
        public DraftCleanerService()
        {
            context = new MyDbContext();
        }
        public void RemoveDraftsThatPassedNrOfDays(int days)
        {
            var firstOrDefault = context.Status.FirstOrDefault(x => x.Name == "Draft");
            if (firstOrDefault == null) return;
            {
                var draftStatusId = firstOrDefault.Id;
                context.DocumentStatus
                    .Where(x => x.Status.Id == draftStatusId &&
                                x.UpdateDate == null).ToList()
                    .Where(x=> x.CreationDate.Value <= DateTime.Now.AddDays(-days))
                    .ForEach(x=>
                            context.DocumentStatus.Remove(x)
                            );
                context.SaveChanges();
            }
        }
    }
}
