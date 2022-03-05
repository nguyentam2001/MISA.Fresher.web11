using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicationCore.Entities;
using AplicationCore.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Infrastructure
{
    public class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
    {
        //Kế thừa lớp base repository
        public SubjectRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
