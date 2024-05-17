using System.Collections.Generic;
using webservice2.Models;

namespace webservice2.DataAccess
{
    /// <summary>
    /// Milagros Contreras
    /// 16/05/2024
    /// </summary>
    public interface IDataAccessProvider
    {
        List<Catalumno> GetAlumnos();
    }
}
