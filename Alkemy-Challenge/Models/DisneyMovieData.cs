using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alkemy_Challenge.Models
{
    public class DisneyMovieData
    {
        public string Genero { get; set; }
        public string Imagen { get; set; }
        public string FechaCreacion { get; set; }
        public int Calificacion { get; set; }
        public List<string> Asociados { get; set; }
        public string Titulo { get; set; }
    }

}