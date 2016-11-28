using System.ServiceModel;

namespace DraftCleanerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDraftCleanerServiceWcf" in both code and config file together.
    [ServiceContract]
    public interface IDraftCleanerServiceWcf
    {
        [OperationContract]
        void RemoveOldDrafts();
    }
}
