using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WordStuff.Models;

namespace WordStuff.Controllers
{
    public class DirectoryStructureController : ApiController
    {
        public IHttpActionResult GetDirectoryStructure()
        {
            DirectoryStructure directoryStructure = new DirectoryStructure();
            return Ok(directoryStructure);
        }

    }
}
