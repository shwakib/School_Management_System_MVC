using Mid_SchoolManagementSystem.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mid_SchoolManagementSystem.Controllers
{
    public class DataController : Controller
    {
        smsEntities data = new smsEntities();
        [HttpGet]
        public JsonResult GetSection(int classid)
        {
            Debug.WriteLine(classid);
            data.Configuration.ProxyCreationEnabled = false;
            List<section> sectionList = data.section.Where(x => x.classid == classid).ToList();
            return Json(sectionList,JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetSubject(int classid)
        {
            Debug.WriteLine(classid);
            data.Configuration.ProxyCreationEnabled = false;
            List<subject> subjectList = data.subject.Where(x => x.classid == classid).ToList();
            return Json(subjectList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetTeacher(int subjectid)
        {
            Debug.WriteLine(subjectid);
            data.Configuration.ProxyCreationEnabled = false;
            List<teacher> teacherList= data.teacher.Where(x => x.subjectid== subjectid).ToList();
            return Json(teacherList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetClass(int subjectid)
        {
            Debug.WriteLine(subjectid);
            data.Configuration.ProxyCreationEnabled = false;
            List<subject> classlist = data.subject.Where(x => x.subjectid == subjectid).ToList();
            return Json(classlist, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetSectionAssigned(int classid)
        {
            Debug.WriteLine(classid);
            data.Configuration.ProxyCreationEnabled = false;
            List<assignedcourse> sectionList = data.assignedcourse.Where(x => x.classid == classid).ToList();
            return Json(sectionList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetSubjectAssigned(int classid)
        {
            Debug.WriteLine(classid);
            data.Configuration.ProxyCreationEnabled = false;
            List<assignedcourse> subjectList = data.assignedcourse.Where(x => x.classid == classid).ToList();
            return Json(subjectList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetStudent(int sectionid)
        {
            Debug.WriteLine(sectionid);
            data.Configuration.ProxyCreationEnabled = false;
            List<student> studentList = data.student.Where(x => x.sectionid == sectionid).ToList();
            return Json(studentList, JsonRequestBehavior.AllowGet);
        }

    }
}