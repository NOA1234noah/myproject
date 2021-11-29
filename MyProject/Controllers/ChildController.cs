using System.Web.Http;
using Bll;
namespace MyProject.Controllers
{
    public class ChildController : ApiController
    {
        clsDb db = new clsDb();
        // GET: api/Child
        public RequestResult Get()
        {
            return db.GetAllChildren();
        }

        // GET: api/Child/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Child
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Child/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Child/5
        public void Delete(int id)
        {
        }
    }
}
