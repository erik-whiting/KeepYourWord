using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WordStuff.Models;

namespace WordStuff.Controllers
{
    public class UserController : ApiController
    {
        public IHttpActionResult GetUser()
        {
            var user = new User();
            return Ok(User);
        }
    }
}
