using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace BotPostSample.Controllers
{
    public class SampleController : ApiController
    {
        public IHttpActionResult PostAsync([FromBody]SampleData SampleString)
        {
            return Ok(HttpStatusCode.OK);
        }

        public class SampleData
        {
            public string testString { get; set; }
        }
    }
}
