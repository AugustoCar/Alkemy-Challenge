using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alkemy_Challenge.Models
{
    public class DisneyCharacterData
    {
        public string Nombre { get; set; }
        public string Historia { get; set; }
        public string Pelicula { get; set; }
        public int Edad { get; set; }
        public int Peso { get; set; }
    }

    public class CharacterDataList
    {
        public List<DisneyCharacterData> disneyCharacterDatas { get; set; } = null;
        public CharacterDataList()
        {
            disneyCharacterDatas = new List<DisneyCharacterData>();
            DisneyCharacterData cd = new DisneyCharacterData();
            cd.Nombre = "Tarzan";
            cd.Historia = "En este cuento animado de Disney, el huérfano Tarzán (Tony Goldwyn) crece en el remoto desierto africano, criado por el gentil gorila Kala (Glenn Close). Cuando una expedición británica entra en la jungla, Tarzán se encuentra con la hermosa Jane (Minnie Driver) y reconoce que, como ella, él es humano. Enamorado de Jane, Tarzán se debate entre abrazar la civilización y quedarse con su familia de gorilas, que se ve amenazada por el despiadado cazador Clayton (Brian Blessed).";
            cd.Pelicula = "";
            cd.Edad = 18;
            cd.Peso = 75;
            disneyCharacterDatas.Add(cd);

            cd = new DisneyCharacterData();
            cd.Nombre = "";
            cd.Historia = "En este cue";
            cd.Pelicula = "";
            cd.Edad = 34;
            cd.Peso = 34;
            disneyCharacterDatas.Add(cd);

            cd = new DisneyCharacterData();
            cd.Nombre = "";
            cd.Historia = "";
            cd.Pelicula = "";
            cd.Edad = 34;
            cd.Peso = 34;
            disneyCharacterDatas.Add(cd);
        }
    }
}