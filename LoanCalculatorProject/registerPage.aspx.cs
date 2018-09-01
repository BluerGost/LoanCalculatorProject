using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoanCalculatorProject
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            labelErrorMsg.Visible = false;
            labelSuccess.Visible = false;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (textUserName.Text == "" || textBalance.Text == "" || textFirstName.Text == "" || textLastName.Text == "" || textPassword.Text == "")//Empty Field
            {
                labelErrorMsg.Visible = true;
                labelErrorMsg.Text = "Username, Balance, First/Last Name and Password Can't Be Empty";
            }
            else
            {
                string userName = textUserName.Text;
                double balance = Convert.ToDouble(textBalance.Text);
                string firstName = textFirstName.Text;
                string lastName = textLastName.Text;
                string password = textPassword.Text;

            
                if (balance < 500)//Balance Cant be less than 500
                {
                    labelErrorMsg.Visible = true;
                    labelErrorMsg.Text = "Balance Can't Be less than 500";
                }
                else
                {
                    //insert into the database.
                    DataAccess objDA = new DataAccess();
                    if(objDA.registerUser(userName,balance,firstName,lastName,password)==-1)
                    {
                        labelErrorMsg.Visible = true;
                        labelErrorMsg.Text = "Failed To Create New Account!";
                    }
                    else
                    {
                        labelSuccess.Visible = true;
                        labelSuccess.Text = "Successfully Created New Account!";
                    }
                }
            }
        }
    }
}