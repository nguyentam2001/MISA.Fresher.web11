using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicationCore.Interfaces;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace Infrastructure
{
    public class BaseRepository<Tentity> : IBaseRepository<Tentity> 
    {
        //File cấu hình appsettings.json và đọc config với IConfiguration
        //Mặc định ASP.NET nạp cấu hình từ file JSON appsettings.json
        protected IConfiguration _configuration;
        //Khai báo chuỗi kết nối
        protected string _connectionstring = "DefaultConnection";
        //Khai báo kết nối MySQl
        protected IDbConnection _dbConnection;
        //Lấy tên của Entity
        string _tableName = "";
        //Khai báo tham số chuyền vào cho database
        protected DynamicParameters _dynamicParameters;
        public BaseRepository(IConfiguration configuration)
        {
            //Khỏi tạo đối tượng kết nối
            _configuration = configuration;
            _connectionstring = configuration.GetConnectionString("EducationConnectionString");
            _dbConnection=new MySqlConnection(_connectionstring);
            _tableName=typeof(Tentity).Name;
            //Khởi tạo nơi lưu chữ tham số chuyền vào cho database
            _dynamicParameters = new DynamicParameters();

        }
        public IEnumerable<Tentity> GetTEntities()
        {
            //Lấy danh sách entity
            var entities = _dbConnection.Query<Tentity>($"Proc_Get{_tableName}s",commandType:CommandType.StoredProcedure);
             return entities;
        }

        virtual public int Add(Tentity entity)
        {

            var rowAffects = _dbConnection.Execute($"Proc_Insert{_tableName}",entity,commandType: CommandType.StoredProcedure);
            return rowAffects;
        }

        public int Update(Tentity entity)
        {
           
            var rowsAffected = _dbConnection.Execute($"Proc_Update{_tableName}ByID", entity, commandType: CommandType.StoredProcedure);
            return rowsAffected;
        }
    }
}
