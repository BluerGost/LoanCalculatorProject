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

        public void hideControls()
        {
            labelUserName.Visible = false;
            labelPassword.Visible = false;
            textUserName.Visible = false;
            textPassword.Visible = false;
            btnLogin.Visible = false;
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
                        hideControls();
                        labelSuccess.Visible = true;
                        labelSuccess.Text = "Hi, " + Session["userName"] + " Welcome Back!. Redirecting, Please Wait .....";

                        //Using Javascript to redirect to homePage after 3 seconds. setTimeout executes a function after a specified time, here 3000=3sec.
                        Response.Write("<script>setTimeout(function(){ window.location = 'homePage.aspx'; }, 3000)</script>");
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