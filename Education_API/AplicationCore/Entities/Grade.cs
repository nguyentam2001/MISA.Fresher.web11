using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationCore.Entities
{
    public class Grade
    {
        /// <summary>
        /// id khối
        /// </summary>
        public int GradeID { get; set; }
        /// <summary>
        /// Tên khối
        /// </summary>
        public string? GradeName { get; set; }
    }
}
