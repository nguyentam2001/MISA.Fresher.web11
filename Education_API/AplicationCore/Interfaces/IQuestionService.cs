using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicationCore.Entities;

namespace AplicationCore.Interfaces
{
    public interface IQuestionService:IBaseSevice<Question>
    {
        public object UpdateQuestion(Question question);

        int Delete(int id);

    }
}
