using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class CabServiceController : ApiController
    {

        public CabService GET(int id)
        {
            using (thanujaEntities entities = new thanujaEntities())
            {
                return entities.CabServices.FirstOrDefault(e => e.CabServiceId == id);
            }
        }

        [HttpPost]
        [Route("api/user/register/cab")]
        public string RegisterCabService([FromBody] CabService cab)
        {
            using (thanujaEntities entities = new thanujaEntities())
            {
                entities.CabServices.Add(cab);
                entities.SaveChanges();
            }


            return "successful";
        }
    }
}
