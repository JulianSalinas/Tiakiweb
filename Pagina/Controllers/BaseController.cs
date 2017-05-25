using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Servicio.Controllers
{
    public abstract class BaseController : ApiController
    {
        protected static LinqDataContext linq = new LinqDataContext();
        public static int ACTUAL = 0;
        public static int SIGUIENTE = 1;
    }
}
