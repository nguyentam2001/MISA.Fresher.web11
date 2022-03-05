using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationCore.Entities
{
    public class Tag_exercies_detail
    {
        public int TagpicID { get; set; }
        public int? TagID { get; set; }
        public Guid? ExerciseID { get; set; }
        public int? TagAmount { get; set; }
    }
}
