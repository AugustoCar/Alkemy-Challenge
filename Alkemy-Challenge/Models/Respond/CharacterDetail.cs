using Alkemy_Challenge.Controllers;
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
            CharacterDetail cd = null;

            characterDetail = new List<CharacterDetail>();
            for (int i = 0; i < HomeController.disneyMovieData.Count; i++)
            {
                cd = new CharacterDetail();
                cd.Imagen = HomeController.disneyMovieData[i].Imagen;
                cd.Titulo = HomeController.disneyMovieData[i].Titulo;
                cd.FechaCreacion = HomeController.disneyMovieData[i].FechaCreacion;
                cd.PersonajesAsociados = HomeController.disneyMovieData[i].Asociados;
                characterDetail.Add(cd);
            }
        }
    }
}