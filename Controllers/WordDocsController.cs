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
    public class WordDocsController : ApiController
    {

        public IHttpActionResult GetWordDoc(string filename)
        {
            //filenameLocation = "C:\\Users\\eedee\\Documents\\mastersStuff\\Spring19\\SW Engr\\week2\\KeepYourWord_Requirements.docx";
            string root = "C:\\Users\\eedee\\Documents\\mastersStuff\\Spring19\\SW Engr\\week2\\";
            string filenameLocation = root + filename;
            filenameLocation += ".docx";
            WordDoc WordDoc = new WordDoc(DocX.Load(filenameLocation));
            return Ok(WordDoc);
        }
    }
    
}
