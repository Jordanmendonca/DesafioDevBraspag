using DesafioDevBraspag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DesafioDevBraspag.Controllers
{
    public class mdrController : ApiController
    {

        private static List<Mdr> mdr = new List<Mdr>();

        public List<Mdr> Get()
        {
            Mdr Adquirinte = new Mdr("Adquirinte A");
            List<Mdr> lista = new List<Mdr>();
            lista.Add(Adquirinte);
            return lista;
        }

    }
}
