using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicationCore.Entities;
using AplicationCore.Interfaces;

namespace AplicationCore.Services
{
    public class SubjectService : BaseService<Subject>,ISubjectService
    {
        public SubjectService(IBaseRepository<Subject> baseRepository) : base(baseRepository)
        {
        }
    }
}
