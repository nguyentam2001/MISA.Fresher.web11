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
    public class GradeRepository:BaseRepository<Grade>,IGradeRepository
    {
        
        //Kế thừa lớp base repository
        public GradeRepository(IConfiguration configuration):base(configuration)
        {

        }
    }
}
