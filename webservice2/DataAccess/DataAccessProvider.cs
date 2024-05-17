using webservice2.Models;

namespace webservice2.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly MySqlContext _context;

        public DataAccessProvider(MySqlContext context)
        {
            _context = context;
        }
        public List<Catalumno> GetAlumnos()
        {
            return _context.Catalumno.ToList();
        }
    }
}
