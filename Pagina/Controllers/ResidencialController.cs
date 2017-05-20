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

        public RESIDENCIAL GetResidencial(string ID)
        {
            return (from r in linq.RESIDENCIAL
                    where r.ID == ID
                    select r).FirstOrDefault();
        }

        public List<RESIDENCIAL> GetResidenciales()
        {
            return (from r in linq.RESIDENCIAL
                    select r).ToList();
        }

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

        public void EliminarResidencial(RESIDENCIAL obj)
        {
            foreach (VIGILANTE vigilante in (
                from v in linq.VIGILANTE
                where v.RESIDENCIAL == obj.ID
                select v).ToList())
            {
                vigilante.RESIDENCIAL = null;
            }
            linq.RESIDENCIAL.DeleteOnSubmit(obj);
            linq.SubmitChanges();
        }

    }
}
