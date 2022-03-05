using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationCore.Entities
{
    public class Tag
    {
        public int TagID { get; set; }
        public int? GradeID { get; set; }
        public string? SubjectCode { get; set; }
        public string? TagName { get; set; }
        public int? SubjectID { get; set; }
    }
}
