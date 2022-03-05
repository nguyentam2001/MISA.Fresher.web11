using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicationCore.Entities;

namespace AplicationCore.Interfaces
{
    public interface ITopicRepository:IBaseRepository<Topic>
    {
        List<Topic> GetTopicsFilter(int GradeID, string SubjectCode);
    }
}
