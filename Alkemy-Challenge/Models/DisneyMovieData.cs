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

    public class DisneyMovieDataList
    {

        public List<DisneyMovieData> disneyMovieData { get; set; } = new List<DisneyMovieData>();
        public DisneyMovieDataList()
        {
            disneyMovieData = new List<DisneyMovieData>();
            DisneyMovieData cd = new DisneyMovieData();
            DateTime Fecha = new DateTime(1999, 7, 8);
            cd.Imagen = "https://img.ecartelera.com/noticias/fotos/54500/54576/1.jpg";
            cd.Titulo = "Tarzan";
            cd.FechaCreacion = Fecha.Day + "/" + Fecha.Month + "/" + Fecha.Year;
            cd.Asociados = new List<string>();
            cd.Asociados.Add("Jane Porter");
            cd.Asociados.Add("Clayton");
            cd.Asociados.Add("Kerchak");
            cd.Calificacion = 5;
            disneyMovieData.Add(cd);

            cd = new DisneyMovieData();
            Fecha = new DateTime(2003, 8, 26);
            cd.Imagen = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQw9Ewu9_4ajND2QiTemeJzm9Mpi40SlnfN-_2AVkH9dPoYO-xu";
            cd.Titulo = "Lilo and Stitch";
            cd.FechaCreacion = Fecha.Day + "/" + Fecha.Month + "/" + Fecha.Year;
            cd.Asociados = new List<string>();
            cd.Asociados.Add("Nani Pelekai");
            cd.Asociados.Add("Jumba Jookiba");
            cd.Asociados.Add("Capitan Gantu");
            cd.Calificacion = 5;
            disneyMovieData.Add(cd);

            cd = new DisneyMovieData();
            Fecha = new DateTime(1993, 6, 11);
            cd.Imagen = "https://flxt.tmsimg.com/assets/p15972_p_v10_ab.jpg";
            cd.Titulo = "Snow White and The Seven Dwarfs";
            cd.FechaCreacion = Fecha.Day + "/" + Fecha.Month + "/" + Fecha.Year;
            cd.Asociados = new List<string>();
            cd.Asociados.Add("Dopey");
            cd.Asociados.Add("Bashful");
            cd.Asociados.Add("Sleepy");
            cd.Calificacion = 2;
            disneyMovieData.Add(cd);
        }
    }
}