using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Alkemy_Challenge.Models;

namespace Alkemy_Challenge.Controllers
{
    public class CharacterDataController : ApiController
    {
        // GET: api/CharacterData
        public List<DisneyCharacterData> Get()
        {
            CharacterDataList cdLIst = new CharacterDataList();
            return cdLIst.disneyCharacterDatas;
        }

        // GET: api/CharacterData/5

        [HttpGet]
        [Route("get/nombre")]
        public DisneyCharacterData Get(string nombre)
        {
            DisneyCharacterData cdReturn = null;
            CharacterDataList cdLIst = new CharacterDataList();
            foreach (DisneyCharacterData cd in cdLIst.disneyCharacterDatas)
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
        [Route("get/pelicula")]
        public DisneyCharacterData GetPelicula(string pelicula)
        {
            DisneyCharacterData cdReturn = null;
            CharacterDataList cdLIst = new CharacterDataList();
            foreach (DisneyCharacterData cd in cdLIst.disneyCharacterDatas)
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
        [Route("get/edad")]
        public DisneyCharacterData Get(int edad)
        {
            DisneyCharacterData cdReturn = null;
            CharacterDataList cdLIst = new CharacterDataList();
            foreach (DisneyCharacterData cd in cdLIst.disneyCharacterDatas)
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
        [Route("get/peso")]
        public DisneyCharacterData GetPeso(int peso)
        {

            DisneyCharacterData cdReturn = null;
            CharacterDataList cdLIst = new CharacterDataList();
            foreach (DisneyCharacterData cd in cdLIst.disneyCharacterDatas)
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
        [Route("character")]
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

        // POST: api/CharacterData
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CharacterData/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CharacterData/5
        public void Delete(int id)
        {
        }
    }
}
