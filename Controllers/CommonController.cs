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
    [Route("api/[controller]")]
    public class CommonController : ControllerBase
    {
        Context context;
        public CommonController(Context _ctx)
        {
            this.context = _ctx;
        }
        
        [HttpGet("[action]")]
        public Org GetOrg()
        {
            return context.Orgs?.First();
        }
    }
}
