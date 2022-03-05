using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationCore.Entities
{
    public class Topic
    {
        /// <summary>
        /// Id topic
        /// </summary>
        public int TopicID { get; set; }
        /// <summary>
        /// Tên topic
        /// </summary>
        public string? TopicName { get; set; }
        /// <summary>
        /// Id môn học
        /// </summary>
        public int SubjectID { get; set; }
        /// <summary>
        /// Id khối
        /// </summary>
        public int GradeID { get; set; }

    }
}
