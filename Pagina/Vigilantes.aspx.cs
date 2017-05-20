using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Servicio
{
    public partial class Vigilantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridViewVigilantes_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string estado = DataBinder.Eval(e.Row.DataItem, "ESTADO").ToString();         
                if (estado.Equals("Reserva")) e.Row.ForeColor= Color.Green;
                else if (!estado.Equals("Activo")) e.Row.ForeColor = Color.Red;
            }

        }


    }
}