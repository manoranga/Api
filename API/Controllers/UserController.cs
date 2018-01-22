using API.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



namespace API.Controllers
{
    public class UserController : ApiController
    {
        public IEnumerable<Tourist> GET()
        {
            using (thanujaEntities entities = new thanujaEntities())
            {
                var all = entities.Tourists.Where(e => e.UserName == "prabodha");
                return all;
            }
        }


        public Tourist GET(int id)
        {
            using (thanujaEntities entities = new thanujaEntities())
            {
                return entities.Tourists.FirstOrDefault(e => e.TouristId == id);
            }
        }
        [HttpPost]
        [Route("api/user/register/tourist")]
        public string RegisterTourist([FromBody] Tourist user)
         {
             using (thanujaEntities entities = new thanujaEntities())
             {
                 entities.Tourists.Add(user);
                 entities.SaveChanges();
             }


             return "successful";
         }


        [HttpPost]
        [Route("api/user/login")]

        public string Loging([FromBody]Tourist user)
        {
            using (thanujaEntities db = new thanujaEntities())
            {
                
                var login = db.Tourists.Where(u => u.UserName == user.UserName).FirstOrDefault();
                if (login.Password == user.Password)
                {
                    return "loging success";
                }
                else return "LOGING FAILED";

            }
        }

       public String delete(int id)
        {
            using(thanujaEntities ent = new thanujaEntities())
            {
                ent.Tourists.Remove(ent.Tourists.FirstOrDefault(e => e.TouristId == id));
                ent.SaveChanges();
            }return "delete success";
        }
    }
}
