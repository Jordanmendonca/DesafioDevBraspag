using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesafioDevBraspag.Models
{
    public class Mdr
    {
        public string Adquirente { get; set; }
       

        public Mdr(string Adquirente)
        {
            this.Adquirente = Adquirente;
          
        }
    }
}