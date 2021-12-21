using BussLayer;
using BussLayer.BussEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsPortal.Controllers
{
    public class NewsController : ApiController
    {
        [Route("api/News/news")]
        [HttpGet]
        public List<String> GetNames()
        {
            return ReportService.GetNames();
        }

        [Route("api/News/all")]
        [HttpGet]
        public List<ReportModel> Get()
        {
            return ReportService.Get();
        }


    }
}
