using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicationCore.Entities;
using AplicationCore.Interfaces;

namespace AplicationCore.Services
{
    public class QuestionService : BaseService<Question>,IQuestionService
    {
        IQuestionRepository _questionRepository;
        public QuestionService(IBaseRepository<Question> baseRepository, IQuestionRepository questionRepository) : base(baseRepository)
        {
            _questionRepository = questionRepository;
        }

        public object UpdateQuestion(Question question)
        {
           return _questionRepository.UpdateQuestion(question); 
        }

        public int Delete(int id)
        {
           
            return _questionRepository.Delete(id);
        }
    }
}
