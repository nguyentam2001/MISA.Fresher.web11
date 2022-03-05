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
    public class TopicRepository : BaseRepository<Topic>, ITopicRepository
    {
      
        public TopicRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public List<Topic> GetTopicsFilter(int GradeID, string SubjectCode)
        {
            _dynamicParameters.Add("@GradeID", GradeID);
            _dynamicParameters.Add("@SubjectCode", SubjectCode);
            var topicList = _dbConnection.Query<Topic>($"Proc_GetTopicFilter",_dynamicParameters,commandType:CommandType.StoredProcedure).ToList();
            return topicList;
        }
    }
}
