using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alkemy_Challenge.Models
{
    public class DisneyCharacterRespond
    {
        public string Imagen { get; set; }
        public string Nombre { get; set; }
    }

    public class DisneyCharacterRespondList
    {
        public List<DisneyCharacterRespond> disneyCharacterRespond { get; set; } = new List<DisneyCharacterRespond>();

        public void CharacterRespondList()
        {
            disneyCharacterRespond = new List<DisneyCharacterRespond>();
            DisneyCharacterRespond cd = new DisneyCharacterRespond();
            cd.Imagen = "https://img.ecartelera.com/noticias/fotos/54500/54576/1.jpg";
            cd.Nombre = "Tarzan";
            disneyCharacterRespond.Add(cd);

            cd = new DisneyCharacterRespond();
            cd.Imagen = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQw9Ewu9_4ajND2QiTemeJzm9Mpi40SlnfN-_2AVkH9dPoYO-xu";
            cd.Nombre = "Lilo Pelekai";
            disneyCharacterRespond.Add(cd);

            cd = new DisneyCharacterRespond();
            cd.Imagen = "https://flxt.tmsimg.com/assets/p15972_p_v10_ab.jpg";
            cd.Nombre = "Snow White";
            disneyCharacterRespond.Add(cd);
        }
    }
}