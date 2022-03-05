using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationCore.Interfaces
{
    public interface IBaseRepository<T> 
    {
        /// <summary>
        /// Lấy toàn bộ entity
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetTEntities();
        //Thêm mới TEntity
        /// <summary>
        /// Thêm mới dữ liệu
        /// </summary>
        /// <param name="TEntity">object</param>
        /// <returns>Số lượng bản ghi được thêm</returns>
        /// createBy:NVTAM (19/2/2021)
        int Add(T entity);
        /// <summary>
        /// Cập nhật entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Update(T entity);
      
    }
}
