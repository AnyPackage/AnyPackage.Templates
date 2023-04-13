using AnyPackage.Provider;

namespace ProviderName
{
    [PackageProvider("ProviderName")]
    public class ProviderNameProvider : PackageProvider, IGetPackage
    {
        public void GetPackage(PackageRequest request)
        {
            if (request.IsMatch("Test", "1.0"))
            {
                var package = new PackageInfo("Test", "1.0", ProviderInfo);
                request.WritePackage(package);
            }
        }
    }
}
