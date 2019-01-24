using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace BlissRecruitmentAPI.Controllers
{
    /// <summary>
    /// BlissRecruitmentAPI Health controller
    /// </summary>
    public class HealthController : ApiController
    {
        // GET health
        public HttpResponseMessage Get()
        {
            var health = new ServerHealth();
            health.status = HttpStatusCode.OK.ToString();

            return Request.CreateResponse(HttpStatusCode.OK, health, Configuration.Formatters.JsonFormatter);
        }
    }
}
