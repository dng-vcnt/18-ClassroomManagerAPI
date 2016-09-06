using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Classroom.API.Models
{
    public class Assignment
    {
        public int StudentId { set; get; }
        public int ProjectId { set; get; }

        public virtual Student Students { set; get; }
        public virtual Project Projects { set; get; }
    }
}