using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OpExAPI.Data;

namespace OpExAPI.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class NodeController : ControllerBase
    {
        private Singleton Data = Singleton.Instance();

        [Authorize]
        [HttpGet("all")]
        public object AllObjects()
        {
            return this.Data.objects;
        }

        [Authorize]
        [HttpGet("search")]
        public object GetSearchObjects(string value)
        {
            return this.Data.objects.FindAll(o => o.name.Contains(value));
        }
    }
}
