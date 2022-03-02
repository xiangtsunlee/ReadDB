using ReadDB.Models;
using ReadDB.Repository;

namespace ReadDB.Domain
{
    public class DataDomain
    {
        public async Task<IEnumerable<DataModel>> GetData()
        {
            DataRepository result = new DataRepository();
            return await result.GetData();
        }
    }
}
