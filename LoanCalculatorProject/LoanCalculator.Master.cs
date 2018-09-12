using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoanCalculatorProject
{
    public partial class LoanCalculator : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userName"] != null)//user logged in
            {
                linkToLogInOrOut.Text = "LogOut";
                linkToLogInOrOut.NavigateUrl = "logOutPage.aspx";
            }
            else//user not logged in
            {
                linkToLogInOrOut.Text = "LogIn";
                linkToLogInOrOut.NavigateUrl = "logInPage.aspx";
            }
        }
    }
}