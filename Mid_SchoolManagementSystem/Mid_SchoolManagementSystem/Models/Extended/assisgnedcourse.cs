using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mid_SchoolManagementSystem.Models.DataAccess
{
    [MetadataType(typeof(assisgnedcoursedata))]
    public partial class assignedcourse
    {

    }
    public class assisgnedcoursedata
    {
        [Display(Name ="Subject Name")]
        public int subjectid { get; set; }
        [Display(Name = "Teacher Name")]
        public string teacherid { get; set; }
        [Display(Name = "Class Name")]
        public int classid { get; set; }
        [Display(Name = "Section Name")]
        public int sectionid { get; set; }

    }
}