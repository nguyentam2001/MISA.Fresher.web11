using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicationCore.Entities;
using AplicationCore.Interfaces;

namespace AplicationCore.Services
{
    public class GradeService:BaseService<Grade>,IGradeService
    {
        //Vì hàm cho có hàm tạo lên khi kế thừa phải kế thừa cả hàm tạo
        IBaseRepository<Grade> _baseRepository;
        IGradeRepository _gradeRepository;

        public GradeService(IBaseRepository<Grade> baseRepository, IGradeRepository gradeRepository):base(baseRepository)
        {
            //Thực thi khi chương trình chạy
            _baseRepository = baseRepository;   
            _gradeRepository = gradeRepository;

        }

    }
}
