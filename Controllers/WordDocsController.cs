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
            Configs config = new Configs();
            filename = filename.Replace("'", "");
            bool toBeReviewed = false;
            if (filename != "Home")
            {
                string containingDirectory = filename.Split('\\')[1];
                toBeReviewed = containingDirectory == config.ReviewFolder;
            }

            
            string root = config.BlogRoot + "\\";
            string filenameLocation = root + filename + ".docx";
            WordDoc WordDoc = new WordDoc(DocX.Load(filenameLocation), filename, toBeReviewed);
            return Ok(WordDoc.htmlString);
        }
    }
}
