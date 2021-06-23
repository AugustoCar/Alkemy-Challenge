using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alkemy_Challenge.Models
{
    public class DisneyCharacterData
    {
        public string Imagen { get; set; }
        public string Nombre { get; set; }
        public string Historia { get; set; }
        public List<string> IdPelicula { get; set; }
        public int Edad { get; set; }
        public int Peso { get; set; }
        public string Mensaje { get; set; }
    }

    public class CharacterDataList
    {
        public List<DisneyCharacterData> disneyCharacterDatas { get; set; } = null;
        public CharacterDataList()
        {
            disneyCharacterDatas = new List<DisneyCharacterData>();
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
            disneyCharacterDatas.Add(cd);

            cd = new DisneyCharacterData();
            cd.Imagen = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQw9Ewu9_4ajND2QiTemeJzm9Mpi40SlnfN-_2AVkH9dPoYO-xu";
            cd.IdPelicula = new List<string>();
            cd.Nombre = "Lilo Pelekai";
            cd.Historia = "Lilo is a seven-year-old girl living on the island of Kauai with her older sister, Nani. On a rainy night, Lilo and Nani's parents were killed in a car accident, leaving the two sisters orphaned. With Nani being of age by the time of the tragedy, she was dubbed Lilo's legal guardian.";
            cd.IdPelicula.Add("Lilo & Stitch");
            cd.Edad = 7;
            cd.Peso = 23;
            cd.Mensaje = "Ok";
            disneyCharacterDatas.Add(cd);

            cd = new DisneyCharacterData();
            cd.Imagen = "https://flxt.tmsimg.com/assets/p15972_p_v10_ab.jpg";
            cd.IdPelicula = new List<string>();
            cd.Nombre = "Snow White";
            cd.Historia = "A princess by birth, Snow White’s mother died shortly after her birth. After some time, her father, the King, remarried a vain and cold-hearted queen. Not long after their marriage, Snow White's beloved father suspiciously died, leaving the young princess as an orphan.";
            cd.IdPelicula.Add("Snow White and The Seven Dwarfs");
            cd.Edad = 14;
            cd.Peso = 47;
            cd.Mensaje = "Ok";
            disneyCharacterDatas.Add(cd);
        }
    }
}