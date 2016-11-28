namespace Contracts.IServices
{
    public interface IDraftCleanerService
    {
        void RemoveDraftsThatPassedNrOfDays(int days);
    }
}
