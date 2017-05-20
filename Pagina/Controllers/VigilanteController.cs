using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Servicio.Controllers
{
    public class VigilanteController : BaseController
    {
        public VIGILANTE GetVigilante(string ID)
        {
            return (from r in linq.VIGILANTE
                    where r.ID == ID
                    select r).FirstOrDefault();
        }

        public List<VIGILANTE> GetVgilantes()
        {
            return (from r in linq.VIGILANTE
                    select r).ToList();
        }

        public void RegistrarVigilante(VIGILANTE obj)
        {
            var existente = (from cmp in linq.VIGILANTE
                             where obj.ID == cmp.ID
                             select cmp).FirstOrDefault();

            if (existente == null)
                linq.VIGILANTE.InsertOnSubmit(obj);

            else
            {
                existente.ID = obj.ID;
                existente.NOMBRE = obj.NOMBRE;
                existente.TELEFONO = obj.TELEFONO;
                existente.CIVIL = obj.CIVIL;
                existente.ESTADO = obj.ESTADO;
                existente.GRUPO = obj.GRUPO;
                existente.RESIDENCIAL = obj.RESIDENCIAL;
                existente.PRECIOHORA = obj.PRECIOHORA;
                existente.EXTRAHORA = obj.EXTRAHORA;
                existente.HORASTRABAJADAS = 0;
                existente.EXTRASTRABAJADAS = 0;
            }

            linq.SubmitChanges();
        }

        public void EliminarVigilante(VIGILANTE obj)
        {
            linq.VIGILANTE.DeleteOnSubmit(obj);
            linq.SubmitChanges();
        }

        public void Reset()
        {

            foreach (VIGILANTE v in (
                from vi in linq.VIGILANTE
                select vi))
            {
                v.HORASTRABAJADAS = 0;
                v.EXTRASTRABAJADAS = 0;
            }

            linq.SubmitChanges();
        }

    }
}
