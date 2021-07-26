using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorDeLibros.UI.Models
{
    public interface IRepositoriodeLibros
    {
        List<Libro> ObtenerTodo();
        

        
    }
}
