using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationCore.Entities
{
    public class Question
    {
        public int QuestionID { get; set; }
        public int Type { get; set; }
        public string? Content { get; set; }
        public string? Attachments { get; set; }
        /// <summary>
        /// Các đáp án thuộc về câu hỏi Lưu trữ dạng JSON
        /// </summary>
        public string Answers { get; set; }
        public string? ExerciseID { get; set; }

    }
}
