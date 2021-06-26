using Alkemy_Challenge.Controllers;
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

        public DisneyCharacterRespondList()
        {

            DisneyCharacterRespond cd = null;

            disneyCharacterRespond = new List<DisneyCharacterRespond>();
            for(int i = 0; i < HomeController.homeCdList.Count; i++)
            {
                cd = new DisneyCharacterRespond();
                cd.Imagen = HomeController.homeCdList[i].Imagen;
                cd.Nombre = HomeController.homeCdList[i].Nombre;
                disneyCharacterRespond.Add(cd);
            }

        }
    }
}