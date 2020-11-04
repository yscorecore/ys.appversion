using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YS.AppVersion.Impl.Assembly.UnitTest
{
    [TestClass]
    public class AssemblyAppVersionServiceTest
    {
        [TestMethod]
        public async Task ShouldGetAssemblyVersion()
        {
            var service = new AssemblyAppVersionService();
            var version = await service.GetVersion();
            Assert.IsNotNull(version);
            Assert.IsNotNull(version.AssemblyVersion);
            Assert.IsNotNull(version.AssemblyFileVersion);
            Assert.IsNotNull(version.AssemblyInformationalVersion);
        }
    }
}
