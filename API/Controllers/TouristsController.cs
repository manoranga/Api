using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class TouristsController : ApiController
    {

        [HttpPost]
        public string Register([FromBody] Tourist tourist)
        {
            return "";
        }
    }
}
