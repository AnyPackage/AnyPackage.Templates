using System;
using System.Management.Automation;
using static AnyPackage.Provider.PackageProviderManager;

namespace ProviderName
{
    public sealed class Init : IModuleAssemblyInitializer, IModuleAssemblyCleanup
    {
        private readonly Guid _id = new Guid("0582c4ed-4776-4bd2-9ce2-67ea83718597");
        
        public void OnImport()
        {
            RegisterProvider(_id, typeof(ProviderNameProvider), "ModuleName");
        }

        public void OnRemove(PSModuleInfo psModuleInfo)
        {
            UnregisterProvider(_id);
        }
    }
}
