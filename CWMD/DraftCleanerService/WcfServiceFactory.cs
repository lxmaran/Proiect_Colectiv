using Microsoft.Practices.Unity;
using Unity.Wcf;

namespace DraftCleanerService
{
	public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
			
            //container.RegisteType<IYourService, YourServiceImpl>();
        }
    }    
}