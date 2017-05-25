using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Servicio.Controllers
{
    public class TurnoController : VigilanteController
    {

        public Estado eActual;
        public Estado eSiguiente;

        public TurnoController() {

            eActual = new Estado();
            eActual.Grupo = GetGrupoActual();
            eActual.Vigilantes = GetVigilantesActivos();

            eSiguiente = new Estado();
            eSiguiente.Grupo = GetGrupoSiguiente(eActual.Grupo);
            eSiguiente.Vigilantes = GetVigilantesSiguientes();

        }

        public void Simular() {

            eActual.Grupo = eSiguiente.Grupo;
            eActual.Vigilantes = eSiguiente.Vigilantes;

            eSiguiente = new Estado();
            eSiguiente.Grupo = GetGrupoSiguiente(eActual.Grupo);
            eSiguiente.Vigilantes = GetVigilantesSiguientes();

        }

        public List<VIGILANTE> GetVigilantesGrupo(GRUPO grupo) {
            return (from v in linq.VIGILANTE
                    where v.GRUPO == grupo.ID
                    select v).ToList();
        }

        public List<VIGILANTE> GetVigilantesReserva(VIGILANTE vigilante) {
            RESIDENCIAL residencial = vigilante.RESIDENCIAL1;
            return (from v in linq.VIGILANTE
                    where v.ESTADO == "Inactivo"
                    && v.RESIDENCIAL1.ID == residencial.ID
                    && v.GRUPO == "G"
                    select v).ToList();
        }

        public List<VIGILANTE> GetVigilantesActivos() {
            GRUPO grupo = eActual.Grupo;
            if (grupo == null) return new List<VIGILANTE>();
            return (from v in linq.VIGILANTE
                    where v.ESTADO != "Inactivo"
                    && (v.GRUPO == grupo.ID || v.GRUPO == "G")
                    select v).ToList();
        }

        public List<VIGILANTE> GetVigilantesSiguientes() {
            GRUPO grupo = eSiguiente.Grupo;
            if (grupo == null) return new List<VIGILANTE>();
            return (from v in linq.VIGILANTE
                    where v.ESTADO != "Inactivo" 
                    && (v.GRUPO == grupo.ID || v.GRUPO == "G")
                    select v).ToList();
        }

        public void RemplazarVigilantes(VIGILANTE remplazador, VIGILANTE remplazado)
        {
            remplazador.ESTADO = "Activo";
            remplazado.ESTADO = "Inactivo";
            eSiguiente.Vigilantes.Remove(remplazado);
            eSiguiente.Vigilantes.Add(remplazador);
        }

        public GRUPO GetGrupoActual()
        {
            int dia = (int)DateTime.Now.DayOfWeek;
            int hora = DateTime.Now.Hour;

            if (dia == 0)
            {

                if (0 <= hora && hora < 5)
                {
                    return new GRUPO()
                    {
                        DIA = 6,
                        DURACION = 6,
                        HINICIO = 23,
                        ID = "E"
                    };
                }

                if (5 <= hora && hora < 14)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 9,
                        HINICIO = 5,
                        ID = "C"
                    };
                }

                if (14 <= hora && hora < 23)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 9,
                        HINICIO = 23,
                        ID = "D"
                    };
                }

                if (23 == hora)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 6,
                        HINICIO = 23,
                        ID = "E"
                    };
                }

            }

            if (dia == 1)
            {
                if (0 <= hora && hora < 5)
                {
                    return new GRUPO()
                    {
                        DIA = 0,
                        DURACION = 6,
                        HINICIO = 23,
                        ID = "E"
                    };
                }

                if (5 <= hora && hora < 14)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 9,
                        HINICIO = 5,
                        ID = "A"
                    };
                }

                if (14 <= hora && hora < 23)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 9,
                        HINICIO = 14,
                        ID = "B"
                    };
                }

                if (23 == hora)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 6,
                        HINICIO = 23,
                        ID = "F"
                    };
                }

            }

            if (dia == 2)
            {
                if (0 <= hora && hora < 5)
                {
                    return new GRUPO()
                    {
                        DIA = 1,
                        DURACION = 6,
                        HINICIO = 23,
                        ID = "F"
                    };
                }

                if (5 <= hora && hora < 14)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 9,
                        HINICIO = 5,
                        ID = "A"
                    };
                }

                if (14 <= hora && hora < 23)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 9,
                        HINICIO = 14,
                        ID = "B"
                    };
                }

                if (23 == hora)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 6,
                        HINICIO = 23,
                        ID = "F"
                    };
                }
            }

            if (dia == 3)
            {
                if (0 <= hora && hora < 5)
                {
                    return new GRUPO()
                    {
                        DIA = 2,
                        DURACION = 6,
                        HINICIO = 23,
                        ID = "F"
                    };
                }

                if (5 <= hora && hora < 14)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 9,
                        HINICIO = 5,
                        ID = "A"
                    };
                }

                if (14 <= hora && hora < 23)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 9,
                        HINICIO = 14,
                        ID = "B"
                    };
                }

                if (23 == hora)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 6,
                        HINICIO = 23,
                        ID = "F"
                    };
                }
            }

            if (dia == 4)
            {
                if (0 <= hora && hora < 5)
                {
                    return new GRUPO()
                    {
                        DIA = 3,
                        DURACION = 6,
                        HINICIO = 23,
                        ID = "F"
                    };
                }

                if (5 <= hora && hora < 14)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 9,
                        HINICIO = 5,
                        ID = "A"
                    };
                }

                if (14 <= hora && hora < 23)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 9,
                        HINICIO = 14,
                        ID = "B"
                    };
                }

                if (23 == hora)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 6,
                        HINICIO = 23,
                        ID = "F"
                    };
                }
            }

            if (dia == 5)
            {
                if (0 <= hora && hora < 5)
                {
                    return new GRUPO()
                    {
                        DIA = 4,
                        DURACION = 6,
                        HINICIO = 23,
                        ID = "F"
                    };
                }

                if (5 <= hora && hora < 14)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 9,
                        HINICIO = 5,
                        ID = "A"
                    };
                }

                if (14 <= hora && hora < 23)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 9,
                        HINICIO = 14,
                        ID = "B"
                    };
                }

                if (23 == hora)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 6,
                        HINICIO = 23,
                        ID = "E"
                    };
                }
            }

            if (dia == 6)
            {
                if (0 <= hora && hora < 5)
                {
                    return new GRUPO()
                    {
                        DIA = 5,
                        DURACION = 6,
                        HINICIO = 23,
                        ID = "E"
                    };
                }

                if (5 <= hora && hora < 14)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 9,
                        HINICIO = 5,
                        ID = "C"
                    };
                }

                if (14 <= hora && hora < 23)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 9,
                        HINICIO = 14,
                        ID = "D"
                    };
                }

                if (23 == hora)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 6,
                        HINICIO = 23,
                        ID = "E"
                    };
                }

            }
            return null;
        }

        /**
         * GRupo siguiente */

        public GRUPO GetGrupoSiguiente(GRUPO grupo)
        {
            string id = grupo.ID;
            int dia = grupo.DIA;
            int hora = grupo.HINICIO;

            if (id.Equals("A"))
            {
                return new GRUPO()
                {
                    DIA = dia,
                    DURACION = 9,
                    HINICIO = 14,
                    ID = "B"
                };
            }
            if (id.Equals("B"))
            {
                if (dia == 1 || dia == 2 || dia == 3 || dia == 4)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 6,
                        HINICIO = 23,
                        ID = "F"
                    };
                }
                if (dia == 5)
                {
                    return new GRUPO()
                    {
                        DIA = dia,
                        DURACION = 6,
                        HINICIO = 23,
                        ID = "E"
                    };
                }
            }
            if (id.Equals("C"))
            {
                return new GRUPO()
                {
                    DIA = dia,
                    DURACION = 9,
                    HINICIO = 14,
                    ID = "D"
                };

            }
            if (id.Equals("D"))
            {
                return new GRUPO()
                {
                    DIA = dia,
                    DURACION = 6,
                    HINICIO = 23,
                    ID = "E"
                };
            }
            if (id.Equals("E"))
            {
                if (dia == 0)
                {
                    return new GRUPO()
                    {
                        DIA = 1,
                        DURACION = 9,
                        HINICIO = 5,
                        ID = "A"
                    };
                }
                if (dia == 5)
                {
                    return new GRUPO()
                    {
                        DIA = 6,
                        DURACION = 9,
                        HINICIO = 5,
                        ID = "C"
                    };
                }
                if (dia == 6)
                {
                    return new GRUPO()
                    {
                        DIA = 0,
                        DURACION = 9,
                        HINICIO = 5,
                        ID = "C"
                    };
                }

            }
            if (id.Equals("F"))
            {
                return new GRUPO()
                {
                    DIA = dia + 1,
                    DURACION = 6,
                    HINICIO = 23,
                    ID = "A"
                };
            }
            return null;
        }

    }
}
