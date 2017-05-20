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

        private DefaultController ctrl = new DefaultController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridViewResidenciales.DataSource = ctrl.GetResidenciales();
                GridViewResidenciales.DataBind();
            }
           
        }

        protected void btnAddResidencial_Click(object sender, EventArgs e)
        {
            RESIDENCIAL obj = new RESIDENCIAL() {
                ID = txtAddIdResidencial.Text,
                NOMBRE = txtAddNombreResidencial.Text,
                DIRECCION = txtAddDireccionResidencial.Text
            };
            ctrl.RegistrarResidencial(obj);
            Response.Redirect("Residenciales.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow rowview = (GridViewRow)btn.NamingContainer;
            string val = (string) GridViewResidenciales.DataKeys[rowview.RowIndex]["ID"];
            ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('Borrando+" + val+ "');", true);
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            txtAddDireccionResidencial.Text = "hola";
            ScriptManager.RegisterStartupScript(this, GetType(), "Pop", "$('#popupResidencial').modal('show');", true);         
        }

    }
}