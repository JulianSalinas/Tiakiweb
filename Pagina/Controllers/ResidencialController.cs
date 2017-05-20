using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Servicio.Controllers
{
    public class ResidencialController : BaseController
    {

        /* *
         * Obtiene los detalles de un residencial
         * */

        public RESIDENCIAL GetResidenciale(string ID)
        {
          
            return (from r in linq.RESIDENCIAL
                    where r.ID == ID
                    select r).FirstOrDefault();

        }

        /* *
         * Obtiene todos los residenciales
         * */

        public List<RESIDENCIAL> GetResidenciales()
        {

            return (from r in linq.RESIDENCIAL
                    select r).ToList();

        }

        /* *
         * Registrar un nuevo residencial, si ya existe lo actualiza
         * */

        public void RegistrarResidencial(RESIDENCIAL obj)
        {

            var existente = (from cmp in linq.RESIDENCIAL
                             where obj.ID == cmp.ID
                             select cmp).FirstOrDefault();

            if (existente == null)
                linq.RESIDENCIAL.InsertOnSubmit(obj);

            else
            {
                existente.NOMBRE = obj.NOMBRE;
                existente.DIRECCION = obj.DIRECCION;
            }

            linq.SubmitChanges();
        }

        /* *
         * Elimina un residencial segun su id
         * */

        public void EliminarResidencial(string id)
        {
            RESIDENCIAL residencial = (
                from r in linq.RESIDENCIAL
                where r.ID == id
                select r).FirstOrDefault();

            foreach (VIGILANTE vigilante in (
                from v in linq.VIGILANTE
                where v.RESIDENCIAL == residencial.ID
                select v).ToList())
            {

                vigilante.RESIDENCIAL = null;
            }

            linq.SubmitChanges();
        }

    }
}
