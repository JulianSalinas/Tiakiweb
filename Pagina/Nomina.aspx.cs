using Servicio.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Servicio
{
    public partial class Nomina : System.Web.UI.Page
    {
        private VigilanteController ctrl = new VigilanteController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnReset_ServerClick(object sender, EventArgs e)
        {
            ctrl.Reset();
            Response.Redirect("Nomina.aspx");
        }
    }
}