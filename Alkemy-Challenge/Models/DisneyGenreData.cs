using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alkemy_Challenge.Models
{
    public class DisneyGenreData
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public List<string> Asociados { get; set; }
    }
}