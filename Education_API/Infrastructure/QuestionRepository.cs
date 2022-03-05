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
    public class QuestionRepository : BaseRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(IConfiguration configuration) : base(configuration)
        {
        }

    

        public List<Question> GetQuestionsByExerciseID(string ExerciseID)
        {
            _dynamicParameters.Add(@"ExerciseID", ExerciseID);
            var questions = _dbConnection.Query<Question>("Proc_GetQuestionsByExerciseID", _dynamicParameters, commandType: CommandType.StoredProcedure).ToList();
            return questions;
                
        }

        public object UpdateQuestion(Question question)
        {
            var questions = _dbConnection.Execute("Proc_UpdateQuestion", question, commandType: CommandType.StoredProcedure);
            return questions;
        }

        virtual public int Delete(int id)
        {
            _dynamicParameters.Add($"QuestionID", id);
            return _dbConnection.Execute($"Proc_DeleteQuestionByID", _dynamicParameters, commandType: CommandType.StoredProcedure);
        }
    }
}
