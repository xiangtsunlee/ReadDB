using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadDB.Domain;
using ReadDB.Models;
using ReadDB.Repository;

namespace ReadDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            DataDomain GetDataDomain = new DataDomain();
            IEnumerable<DataModel> result = await GetDataDomain.GetData();
            return Json(result);
        }
    }
    
    
}
