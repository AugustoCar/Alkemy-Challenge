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
           
           
        }
    }
}