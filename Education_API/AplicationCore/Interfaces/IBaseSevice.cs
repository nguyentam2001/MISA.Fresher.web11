using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationCore.Interfaces
{
    public interface IBaseSevice<TEntity>
    {
        /// <summary>
        /// Lấy danh sách đối tượng được truyền vào
        /// </summary>
        /// <returns>danh sách đối tượng</returns>
        /// create by:NVTAM (3/1/2022)
        IEnumerable<TEntity> GetTEntities();
        //Thêm mới TEntity
        /// <summary>
        /// Thêm mới dữ liệu
        /// </summary>
        /// <param name="TEntity">object</param>
        /// <returns>Số lượng bản ghi được thêm</returns>
        /// createBy:NVTAM (19/2/2021)
        object Add(TEntity entity);
        int Update(TEntity entity);
    }
}
