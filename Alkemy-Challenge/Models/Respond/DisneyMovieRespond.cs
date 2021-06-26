using Alkemy_Challenge.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alkemy_Challenge.Models.Respond
{
    public class DisneyMovieRespond
    {
        public string Imagen { get; set; }
        public string Titulo { get; set; }
        public string FechaCreacion { get; set; }
    }

    public class DisneyMovieRespondList
    {
        public List<DisneyMovieRespond> disneyMovieRespond { get; set; } = new List<DisneyMovieRespond>();

        public DisneyMovieRespondList()
        {
            disneyMovieRespond = new List<DisneyMovieRespond>();
            DisneyMovieRespond cd = null;

            disneyMovieRespond = new List<DisneyMovieRespond>();
            for (int i = 0; i < HomeController.disneyMovieData.Count; i++)
            {
                cd = new DisneyMovieRespond();
                cd.Imagen = HomeController.disneyMovieData[i].Imagen;
                cd.Titulo = HomeController.disneyMovieData[i].Titulo;
                cd.FechaCreacion = HomeController.disneyMovieData[i].FechaCreacion;
                disneyMovieRespond.Add(cd);
            }
        }
    }
}