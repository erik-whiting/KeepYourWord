using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using WordStuff.Models;

namespace WordStuff.Controllers
{
    public class HeaderListController : ApiController
    {
        public IHttpActionResult GetHeaderList(string directoryName)
        {
            Configs config = new Configs();
            string root = config.BlogRoot + "\\";
            string directoryPath = root + directoryName + "\\";
            var returnHtml = "";
            var directory = new DirectoryStructureDto(directoryPath);
            var headerController = new WordDocHeadersController();
            foreach (var file in directory.Files)
            {
                string relativeFileLocation = directoryName + "\\" + file;
                var headerHtml = headerController.GetDocHeaderHtml(relativeFileLocation);
                var x = headerHtml as OkNegotiatedContentResult<string>;
                returnHtml += x.Content;
            }

            return Ok(returnHtml);
        }
    }
}
