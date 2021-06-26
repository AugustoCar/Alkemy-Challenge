using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Alkemy_Challenge.Models;
using Alkemy_Challenge.Models.Respond;
using Alkemy_Challenge.Models.Request;

namespace Alkemy_Challenge.Controllers
{
    public class MovieDataController : ApiController
    {

        public List<DisneyMovieData> cdLIst = new List<DisneyMovieData>();
        public MovieDataController()
        {
            cdLIst = HomeController.disneyMovieData;
        }


        [HttpGet]
        [Route("movies/name")]
        public DisneyMovieData Get(string nombre)
        {
            DisneyMovieData cdReturn = null;
            foreach (DisneyMovieData cd in cdLIst)
            {
                if (cd.Titulo == nombre)
                {
                    cdReturn = cd;
                    break;
                }
            }
            return cdReturn;
        }

        [HttpGet]
        [Route("movies/genre")]
        public List<DisneyMovieData> GetGenre(string genero)
        {
            List<DisneyMovieData> cdReturn = new List<DisneyMovieData>();
            foreach (DisneyMovieData cd in cdLIst)
            {
                if (cd.Genero == genero)
                {
                    cdReturn.Add(cd);
                }
            }
            return cdReturn;
        }

        [HttpGet]
        [Route("movies/order")]
        public List<DisneyMovieData> GetMovieByOrder(string order)
        {
            List<DisneyMovieData> cdList = new List<DisneyMovieData>();
            var ascendingOrder = cdLIst.OrderBy(i => i);
            var descendingOrder = cdLIst.OrderByDescending(i => i);

            if (cdLIst != null)
            {
                if (cdLIst.Count > 0)
                {
                    if (order == "ASC")
                    {
                        cdLIst = (List<DisneyMovieData>)ascendingOrder;
                    }
                    else if (order == "DESC")
                    {
                        cdLIst = (List<DisneyMovieData>)descendingOrder;
                    }
                }
            }
            return cdLIst;
        }

        [HttpGet]
        [Route("movies")]
        public List<DisneyMovieRespond> GetMovie()
        {
            DisneyMovieRespondList cdList = new DisneyMovieRespondList();
            if (cdList.disneyMovieRespond.Count > 0)
            {
                return cdList.disneyMovieRespond;
            }
            else
            {
                DisneyMovieRespond cdMovie = new DisneyMovieRespond();
                cdMovie.Mensaje = "Error";
                cdList.disneyMovieRespond.Add(cdMovie);
                return cdList.disneyMovieRespond;
            }

        }

        [HttpGet]
        [Route("moviesDetails")]
        public CharacterDetail GetMovieDetails(string titulo)
        {
            CharacterDetail cdReturn = null;
            CharacterDetailList cdLIst = new CharacterDetailList();
            foreach (CharacterDetail cd in cdLIst.characterDetail)
            {
                if (cd.Titulo == titulo)
                {
                    cdReturn = cd;
                    break;
                }
                else
                {
                    cdReturn = new CharacterDetail();
                    cdReturn.Mensaje = "Error";
                }
            }
            return cdReturn;

        }

        [HttpPost]
        [Route("movies/set")]
        public string Set(DisneyMovieData createMovie)
        {
            string Return = "";
            if (createMovie != null)
            {

                if (cdLIst.Count > 0 && !cdLIst.Contains(createMovie))
                {
                    cdLIst.Add(createMovie);
                    Return = "La pelicula " + createMovie.Titulo + " fue creada";
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
        [Route("movies/delete")]
        public string Delete(string nombre)
        {
            List<DisneyMovieData> cdDel = cdLIst;

            string Return = "";
            if (cdLIst.Count > 0)
            {

                for (int i = 0; i < cdDel.Count; i++)
                {
                    if (cdDel[i] != null)
                    {
                        if (cdDel[i].Titulo == nombre)
                        {
                            cdLIst.Remove(cdDel[i]);
                            Return = "La pelicula " + nombre + " fue eliminada";
                            i--;
                            break;
                        }
                        else
                        {
                            Return = "La pelicula no " + nombre + " fue eliminada";
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
        [Route("movies/edit")]
        public string EditByTitulo(EditRequest er)
        {
            List<DisneyMovieData> cdEdit = cdLIst;
            string Return = "";
            if (er.dmd != null && er.Titulo != "")
            {

                for (int i = 0; i < cdEdit.Count; i++)
                {
                    if (cdEdit[i] != null)
                    {
                        if (cdEdit[i].Titulo == er.Titulo)
                        {
                            cdEdit[i] = er.dmd;
                            Return = "La pelicula " + er.Titulo + " fue editada";
                            break;
                        }
                        else
                        {
                            Return = "No se encontro la pelicula solicitada";
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

