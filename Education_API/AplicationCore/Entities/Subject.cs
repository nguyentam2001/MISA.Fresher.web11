using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationCore.Entities
{
    public class Subject
    {
        /// <summary>
        /// id môn học
        /// </summary>
        public int SubjectID { get; set; }
        /// <summary>
        /// Tên môn học
        /// </summary>
        public string? SubjectName { get; set; }
        /// <summary>
        /// Mã môn học
        /// </summary>
        public string? SubjectCode { get; set; }
        /// <summary>
        /// Hình ảnh
        /// </summary>
        public string? SubjectImg { get; set; }
    }
}
