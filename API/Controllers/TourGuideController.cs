using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    
    public class TourGuideController : ApiController
    {



        public TourGuide GET(int id)
        {
            using (thanujaEntities entities = new thanujaEntities())
            {
                return entities.TourGuides.FirstOrDefault(e => e.GuideId == id);
            }
        }




        [HttpPost]
        [Route("api/user/register/tourguide")]
        public string RegisterTourGuide([FromBody] TourGuide guide)
        {
            using (thanujaEntities entities = new thanujaEntities())
            {
                entities.TourGuides.Add(guide);
                entities.SaveChanges();
            }
            return "successful";
        }
    }
}
