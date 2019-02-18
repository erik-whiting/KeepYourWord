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
            const string KywRoot = "kywroot";
            string root = "C:\\Users\\eedee\\Documents\\mastersStuff\\Spring19\\SW Engr\\kywroot\\";
            var rootArray = root.Split('\\');
            while (rootArray.Last() != KywRoot)
            {
                filename = rootArray.Last() + "\\" + filename;
                rootArray = rootArray.Take(rootArray.Count() - 1).ToArray();
            }
            string filenameLocation = root + filename + ".docx";
            filenameLocation = filenameLocation.Replace("'", "");
            WordDocHeader WordDocHeader = new WordDocHeader(DocX.Load(filenameLocation), filename);
            return Ok(WordDocHeader.headerHtml);
        }
    }
}
