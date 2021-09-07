using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agenda
{
    public partial class usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected void SqlDataSourceUsuarios_Inserting(object sender, SqlDataSourceCommandEventArgs e)
        {
           
        }

        protected void SqlDataSourceUsuarios_Inserted(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null)
            {
                //IMsg.Text = e.Exception.Message;
                //IMsg.Text = "Erro, você esta inserindo um registro duplicado ou com campos em branco";
                Response.Write("<script> alert('Erro, você esta inserindo um registro duplicado ou com campos em branco!!!');</ script >");

                e.ExceptionHandled = true;
            }
        }


        protected void SqlDataSourceUsuarios_Updating(object sender, SqlDataSourceCommandEventArgs e)
        {

        }

        protected void SqlDataSourceUsuarios_Updated(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null)
            {
                //IMsg.Text = e.Exception.Message;
                IMsg.Text = "Erro, você esta alterando um registro duplicado ou com campos em branco";
                e.ExceptionHandled = true;
            }
        }


        protected void SqlDataSourceUsuarios_Deleting(object sender, SqlDataSourceCommandEventArgs e)
        {

        }

        protected void SqlDataSourceUsuarios_Deleted(object sender, SqlDataSourceStatusEventArgs e)
        {
            
        }

    }
}