using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicationCore.Entities;

namespace AplicationCore.Interfaces
{
    public interface IExerciseService:IBaseSevice<Exercise>
    {
       object GetExercisesFilter(int? GradeID, int? TopicID, int? SubjectID, string? QueryText, int PageIndex, int PageSize);
        object GetExerciseStore(string exerciesId);
        int DeleteExerciseByID(string exerciseID);
        int UpdateStatus(string exerciseID);

    }
}
