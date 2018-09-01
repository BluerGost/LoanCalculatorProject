using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoanCalculatorProject
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            labelErrorMsg.Visible = false;
            labelSuccess.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (textUserName.Text == "" || textPassword.Text == "")//Empty Field
            {
                labelErrorMsg.Visible = true;
                labelErrorMsg.Text = "Username and Password Can't Be Empty";
            }
            else
            {
                string userName = textUserName.Text;
                string password = textPassword.Text;

                //insert into the database.
                DataAccess objDA = new DataAccess();
                if (objDA.loginUser(userName, password) == false) 
                {
                    labelErrorMsg.Visible = true;
                    labelErrorMsg.Text = "Wrong Email or Password!";
                }
                else
                {             
                    if(Session["userName"] != null)
                    {
                        labelSuccess.Visible = true;
                        labelSuccess.Text = "Hi, " + Session["userName"] + " Welcome Back!";
                    }
                    else
                    {
                        labelErrorMsg.Visible = true;
                        labelErrorMsg.Text = "Session Variable Not Set";
                    }       
                }

            }
        }
    }
}