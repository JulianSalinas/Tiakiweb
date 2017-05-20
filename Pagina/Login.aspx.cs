using System;
using System.Collections.Generic;
using System.Web.UI;

namespace Servicio
{
    public partial class Login : Page
    {

        private Dictionary<string, string> usuarios;

        /* *
         * Se agregan todos los posibles usuarios que puede usar la aplicación
         */

        protected void Page_Load(object sender, EventArgs e) {

            usuarios = new Dictionary<string, string>();
            usuarios.Add("admin1", "1234");
            usuarios.Add("admin2", "1234");
        }

        /* *
         * Se revisa que el usuario y la contraseña coincidan con alguno 
         * de los usuarios presentes
         * */

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try {
                if (usuarios[txtUsuario.Text] == txtPassword.Text)
                    Server.Transfer("Residenciales.aspx", true);
            }
            catch (Exception ex) {
                ClientScript.RegisterStartupScript(GetType(), "myalert", "alert('" + ex.Message + "');", true);
            }
        }


    }
    
}