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
         * Obtiene todos los residenciales
         * */

        public List<RESIDENCIAL> GetResidenciales() {

            return (from r in linq.RESIDENCIAL
                    select r).ToList();

        }

        /* *
         * Registrar un nuevo residencial, si ya existe lo actualiza
         * */

        public void RegistrarResidencial(RESIDENCIAL obj) {

            var existente = (from cmp in linq.RESIDENCIAL
                             where obj.ID == cmp.ID
                             select cmp).FirstOrDefault();

            if (existente == null)
                linq.RESIDENCIAL.InsertOnSubmit(obj);

            else {
                existente.NOMBRE = obj.NOMBRE;
                existente.DIRECCION = obj.DIRECCION;
            }

            linq.SubmitChanges();
        }

        /* *
         * Elimina un residencial segun su id
         * */

        public void EliminarResidencial(string id) {

            RESIDENCIAL residencial = (
                from r in linq.RESIDENCIAL
                where r.ID == id
                select r).FirstOrDefault();

            foreach( VIGILANTE vigilante in (
                from v in linq.VIGILANTE
                where v.RESIDENCIAL == residencial.ID
                select v).ToList()) {

                vigilante.RESIDENCIAL = null;
            }

            linq.SubmitChanges();
        }

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
         * Obtiene todos los vigilantes existentes
         * */

        public List<VIGILANTE> GetVigilantes() {

            return (from vigilante in linq.VIGILANTE
                    select vigilante).ToList();

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

        /* *
         * Registrar un nuevo vigilante, si ya existe lo actualiza
         * */

        public void RegistrarVigilante(VIGILANTE obj) {

            var existente = (from cmp in linq.VIGILANTE
                             where obj.ID == cmp.ID
                             select cmp).FirstOrDefault();

            if (existente == null)
                linq.VIGILANTE.InsertOnSubmit(obj);

            else
            {
                existente.ID = obj.ID;
                existente.NOMBRE = obj.NOMBRE;
                existente.CIVIL = obj.CIVIL;
                existente.ESTADO = obj.ESTADO;
                existente.GRUPO = obj.GRUPO;
                existente.TELEFONO = obj.TELEFONO;
                existente.RESIDENCIAL = obj.RESIDENCIAL;
                existente.EXTRAHORA = obj.EXTRAHORA;
                existente.PRECIOHORA = obj.PRECIOHORA;
            }

            linq.SubmitChanges();
        }

        /* *
         * Elimina un vigilante segun su id
         * */

        public void EliminarVigilante(string id){

            linq.VIGILANTE.DeleteOnSubmit(
                (from vigilante in linq.VIGILANTE
                 where vigilante.ID == id
                 select vigilante).FirstOrDefault());
            linq.SubmitChanges();

        }

    }
}
