using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Servicio.Controllers
{
    public class DefaultController : ApiController
    {

        private LinqDataContext linq = new LinqDataContext();
        public static int ACTUAL = 0;
        public static int SIGUIENTE = 1;

        /* *
         * Toma la fecha y hora actual para obtener el grupo de los vigilantes
         * en guardia
         * */

        public GRUPO GetGrupoActual() {

            int dia = (int) DateTime.Now.DayOfWeek;
            int hora = DateTime.Now.Hour;

            return (from g in linq.GRUPO
                    where g.DIA == dia
                    && g.HINICIO <= hora
                    && hora <= (g.HINICIO + g.DURACION)
                    select g).FirstOrDefault();
        }

        /* *
         * Primero obtiene el grupo actual y con base a ese obtiene el grupo siguiente
         * */

        public GRUPO GetGrupoSiguiente() {

            GRUPO actual = GetGrupoActual();
            int horaFin = actual.HINICIO + (int) actual.DURACION;
            int dia = actual.DIA + (horaFin / 24);
            int hora = horaFin % 24;

            return ( from g in linq.GRUPO
                     where (g.DIA == dia)
                     && g.HINICIO == hora
                     && hora <= (g.HINICIO + g.DURACION)
                     select g).FirstOrDefault();
        }


        /* *
         * Obtiene todos los vigilantes activos en cierto horario
         * */

        public List<VIGILANTE> GetVigilantesGrupo(GRUPO grupo) {

            return (from vigilante in linq.VIGILANTE
                    where vigilante.GRUPO == grupo.ID
                    select vigilante).ToList();
        }

        /* *
         * Se obtiene los vigilantes de reserva para un residencial dado
         * */

        public List<VIGILANTE> GetVigilantesReserva(RESIDENCIAL residencial) {

            return (from vigilante in linq.VIGILANTE
                    where vigilante.RESIDENCIAL1.ID == residencial.ID
                    select vigilante).ToList();
        }

    }
}
