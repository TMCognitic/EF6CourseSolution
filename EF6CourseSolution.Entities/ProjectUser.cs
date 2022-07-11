using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6CourseSolution.Entities
{
    public class ProjectUser
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public DateTime EntryDate { get; set; } 
    }
}
