using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;

namespace verbose_disco.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommonController : ControllerBase
    {
        Context context;
        public CommonController(Context _ctx)
        {
            context = _ctx;
        }
        
        [HttpGet]
        public string GetOrgName()
        {

                return context.Orgs.First().name;
        }
    }
}
