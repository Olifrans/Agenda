using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agenda
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            String email = txbEmail.Text;
            String senha = txbSenha.Text;

            //captura a string de conexão
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");
            System.Configuration.ConnectionStringSettings connString;
            connString = rootWebConfig.ConnectionStrings.ConnectionStrings["ConnectionString"];

            //cria um objeto de conexão
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connString.ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from usuario where email = @email and senha = @senha";
            cmd.Parameters.AddWithValue("email", txbEmail.Text);
            cmd.Parameters.AddWithValue("senha", txbSenha.Text);
            con.Open();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                //cookies
                HttpCookie login = new HttpCookie("login", txbEmail.Text);
                Response.Cookies.Add(login);
               
                //Dedirecionar para a pagina inicial
                Response.Redirect("~/Index.aspx");
            }
            else
            {
                Response.Write("<script> alert('O e-mail ou a senha estão incorreto!!!');</script>");
                //lMsg.Text = "Email ou senha esta incorreto!!!";
            }
        }
    }
}