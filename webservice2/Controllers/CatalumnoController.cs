using Microsoft.AspNetCore.Mvc;
using webservice2.DataAccess;
using webservice2.Models;

namespace webservice2.Controllers
{
    [Route("api/[controller]")]
    public class CatalumnoController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public CatalumnoController(IDataAccessProvider dataAccessProvider) {
        _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet]
        public IEnumerable<Catalumno> Get()
        {
            return _dataAccessProvider.GetAlumnos();
        }
    }
}
