using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationCore.Entities
{
    public class Answer
    {
        public int AnswerID { get; set; }
        public int? QuestionID { get; set; }

        public string? Content { get; set; }
        public int? Correct { get; set; }
        public string? Image { get; set; }
    }
}

