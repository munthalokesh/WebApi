﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using WebApi.Models.DataLayer;
using WebApi.Models.Entities;

namespace WebApi.Controllers
{
    public class HangerDetailsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(DateTime fromdate,DateTime todate)
        {
            HangerDetailsDbOperations db=new HangerDetailsDbOperations();
            //DateTime fromDateFormatted = DateTime.ParseExact(fromdate.ToString(),"dd-MM-yyyy", CultureInfo.InvariantCulture);
            //DateTime toDateFormatted = DateTime.ParseExact(todate.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            List<GetAvailableHangarsDetails_Result> l=db.GetHangers(fromdate, todate);
            if (l != null || l.Count >=0)
            {
                return Ok(l);
            }
            else

            {
                return Content(HttpStatusCode.BadRequest, l);
            }
        }

        // POST api/<controller>
        [HttpPost]
        public IHttpActionResult AddHanger([FromBody] Hanger h)
        {
            HangerDetailsDbOperations Hd = new HangerDetailsDbOperations();
            string s = Hd.AddHanger(h);
            List<string> list = s.Split(',').ToList();
            if (list[0].Equals("0"))
            {
                return Ok(list[1]);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, list[1]);
            }
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}