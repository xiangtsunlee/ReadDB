using System.Data.SqlClient;
using Dapper;
using ReadDB.Models;

namespace ReadDB.Repository
{
    public class DataRepository
    {
        public async Task<IEnumerable<DataModel>> GetData()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DBA-USYS;Initial Catalog=LionExAPI_developers;Persist Security Info=True;User ID=exapidev;Password=exapidev#621;Application Name=Lion.ExAPI.Utility.Hangfire.Core;"))
            {
                string sqlStr = @"SELECT api_projectname as ApiProjectName,
                                  COUNT(*) as ApiAmount
                                  FROM dbo.[ApiController] GROUP BY api_projectname";
                IEnumerable<DataModel>? GetDataResult = await conn.QueryAsync<DataModel>(sqlStr, commandTimeout: 30);
                return GetDataResult;
            }
        }
    }
    
}
