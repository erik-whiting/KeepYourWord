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
            const string reviewDirectory = "To Be Reviewed";
            filename = filename.Replace("'", "");
            bool toBeReviewed = false;
            if (filename != "Home")
            {
                string containingDirectory = filename.Split('\\')[1];
                toBeReviewed = containingDirectory == reviewDirectory;
            }
            
            string root = "C:\\Users\\eedee\\Documents\\mastersStuff\\Spring19\\SW Engr\\kywroot\\";
            string filenameLocation = root + filename + ".docx";
            WordDoc WordDoc = new WordDoc(DocX.Load(filenameLocation), filename, toBeReviewed);
            return Ok(WordDoc.htmlString);
        }
    }
}
