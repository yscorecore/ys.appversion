using System;
using System.Threading.Tasks;

namespace YS.AppVersion
{
    public interface IAppVersionService
    {
        Task<AppVersion> GetVersion();
    }
}
