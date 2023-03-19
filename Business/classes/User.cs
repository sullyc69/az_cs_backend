using Business.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.classes
{
    public class User :  IUser 
    {
       public string? name { get; set; }
       public string? userName { get; set; }
        public string? email_address { get;}
        public string? password { get; set; }
        public int userId { get; set; }
      
    }
}
