using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Alkemy_Challenge.Models;
using Alkemy_Challenge.Models.Request;
using Alkemy_Challenge.Models.Respond;

namespace Alkemy_Challenge.Controllers
{
    public class CharacterDataController : ApiController
    {

        public List<DisneyCharacterData> cdLIst = new List<DisneyCharacterData>();
        public CharacterDataController()
        {
            cdLIst = HomeController.homeCdList;
        }

        // GET: api/CharacterData
        [HttpGet]
        [Route("get")]
        public List<DisneyCharacterData> Get()
        {
            return cdLIst;
        }

        // GET: api/CharacterData/5

        [HttpGet]
        [Route("characters/nombre")]
        public DisneyCharacterData Get(string nombre)
        {
            DisneyCharacterData cdReturn = null;
            foreach (DisneyCharacterData cd in cdLIst)
            {
                if (cd.Nombre == nombre)
                {
                    cdReturn = cd;
                    break;
                }
                else
                {
                    cdReturn = new DisneyCharacterData();
                    cdReturn.Mensaje = "Error";
                }
            }
            return cdReturn;
        }

        [HttpGet]
        [Route("characters/pelicula")]
        public DisneyCharacterData GetPelicula(string pelicula)
        {
            DisneyCharacterData cdReturn = null;
            foreach (DisneyCharacterData cd in cdLIst)
            {
                if (cd.IdPelicula.Contains(pelicula))
                {
                    cdReturn = cd;
                    break;
                }
                else
                {
                    cdReturn = new DisneyCharacterData();
                    cdReturn.Mensaje = "Error";
                }
            }
            return cdReturn;
        }

        [HttpGet]
        [Route("characters/edad")]
        public DisneyCharacterData Get(int edad)
        {
            DisneyCharacterData cdReturn = null;
            foreach (DisneyCharacterData cd in cdLIst)
            {
                if (cd.Edad == edad)
                {
                    cdReturn = cd;
                    break;
                }
                 else 
                {   
                    cdReturn = new DisneyCharacterData(); 
                    cdReturn.Mensaje = "Error"; 
                }
            }       
            return cdReturn;
        }

        [HttpGet]
        [Route("characters/peso")]
        public DisneyCharacterData GetPeso(int peso)
        {

            DisneyCharacterData cdReturn = null;
            foreach (DisneyCharacterData cd in cdLIst)
            {
                if (cd.Peso == peso)
                {
                    cdReturn = cd;
                    break;
                }
                else
                {
                    cdReturn = new DisneyCharacterData();
                    cdReturn.Mensaje = "Error";
                }
            }
            return cdReturn;

        }

        [HttpGet]
        [Route("characters")]
        public List<DisneyCharacterRespond> GetCharacter()
        {
            DisneyCharacterRespondList cdList = new DisneyCharacterRespondList();
            if (cdList.disneyCharacterRespond.Count > 0)
            {               
                return cdList.disneyCharacterRespond;
            }
            else
            {
                DisneyCharacterRespond cdCharacter = new DisneyCharacterRespond();
                cdList.disneyCharacterRespond.Add(cdCharacter);
                return cdList.disneyCharacterRespond;
            }
    
        }

        [HttpPost]
        [Route("characters/set")]
        public string Set(DisneyCharacterData createCharacter)
        {
            string Return = "";
            if (createCharacter != null)
            {

                if (cdLIst.Count > 0 && !cdLIst.Contains(createCharacter))
                {
                    cdLIst.Add(createCharacter);
                    Return = "El personaje " + createCharacter.Nombre + " fue creado";
                }
                else
                {
                    Return = "Error";
                }

            }
            else
            {
                Return = "Error";
            }

            return Return;
        }

        [HttpPost]
        [Route("characters/delete")]
        public string Delete(string nombre)
        {
            List<DisneyCharacterData> cdDel = cdLIst;

            string Return = "";
            if (cdLIst.Count > 0)
            {

                for (int i = 0; i < cdDel.Count; i++)
                {
                    if(cdDel[i] != null)
                    {
                        if (cdDel[i].Nombre == nombre)
                        {
                            cdLIst.Remove(cdDel[i]);
                            Return = "El personaje " + nombre + " fue eliminado";
                            i--;
                            break;
                        }
                        else
                        {
                            Return = "El personaje no " + nombre + " fue eliminado";
                        }
                    }
                    else
                    {
                        Return = "Error";
                    }
                }
               
            }
            return Return;
        }
        [HttpPost]
        [Route("characters/edit")]
        public string EditByTitulo(EditCharacter er)
        {
            List<DisneyCharacterData> cdEdit = cdLIst;
            string Return = "";
            if (er.dmd != null && er.Titulo != "")
            {

                for (int i = 0; i < cdEdit.Count; i++)
                {
                    if (cdEdit[i] != null)
                    {
                        if (cdEdit[i].Nombre == er.Titulo)
                        {
                            cdEdit[i] = er.dmd;
                            Return = "El personaje " + er.Titulo + " fue editado";
                            break;
                        }
                        else
                        {
                            Return = "No se encontro el personaje solicitado";
                        }
                    }
                    else
                    {
                        Return = "Error";
                    }
                }
            }
            else
            {
                Return = "Error";
            }

            return Return;
        }
    }

}
