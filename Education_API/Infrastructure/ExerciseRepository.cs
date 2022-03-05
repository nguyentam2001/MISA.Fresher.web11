using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicationCore.Entities;
using AplicationCore.Interfaces;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace Infrastructure
{
    public class ExerciseRepository : BaseRepository<Exercise>, IExerciseRepository
    {
        public ExerciseRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public int DeleteExerciseByID(string exerciseID)
        {
            _dynamicParameters.Add("ExerciseID", exerciseID);
            return  _dbConnection.Execute($"Proc_DeleteExerciseByID", _dynamicParameters, commandType: CommandType.StoredProcedure);
            
        }
        public Exercise GetExerciseByID(string id)
        {
            _dynamicParameters.Add("ExerciseID", id);
            var exercise = _dbConnection.Query<Exercise>($"Proc_GetExerciseByID", _dynamicParameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return exercise;
        }

        public List<Exercise> GetExercisesFilter(int? GradeID, int? TopicID, int? SubjectID, string? QueryText, int? StartIndex, int? PageSize)
        {
      
            _dynamicParameters.Add($"GradeID", GradeID);
            _dynamicParameters.Add($"TopicID", TopicID);
            _dynamicParameters.Add($"SubjectID", SubjectID);
            _dynamicParameters.Add($"QueryText", QueryText);
            _dynamicParameters.Add($"StartIndex", StartIndex);
            _dynamicParameters.Add($"PageSize", PageSize);
            var listExercise = _dbConnection.Query<Exercise>($"Proc_GetExercisesFilter", _dynamicParameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
            return listExercise;
           
        }

        public int UpdateStatus(string exerciseID)
        {
            _dynamicParameters.Add("exerciseID", exerciseID);
            return _dbConnection.Execute("Proc_UpdateExcerciseStatus", _dynamicParameters, commandType: CommandType.StoredProcedure);
        }
    }
}
