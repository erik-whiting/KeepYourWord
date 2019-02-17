using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WordStuff.Models;
using Xceed.Words.NET;

namespace WordStuff.Controllers
{
    public class WordDocHeadersController : ApiController
    {
        public IHttpActionResult GetDocHeader(string filename, string testString = "")
        {
            string root = "C:\\Users\\eedee\\Documents\\mastersStuff\\Spring19\\SW Engr\\kywroot\\";
            string filenameLocation = root + filename + ".docx";
            WordDocHeader WordDocHeader = new WordDocHeader(DocX.Load(filenameLocation), testString);
            return Ok(WordDocHeader.headerHtml);
        }
    }
}
