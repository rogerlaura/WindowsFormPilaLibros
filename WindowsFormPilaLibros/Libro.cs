using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormPilaLibros
{
    internal class Libro
    {
        private int id;
        private string titulo;
        private string autor;
        private int cantidadpagina;

        public int Id { set; get; }
        public string Titulo { set; get; }
        public string Autor { set; get; }

        public int Cantidadpagina { set; get; }
    }
}
