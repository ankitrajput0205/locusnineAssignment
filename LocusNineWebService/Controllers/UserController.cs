using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using LocusNineDataAccessLayer;
using LocusNineWebService.Repository;

namespace LocusNineWebService.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public JsonResult<List<Models.User>> ViewUsers()
        {
            List<Models.User> lstModelUsers = new List<Models.User>();
            LocusNineMapper<User, Models.User> mapobj = new LocusNineMapper<User, Models.User>();
            LocusNineRepository repObj = new LocusNineRepository();
            var lstUsers = repObj.ViewUsersUsingLinq();
            var users = new List<Models.User>();
            foreach (var item in lstUsers)
            {
                lstModelUsers.Add(mapobj.Translate(item));
            }
            
            
            return Json<List<Models.User>>(users);
        }
        // GET: api/User
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
