using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ESApi.Models.Code.Admin;
using ESApi.Models.ModelEntity;
using ESApi.Models;
using AutoMapper;
using System.Web.Http.Cors;


namespace ESApi.Models.Code.Admin
{
    [EnableCors(origins: "*",headers:"*",methods: "*")]
    public class AdminManufactoryController : ApiController
    {
        AdminManufactoryCode ad = new AdminManufactoryCode();

        [HttpGet]
        [Route("api/admin/manufactory/all")]
        public IHttpActionResult GetAll()
        {
            return Ok(ad.getall());
        }

        [HttpGet]
        [Route("api/admin/manufactory/byID/{ID}")]
        public IHttpActionResult GetId([FromUri]int id)
        {
            return Ok(ad.getId(id));
        }

        [HttpPost]
        [Route("api/admin/manufactory/add")]
        public IHttpActionResult Add([FromBody]NHASANXUATModel sx)
        {
            ad.add(sx);

            return Ok();
        }

        [HttpPut]
        [Route("api/admin/manufactory/update")]
        public IHttpActionResult Update([FromBody]NHASANXUATModel news_sx)
        {
            ad.update(news_sx);

            return Ok();
        }
    }
}
