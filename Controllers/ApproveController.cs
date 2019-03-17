using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WordStuff.Models;
using Xceed.Words.NET;

namespace WordStuff.Controllers
{
    public class ApproveController : ApiController
    {
        public IHttpActionResult ApproveOrReject(bool approve, string fileFrom, string fileTo = "")
        {
            Configs config = new Configs();
            string root = config.BlogRoot + "\\";
            fileFrom = root + "\\" + config.ReviewFolder + "\\" + fileFrom;
            string response = "";
            fileFrom += ".docx";
            var document = DocX.Load(fileFrom);

            if (approve)
            {
                string fileName = fileFrom.Split('\\').Last();
                fileTo = root + fileTo + fileName;
                document.SaveAs(fileTo);
                response = "Approved";
                File.Delete(fileFrom);
            }
            else
            {
                document.Dispose();
                response = "Rejected";
                File.Delete(fileFrom);
            }
            
            return Ok(response);
        }
    }
}
