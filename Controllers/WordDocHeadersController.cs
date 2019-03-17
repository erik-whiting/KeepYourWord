﻿using System;
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
        public IHttpActionResult GetDocHeaderHtml(string filename)
        {
            Configs config = new Configs();
            string root = config.BlogRoot + "\\";
            var rootArray = root.Split('\\');
            while (rootArray.Last() != config.RootName)
            {
                filename = rootArray.Last() + "\\" + filename;
                rootArray = rootArray.Take(rootArray.Count() - 1).ToArray();
            }
            string filenameLocation = root + filename + ".docx";
            filenameLocation = filenameLocation.Replace("'", "");
            
            try
            {
                WordDocHeader WordDocHeader = new WordDocHeader(DocX.Load(filenameLocation), filename);
                return Ok(WordDocHeader.headerHtml);
            }
            catch (UnauthorizedAccessException)
            {
                return Ok("");
            }
        }
    }
}
