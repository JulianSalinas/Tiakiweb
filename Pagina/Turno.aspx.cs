using Servicio.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Servicio
{
    public partial class Turno : Page
    {

        private static TurnoController ctrl = new TurnoController();

        private static VIGILANTE remplazado;
        private static bool siguiente = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
                BindActivos();
            
            
        }

        protected void btnTurnoSiguiente_ServerClick(object sender, EventArgs e)
        {
            if (btnSig.Text.Equals("Turno siguiente")) BindSiguientes();
            else BindActivos();
        }

        protected void btnRempl_Click(object sender, EventArgs e)
        {
            remplazado = getSelectedItemfromButton(sender);
            GridViewRemplazos.DataSource = ctrl.GetVigilantesReserva(remplazado);
            GridViewRemplazos.DataBind();
            txtVigilanteRemplazar.Text = "  >> " + remplazado.NOMBRE + " >> ID " + remplazado.ID;
            ScriptManager.RegisterStartupScript(this, GetType(), "Pop", "$('#popupTurno').modal('show');", true);
        }

        protected void btnElegir_Click(object sender, EventArgs e)
        {
            ctrl.RemplazarVigilantes(getSelectedItemfromButton(sender), remplazado);
            BindSiguientes();
        }

        protected VIGILANTE getSelectedItemfromButton(object sender)
        {
            Button btn = (Button)sender;
            GridViewRow rowview = (GridViewRow)btn.NamingContainer;
            string val = (string)((GridView)rowview.NamingContainer).DataKeys[rowview.RowIndex]["ID"];
            return ctrl.GetVigilante(val);
        }

        protected void BindSiguientes() {
            siguiente = true;
            GridViewTurno.Columns[3].Visible = true;
            GridViewTurno.Columns[4].Visible = true;
            btnSig.Text = "Turno actual";
            GridViewTurno.DataSource = ctrl.eSiguiente.Vigilantes;
            GridViewTurno.DataBind();
        }

        protected void BindActivos() {
            siguiente = false;
            GridViewTurno.Columns[3].Visible = false;
            GridViewTurno.Columns[4].Visible = false;
            btnSig.Text = "Turno siguiente";
            GridViewTurno.DataSource = ctrl.eActual.Vigilantes;
            GridViewTurno.DataBind();
        }

        protected void GridViewTurno_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && siguiente)
            {
                string es = e.Row.Cells[3].Text;
                if (!es.Equals("Activo") && !es.Equals("Inactivo")) e.Row.ForeColor = Color.Red;
                else
                {
                    if (es.Equals("Activo")) e.Row.Cells[3].Text = "Esperando turno";
                    Button btn = (Button)e.Row.FindControl("btnRempl");
                    btn.Visible = false;
                }
            }   
        }

        protected void btnSimular_Click(object sender, EventArgs e)
        {
            ctrl.Simular();
            BindActivos();
        }
    }
}