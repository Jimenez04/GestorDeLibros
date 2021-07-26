using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GestorDeLibros.UI.Models
{
    public class MockRepositorioDeLibros : IRepositoriodeLibros
    {
        public List<Libro> ObtenerTodo()
        {
            List<Libro> ListaDeLibros = new List<Libro>();

            ListaDeLibros.Add(new Libro
            {
                Nombre = "Programacion en JAVA",
                Autor = "Paul Deitel...",
                FechaPublicacion = "2016",
                Estado = "Disponible"
            });

            ListaDeLibros.Add(new Libro
            {
                Nombre = "Tecnologia",
                Autor = "Desconocido",
                FechaPublicacion = "Agosto de 2018",
                Estado = "Prestado"
            });

            ListaDeLibros.Add(new Libro
            {
                Nombre = "Los tres cerditos",
                Autor = "Jose Jimenez",
                FechaPublicacion = "Agosto de 2000",
                Estado = "Prestado"
            });

            return ListaDeLibros;
        }
    }
}
