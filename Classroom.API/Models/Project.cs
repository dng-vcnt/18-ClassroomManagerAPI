using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Classroom.API.Models
{
    public class Project
    {
        public int ProjectId { set; get; }
        public String Name { set; get; }
        public String Description { set; get; }

        public virtual ICollection<Assignment> Assignments { set; get; }
    }
}