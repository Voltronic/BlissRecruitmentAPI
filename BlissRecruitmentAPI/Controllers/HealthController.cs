using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace BlissRecruitmentAPI.Controllers
{
    /// <summary>
    /// BlissRecruitmentAPI Health controller
    /// </summary>
    public class HealthController : ApiController
    {
        /// <summary>
        /// Gets the health status
        /// </summary>
        /// <remarks>
        /// api/health/[get]
        /// </remarks>
        /// <returns>IHttpActionResult typeof(ServerHealth) -  Content Type Json</returns>
        [ResponseType(typeof(ServerHealth))]
        public IHttpActionResult Get()
        {
            var health = new ServerHealth();
            health.status = HttpStatusCode.OK.ToString();

            return Ok(health);
        }
    }
}
