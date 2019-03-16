using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WordStuff.Models;

namespace WordStuff.Controllers
{
    public class ConfigController : ApiController
    {
        public IHttpActionResult GetKywConfigs()
        {
            var configs = new Configs();
            return Ok(configs);
        }
    }
}
