using System;
using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/env")]
    public class EnvController : ControllerBase
    {
        private readonly CloudFoundryInfo _cloudFoundryInfo;

        public EnvController(CloudFoundryInfo cloud_foundry_info)
        {
            _cloudFoundryInfo = cloud_foundry_info;
        }

        [HttpGet]
        public CloudFoundryInfo Get() => _cloudFoundryInfo;        
        
    }
}
