using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alkemy_Challenge.Models.Respond
{
    public class CharacterDetail :DisneyMovieRespond
    {
        public List<string> PersonajesAsociados { get; set; }
    }

    public class CharacterDetailList
    {
        public List<CharacterDetail> characterDetail { get; set; } = new List<CharacterDetail>();

        public CharacterDetailList()
        {
            characterDetail = new List<CharacterDetail>();
            CharacterDetail cd = new CharacterDetail();
            DateTime Fecha = new DateTime(1999, 7, 8);
            cd.Imagen = "https://img.ecartelera.com/noticias/fotos/54500/54576/1.jpg";
            cd.Titulo = "Tarzan";
            cd.PersonajesAsociados = new List<string>();
            cd.PersonajesAsociados.Add("Jane Porter");
            cd.PersonajesAsociados.Add("Clayton");
            cd.PersonajesAsociados.Add("Kerchak");
            cd.FechaCreacion = Fecha.Day + "/" + Fecha.Month + "/" + Fecha.Year;
            characterDetail.Add(cd);

            cd = new CharacterDetail();
            Fecha = new DateTime(2003, 8, 26);
            cd.Imagen = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQw9Ewu9_4ajND2QiTemeJzm9Mpi40SlnfN-_2AVkH9dPoYO-xu";
            cd.Titulo = "Lilo and Stitch";
            cd.FechaCreacion = Fecha.Day + "/" + Fecha.Month + "/" + Fecha.Year;
            characterDetail.Add(cd);

            cd = new CharacterDetail();
            Fecha = new DateTime(1993, 6, 11);
            cd.Imagen = "https://flxt.tmsimg.com/assets/p15972_p_v10_ab.jpg";
            cd.Titulo = "Snow White and The Seven Dwarfs";
            cd.FechaCreacion = Fecha.Day + "/" + Fecha.Month + "/" + Fecha.Year;
            characterDetail.Add(cd);
        }
    }
}