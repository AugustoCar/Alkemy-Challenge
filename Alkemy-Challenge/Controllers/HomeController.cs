using Alkemy_Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alkemy_Challenge.Controllers
{
    public class HomeController : Controller
    {
        static public List<DisneyCharacterData> homeCdList = new List<DisneyCharacterData>();
        static public List<DisneyMovieData> disneyMovieData { get; set; } = new List<DisneyMovieData>();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            loadCharacters();
            loadMovies();
            
            return View();
        }
        public void loadCharacters()
        {
            DisneyCharacterData cd = new DisneyCharacterData();
            cd.Imagen = "https://img.ecartelera.com/noticias/fotos/54500/54576/1.jpg";
            cd.IdPelicula = new List<string>();
            cd.Nombre = "Tarzan";
            cd.Historia = "En este cuento animado de Disney, el huérfano Tarzán (Tony Goldwyn) crece en el remoto desierto africano, criado por el gentil gorila Kala (Glenn Close). Cuando una expedición británica entra en la jungla, Tarzán se encuentra con la hermosa Jane (Minnie Driver) y reconoce que, como ella, él es humano. Enamorado de Jane, Tarzán se debate entre abrazar la civilización y quedarse con su familia de gorilas, que se ve amenazada por el despiadado cazador Clayton (Brian Blessed).";
            cd.IdPelicula.Add("Tarzan");
            cd.IdPelicula.Add("Tarzan II");
            cd.Edad = 18;
            cd.Peso = 57;
            cd.Mensaje = "Ok";
            homeCdList.Add(cd);

            DisneyCharacterData cd1 = new DisneyCharacterData();
            cd1.Imagen = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQw9Ewu9_4ajND2QiTemeJzm9Mpi40SlnfN-_2AVkH9dPoYO-xu";
            cd1.IdPelicula = new List<string>();
            cd1.Nombre = "Lilo Pelekai";
            cd1.Historia = "Lilo is a seven-year-old girl living on the island of Kauai with her older sister, Nani. On a rainy night, Lilo and Nani's parents were killed in a car accident, leaving the two sisters orphaned. With Nani being of age by the time of the tragedy, she was dubbed Lilo's legal guardian.";
            cd1.IdPelicula.Add("Lilo & Stitch");
            cd1.Edad = 7;
            cd1.Peso = 23;
            cd1.Mensaje = "Ok";
            homeCdList.Add(cd1);

            DisneyCharacterData cd2 = new DisneyCharacterData();
            cd2.Imagen = "https://flxt.tmsimg.com/assets/p15972_p_v10_ab.jpg";
            cd2.IdPelicula = new List<string>();
            cd2.Nombre = "Snow White";
            cd2.Historia = "A princess by birth, Snow White’s mother died shortly after her birth. After some time, her father, the King, remarried a vain and cold-hearted queen. Not long after their marriage, Snow White's beloved father suspiciously died, leaving the young princess as an orphan.";
            cd2.IdPelicula.Add("Snow White and The Seven Dwarfs");
            cd2.Edad = 14;
            cd2.Peso = 47;
            cd2.Mensaje = "Ok";
            homeCdList.Add(cd2);
        }
        public void loadMovies()
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
            cd.Genero = "Accion";
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
            cd.Genero = "Aventura";
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
            cd.Genero = "Romance";
            disneyMovieData.Add(cd);
        }

    }
   


}
