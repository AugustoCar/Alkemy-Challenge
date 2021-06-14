﻿using System;
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
        public DisneyCharacterData Get(string nombre)
        {
            DisneyCharacterData cdReturn = null;
            CharacterDataList cdLIst = new CharacterDataList();
            foreach(DisneyCharacterData cd in cdLIst.disneyCharacterDatas)
            {
                if(cd.Nombre == nombre)
                {
                    cdReturn = cd;
                    break;
                }
            }
            return cdReturn;
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
