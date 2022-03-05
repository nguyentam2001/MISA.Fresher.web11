using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicationCore.Entities;
using AplicationCore.Interfaces;

namespace AplicationCore.Services
{
    public class TopicService : BaseService<Topic>, ITopicService
    {
        ITopicRepository _topicRepository;
        public TopicService(IBaseRepository<Topic> baseRepository,ITopicRepository topicRepository) : base(baseRepository)
        {
            _topicRepository = topicRepository;
        }

        public List<Topic> GetTopicsFilter(int GradeID, string SubjectCode)
        {
            return _topicRepository.GetTopicsFilter(GradeID,SubjectCode);
        }
    }
}
