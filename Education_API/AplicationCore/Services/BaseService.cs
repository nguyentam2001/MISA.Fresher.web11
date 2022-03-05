using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicationCore.Entities;
using AplicationCore.Interfaces;

namespace AplicationCore.Services
{
    public class BaseService<TEntity>:IBaseSevice<TEntity>
    {
         IBaseRepository<TEntity> _baseRepository;
     

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository=baseRepository;
        }

      
        virtual public object Add(TEntity entity)
        {
           return _baseRepository.Add(entity);
        }

      

        //Lấy danh sách entities
        virtual public IEnumerable<TEntity> GetTEntities()
        {
            var entities = _baseRepository.GetTEntities();
            return entities;
        }

        public int Update(TEntity entity)
        {
            return _baseRepository.Update(entity);
        }
    }
}
