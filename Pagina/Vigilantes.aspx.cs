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
    public partial class Vigilantes : Page
    {

        private VigilanteController ctrl = new VigilanteController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridViewVigilantes.DataSource = ctrl.GetVgilantes();
                GridViewVigilantes.DataBind();
            }
        }

        protected void btnReg_ServerClick(object sender, EventArgs e)
        {
            txtIdVigilante.ReadOnly = false;
            txtIdVigilante.Text = "";
            txtNombreVigilante.Text = "";
            txtTelefonoVigilante.Text = "";
            txtCivil.Text = "";
            txtEstado.Text = "";
            txtGrupo.Text = "";
            txtResidencial.Text = "";
            txtPrecioHora.Text = "";
            txtExtraHora.Text = "";
            ScriptManager.RegisterStartupScript(this, GetType(), "Pop", "$('#popupVigilante').modal('show');", true);
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            VIGILANTE v = getSelectedItemfromButtom(sender);
            txtIdVigilante.ReadOnly = true;
            txtIdVigilante.Text = v.ID;
            txtNombreVigilante.Text = v.NOMBRE;
            txtTelefonoVigilante.Text = v.TELEFONO;
            txtCivil.Text = v.CIVIL;
            txtEstado.Text = v.ESTADO;
            txtGrupo.Text = v.GRUPO;
            txtResidencial.Text = v.RESIDENCIAL;
            txtPrecioHora.Text = v.PRECIOHORA.ToString();
            txtExtraHora.Text = v.EXTRAHORA.ToString();
            ScriptManager.RegisterStartupScript(this, GetType(), "Pop", "$('#popupVigilante').modal('show');", true);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            VIGILANTE v = getSelectedItemfromButtom(sender);
            ctrl.EliminarVigilante(v);
            //ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Elemento eliminado: Vigilante #" + v.ID + "');", true);
            Response.Redirect("Vigilantes.aspx");
        }

        protected void btnVigilante_Click(object sender, EventArgs e)
        {
            VIGILANTE obj = new VIGILANTE()
            {
                ID = txtIdVigilante.Text,
                NOMBRE = txtNombreVigilante.Text,
                TELEFONO = txtTelefonoVigilante.Text,
                CIVIL = txtCivil.Text,
                ESTADO = txtEstado.Text,
                GRUPO = txtGrupo.Text,
                RESIDENCIAL = txtResidencial.Text,
                PRECIOHORA = double.Parse(txtPrecioHora.Text),
                EXTRAHORA = double.Parse(txtExtraHora.Text),
                EXTRASTRABAJADAS = 0,
                HORASTRABAJADAS = 0
            };
            ctrl.RegistrarVigilante(obj);
            Response.Redirect("Vigilantes.aspx");
        }

        protected VIGILANTE getSelectedItemfromButtom(object sender)
        {
            Button btn = (Button)sender;
            GridViewRow rowview = (GridViewRow)btn.NamingContainer;
            string val = (string)GridViewVigilantes.DataKeys[rowview.RowIndex]["ID"];
            return ctrl.GetVigilante(val);
        }

        /*protected void GridViewVigilantes_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string estado = DataBinder.Eval(e.Row.DataItem, "ESTADO").ToString();         
                if (estado.Equals("Reserva")) e.Row.ForeColor= Color.Green;
                else if (!estado.Equals("Activo")) e.Row.ForeColor = Color.Red;
            }

        }*/


    }
}