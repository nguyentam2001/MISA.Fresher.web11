using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicationCore.Entities;

namespace AplicationCore.Interfaces
{
    public interface IQuestionRepository:IBaseRepository<Question>
    {
        /// <summary>
        /// Lấy danh sách câu hỏi by ExerciseID
        /// </summary>
        /// <param name="ExerciseID"> id học liệu</param>
        /// <returns></returns>
        List<Question> GetQuestionsByExerciseID(string ExerciseID);
       public object UpdateQuestion(Question question);

        int Delete(int id);
    }
}
