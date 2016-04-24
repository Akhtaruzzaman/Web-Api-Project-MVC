using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [System.Web.Http.Authorize]
    public class ValuesController : Controller
    {
        InfoDbContext dbset = new InfoDbContext();
        // GET api/values

        //private static readonly IEnumerable<Information> Items = new IEnumerable<Information>();
        
        public IEnumerable<Information> Get()
        {
            var data = from m in dbset.InformationDbSet
                       select m;
            IEnumerable<Information> myEnumerable = data;
            return myEnumerable;
        }
        
        //public IHttpActionResult GetProduct(int id)
        //{
        //    var product = dbset.FirstOrDefault((p) => p.Id == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(product);
        //}

        // GET api/values/5
        [System.Web.Http.HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
