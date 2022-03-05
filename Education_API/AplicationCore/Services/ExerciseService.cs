using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicationCore.Entities;
using AplicationCore.Interfaces;

namespace AplicationCore.Services
{
    public class ExerciseService : BaseService<Exercise>, IExerciseService
    {
        IExerciseRepository _exerciseRepository;
        IQuestionRepository _questionRepository;
       
        public ExerciseService(IBaseRepository<Exercise> baseRepository, IExerciseRepository exerciseRepository,IQuestionRepository questionRepository) : base(baseRepository)
        {
            _exerciseRepository = exerciseRepository;
            _questionRepository = questionRepository;
        }

       
        public override object Add(Exercise exercise)
        {
            //Sinh mã học liệu mới
            exercise.ExerciseID = Guid.NewGuid().ToString();
            return new
            {
                roweffect = base.Add(exercise),
                id=exercise.ExerciseID,
            };

        }

        public int DeleteExerciseByID(string exerciseID)
        {
           return _exerciseRepository.DeleteExerciseByID(exerciseID);
        }

        public object GetExercisesFilter(int? GradeID, int? TopicID, int? SubjectID, string? QueryText, int PageIndex, int PageSize)
        {
            //Đếm tổng số bản ghi

            var totalRecord = _exerciseRepository.GetTEntities().ToList().Count;
            totalRecord = _exerciseRepository.GetExercisesFilter(GradeID, TopicID, SubjectID, QueryText, 0, totalRecord).ToList().Count;
            var totalPage = 0;
            var startIndex = (PageIndex - 1) * PageSize;
            if (totalRecord > 0)
            {
                if (totalRecord > PageSize)
                {
                    var remaind = totalRecord % PageSize;
                    if (remaind != 0)
                    {
                        totalPage = totalRecord / PageSize + 1;
                    }
                    else
                    {
                        totalPage = totalRecord / PageSize;
                    }
                }
                else
                {
                    totalPage = 1;
                    PageSize = totalRecord;
                    startIndex = 0;
                }

                return new
                {
                    TotalPage = totalPage,
                    TotalRecord = totalRecord,
                    Data = _exerciseRepository.GetExercisesFilter(GradeID, TopicID, SubjectID, QueryText, startIndex, PageSize).ToList(),
                };
            }
            else
            {
                return null;
            }
           
            // return _exerciseRepository.GetExercisesFilter(GradeID, TopicID, SubjectID, QueryText, startIndex, PageSize);  
        }

        public object GetExerciseStore(string exerciesId)
        {
            var exercise = _exerciseRepository.GetExerciseByID(exerciesId);
            var questions = _questionRepository.GetQuestionsByExerciseID(exerciesId);
            exercise.questions=questions;
            exercise.QtyQuestions = questions.Count();
           
            return exercise;

        }

        public int UpdateStatus(string exerciseID)
        {

            var questions = _questionRepository.GetQuestionsByExerciseID(exerciseID).Count;
            if(questions != 0)
            {
                return _exerciseRepository.UpdateStatus(exerciseID);
            }
            else
            {
                return 0;
            }
           
        }
    }
}
