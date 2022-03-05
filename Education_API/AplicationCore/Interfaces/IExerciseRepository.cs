using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicationCore.Entities;

namespace AplicationCore.Interfaces
{
    public interface IExerciseRepository:IBaseRepository<Exercise>
    {
      List<Exercise> GetExercisesFilter(int? GradeID, int? TopicID, int? SubjectID, string? QueryText, int? StartIndex, int? PageSize);
        Exercise GetExerciseByID(string id);
        int DeleteExerciseByID(string exerciseID);
        int UpdateStatus(string exerciseID);
    }
    
}
