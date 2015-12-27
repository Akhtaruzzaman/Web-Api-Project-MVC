﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class InformationController : ApiController
    {
        readonly InfoDbContext _dbset = new InfoDbContext();
        [HttpGet]
        public IEnumerable<Information> Get()
        {
            var data = from m in _dbset.InformationDbSet
                       select m;
            return data;
        }
        [Route("api/information/get")]
        public IEnumerable<Information> Get(int? id)
        {
            var information = from m in _dbset.InformationDbSet
                              where m.Id == id
                              select m;
            IEnumerable<Information> myEnumerable = information;
            return myEnumerable;
        }
        [Route("api/information/Create")]
        public void Create(List<string> value)
        {
            try
            {
                Information information = new Information();
                information.FirstName = value[0];
                information.LastName = value[1];
                information.Age = Convert.ToInt16(value[2]);
                information.ContactNo = value[3];
                information.Address = value[4];
                _dbset.InformationDbSet.Add(information);
                _dbset.SaveChanges();
            }
            catch (Exception)
            {
                //ignore
            }
        }
        public class Data
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string ContactNo { get; set; }
            public string Address { get; set; }
        }

        [Route("api/information/CreateGrid")]
        public void CreateGrid(IList<Data> value)
        {
            try
            {
                for (int i = 0; i < value.Count; i++)
                {
                    Information information = new Information();
                    information.FirstName = value[i].FirstName;
                    information.LastName = value[i].LastName;
                    information.Age = Convert.ToInt16(value[i].Age);
                    information.ContactNo = value[i].ContactNo;
                    information.Address = value[i].Address;
                    _dbset.InformationDbSet.Add(information);
                }

                _dbset.SaveChanges();
            }
            catch (Exception)
            {
                //ignore
            }
        }
        [Route("api/information/update")]
        public void Update(List<string> value)
        {
            try
            {
                Information information = new Information();
                information.Id = Convert.ToInt16(value[0]);
                information.FirstName = value[1];
                information.LastName = value[2];
                information.Age = Convert.ToInt16(value[3]);
                information.ContactNo = value[4];
                information.Address = value[5];
                _dbset.Entry(information).State = EntityState.Modified;
                _dbset.SaveChanges();
            }
            catch (Exception)
            {
                //ignore
            }
        }

        [Route("api/information/delete")]
        public void Delete(int? id)
        {
            try
            {
                Information information = _dbset.InformationDbSet.Find(id);
                _dbset.InformationDbSet.Remove(information);
                _dbset.SaveChanges();
            }
            catch (Exception)
            {
                //ignore
            }
        }
    }
}
