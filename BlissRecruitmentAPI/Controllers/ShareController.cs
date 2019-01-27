using BlissRecruitmentAPI.DTO;
using BlissRecruitmentAPI.Mail;
using BlissRecruitmentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace BlissRecruitmentAPI.Controllers
{
    public class ShareController : ApiController
    {
        /// <summary>
        /// Share info by email
        /// </summary>
        /// <remarks>
        /// api/share/[get]
        /// </remarks>
        /// <returns>IHttpActionResult typeof(ShareResult) -  Content Type Json</returns>
        [HttpPost]
        [Route("api/share")]
        [ResponseType(typeof(ResultDTO))]
        public IHttpActionResult Get([FromUri] string destination_email, [FromUri] string content_url)
        {
            var result = new ResultDTO();

            if (!MailSender.IsValidEmail(destination_email))
            {
                result.status = "Bad Request. Either destination_email not valid or empty content_url";

                return Content(HttpStatusCode.BadRequest, result);
            }

            Task<string> task = Task.Factory.StartNew(() =>
            {
                return MailSender.SendEmail(destination_email, content_url);
            });

            if(task.Result != "OK")
            {
                result.status = "Internal Server Error. " + task.Result;

                return Content(HttpStatusCode.InternalServerError, result);
            }

            result.status = HttpStatusCode.OK.ToString();

            return Ok(result);
        }
    }
}
