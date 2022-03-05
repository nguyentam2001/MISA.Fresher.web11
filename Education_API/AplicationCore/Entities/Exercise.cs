using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationCore.Entities
{
    public class Exercise
    {

        public string ExerciseID { get; set; }
        public string? Title { get; set; }
        public int? GradeID { get; set; }
        public int? SubjectID { get; set; }
        public string? Avatar { get; set; }
        public int? TopicID { get; set; }
        public int? TagID { get; set; }
        public int? Status { get; set; }
        public string? Hint { get; set; }
        public int? QtyQuestions { get; set; }
        public List<Question>? questions { get; set; }
        public string? Tags { get; set; }

    }
}
