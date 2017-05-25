using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicio.Controllers
{
    public class Estado
    {

        private GRUPO _grupo;
        private List<VIGILANTE> _vigilantes;

        public GRUPO Grupo
        {
            get
            {
                return _grupo;
            }

            set
            {
                _grupo = value;
            }
        }

        public List<VIGILANTE> Vigilantes
        {
            get
            {
                return _vigilantes;
            }

            set
            {
                _vigilantes = value;
            }
        }
    }
}