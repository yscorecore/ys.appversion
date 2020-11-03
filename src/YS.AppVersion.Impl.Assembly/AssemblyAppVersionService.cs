using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using YS.Knife;

namespace YS.AppVersion.Impl.Assembly
{
    [Service(Lifetime = ServiceLifetime.Singleton)]
    public class AssemblyAppVersionService : IAppVersionService
    {
        public Task<AppVersion> GetVersion()
        {
            var entryAssembly = System.Reflection.Assembly.GetEntryAssembly();
            var version = new AppVersion
            {
                AssemblyVersion = entryAssembly.GetCustomAttribute<AssemblyVersionAttribute>()?.Version,
                AssemblyFileVersion = entryAssembly.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version,
                AssemblyInformationalVersion = entryAssembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion

            };
            return Task.FromResult(version);
        }
    }
}
