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
    public class WordDocsController : ApiController
    {

        public IHttpActionResult GetWordDocHtml(string filename)
        {
            string root = "C:\\Users\\eedee\\Documents\\mastersStuff\\Spring19\\SW Engr\\week2\\";
            string filenameLocation = root + filename + ".docx";
            WordDoc WordDoc = new WordDoc(DocX.Load(filenameLocation));
            return Ok(WordDoc.htmlString);
        }
    }
}
