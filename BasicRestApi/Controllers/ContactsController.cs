using BasicRestApi.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BasicRestApi.Controllers
{
    [RoutePrefix("contacts")]
    public class ContactsController : Controller
    {
        [Route("")]
        [HttpGet]
        public JsonResult GetContacts()
        {
            // create a list of contacts
            var contacts = new List<Contact>
            {
                new Contact { Id = Guid.NewGuid(), Name = "Smick Mick", Email = "smick.mick@hello.com" },
                new Contact { Id = Guid.NewGuid(), Name = "Danny Andrews", Email = "danny.andrews@hello.com" },
                new Contact { Id = Guid.NewGuid(), Name = "Joe Blow", Email = "joe.blow@hello.com" }
            };

            return Json(contacts, JsonRequestBehavior.AllowGet);
        }

        [Route("{id}")]
        [HttpGet]
        public JsonResult GetContact(Guid id)
        {
            return Json(new Contact { Id = Guid.NewGuid(), Name = "Smick Mick", Email = "smick.mick@hello.com" }, JsonRequestBehavior.AllowGet);
        }

        //// GET: Contacts/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Contacts/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Contacts/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Contacts/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
