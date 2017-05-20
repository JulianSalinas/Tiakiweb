using Servicio.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Servicio
{
    public partial class Residenciales : Page
    {

        private ResidencialController ctrl = new ResidencialController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridViewResidenciales.DataSource = ctrl.GetResidenciales();
                GridViewResidenciales.DataBind();
            }
        }

        protected void btnReg_ServerClick(object sender, EventArgs e)
        {
            txtIdResidencial.ReadOnly = false;
            txtIdResidencial.Text = "";
            txtNombreResidencial.Text = "";
            txtDireccionResidencial.Text = "";
            ScriptManager.RegisterStartupScript(this, GetType(), "Pop", "$('#popupResidencial').modal('show');", true);
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            RESIDENCIAL r = getSelectedItemfromButtom(sender);
            txtIdResidencial.ReadOnly = true;
            txtIdResidencial.Text = r.ID;
            txtNombreResidencial.Text = r.NOMBRE;
            txtDireccionResidencial.Text = r.DIRECCION;
            ScriptManager.RegisterStartupScript(this, GetType(), "Pop", "$('#popupResidencial').modal('show');", true);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            RESIDENCIAL r = getSelectedItemfromButtom(sender);
            ctrl.EliminarResidencial(r);
            ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Elemento eliminado: Residencial #" + r.ID + "');", true);
            Response.Redirect("Residenciales.aspx");
        }

        protected void btnResidencial_Click(object sender, EventArgs e)
        {
            RESIDENCIAL obj = new RESIDENCIAL() {
                ID = txtIdResidencial.Text,
                NOMBRE = txtNombreResidencial.Text,
                DIRECCION = txtDireccionResidencial.Text
            };
            ctrl.RegistrarResidencial(obj);
            Response.Redirect("Residenciales.aspx");
        }

        protected RESIDENCIAL getSelectedItemfromButtom(object sender) {
            Button btn = (Button)sender;
            GridViewRow rowview = (GridViewRow)btn.NamingContainer;
            string val = (string)GridViewResidenciales.DataKeys[rowview.RowIndex]["ID"];
            return ctrl.GetResidencial(val);
        }

    }
}