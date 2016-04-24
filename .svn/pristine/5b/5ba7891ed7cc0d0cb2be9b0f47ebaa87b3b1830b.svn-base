using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class InformationEntryController : Controller
    {
        InfoDbContext dbset = new InfoDbContext();
        // GET: InformationEntry
        public ActionResult Index()
        {
            var data = from m in dbset.InformationDbSet
                       select m;
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Information information)
        {
            if (ModelState.IsValid)
            {
                dbset.InformationDbSet.Add(information);
                dbset.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(information);
            }
        }
        public ActionResult Delete(int? id)
        {
            Information information = dbset.InformationDbSet.Find(id);
            if (information == null)
            {
                return HttpNotFound();
            }
            return View(information);
        }


        [HttpPost]
        public ActionResult Delete(Information info)
        {
            Information information = dbset.InformationDbSet.Find(info.Id);
            dbset.InformationDbSet.Remove(information);
            dbset.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET: InformationEntry
        public ActionResult Edit(int? id)
        {
            Information information = dbset.InformationDbSet.Find(id);
            if (information == null)
            {
                return HttpNotFound();
            }
            return View(information);
        }


        [HttpPost]
        public ActionResult Edit(Information aInformation)
        {
            if (ModelState.IsValid)
            {
                dbset.Entry(aInformation).State = EntityState.Modified;
                dbset.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aInformation);
        }

        //GET : InformationEntry
        public ActionResult Details(int? id)
        {
            Information information = dbset.InformationDbSet.Find(id);
            if (information == null)
            {
                return HttpNotFound();
            }
            return View(information);
        }

        //Post : InformationEntry
        [HttpPost]
        public ActionResult Details(Information information)
        {
            information = dbset.InformationDbSet.Find(information.Id);
            if (information == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Edit");
        }

    }
}