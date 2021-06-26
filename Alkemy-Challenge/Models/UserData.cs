using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alkemy_Challenge.Models
{
    public class UserData
    {
        public string User { get; set; }
        public string Password { get; set; }
        public Random Token { get; set; }
    }


}