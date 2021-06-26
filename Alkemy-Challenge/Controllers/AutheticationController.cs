using Alkemy_Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alkemy_Challenge.Controllers
{

    public class AutheticationController : Controller
    {
        //public List<UserData> logList = new List<UserData>();
        //public List<UserData> cdLIst = new List<UserData>();
        //protected static Random token = HomeController.random;

        //public AutheticationController()
        //{
        //    cdLIst = HomeController.userList;
        //    logList = HomeController.logUsers;          
        //}

        //public static string RandomString()
        //{
        //    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        //    return new string(Enumerable.Repeat(chars, 20)
        //    .Select(s => s[token.Next(s.Length)]).ToArray());
        //}

        //[HttpPost]
        //[Route("auth/login")]
        //public string Login(UserData userLogin)
        //{
        //    string Return = "";
        //    if (userLogin != null)
        //    {

        //        if (cdLIst.Count > 0 && cdLIst.Contains(userLogin))
        //        {
        //            userLogin.Token = token;
        //            logList.Add(userLogin);
        //            HomeController.tokenStorage.Add(userLogin.Token);
        //            Return = "Se ha ingresado correctamnete";
        //        }
        //        else
        //        {
        //            Return = "Usuario o contraseña incorrecta";
        //        }

        //    }
        //    else
        //    {
        //        Return = "No se han recibido datos";
        //    }

        //    return Return;
        //}



        //[HttpPost]
        //[Route("auth/register")]
        //public string Register(UserData userLogin)
        //{
        //    string Return = "";
        //    if (userLogin != null)
        //    {

        //        if (!cdLIst.Contains(userLogin))
        //        {
        //            cdLIst.Add(userLogin);
        //            userLogin.Token = token;
        //            logList.Add(userLogin);
        //            Return = "Se ha registrado correctamnete";
        //        }
        //        else
        //        {
        //            Return = "El usuario ya existe";
        //        }

        //    }
        //    else
        //    {
        //        Return = "No se han recibido datos";
        //    }

        //    return Return;
        //}
    }
}