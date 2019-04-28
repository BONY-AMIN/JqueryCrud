using JavaScriptAjx.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JavaScriptAjx.Controllers
{
    public class StudentController : Controller
    {
       private AjaxContext db=new AjaxContext();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult AllGet()
        {
            var all = db.Students.ToList();
            return Json(all, JsonRequestBehavior.AllowGet);
        }


        // GET: Student/Create

            public JsonResult savex(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return Json(new { success = true });

        }

        public JsonResult GetById(int? id)
        {
            Student std = db.Students.Find(id);
            return Json(std, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Update(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
            }
            return Json(new { success = true });
        }

        public JsonResult DeleteConfirmed(int id)
        {
            db.Students.Remove(db.Students.Find(id));
            db.SaveChanges();
            return Json(new { success = true });
        }
    }
}
