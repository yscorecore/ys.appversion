using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace YS.AppVersion.Rest.Api
{
    [ApiController]
    [Route("appversion")]
    public class AppVersionController : ControllerBase

    {
        private readonly IAppVersionService appVersionService;

        public AppVersionController(IAppVersionService appVersionService)
        {
            this.appVersionService = appVersionService;
        }
        //[ProducesResponseType(typeof(ApiResponse<AppVersion>),200)]
        [HttpGet]
        public Task<AppVersion> GetVersion()
        {
            return appVersionService.GetVersion();
        }
    }
    //public class ApiResponse<T>
    //{
    //    public string Message { get; set; }
    //    public string Code { get; set; }

    //    public T Data { get; set; }
    //}
}
