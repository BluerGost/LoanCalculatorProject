using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoanCalculatorProject
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bthLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("logInPage.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("registerPage.aspx");
        }

        protected void bthDeposit_Click(object sender, EventArgs e)
        {
            Response.Redirect("depositPage.aspx");
        }

        protected void bthTransfer_Click(object sender, EventArgs e)
        {
            Response.Redirect("transferPage.aspx");
        }

        protected void btnInterest_Click(object sender, EventArgs e)
        {
            Response.Redirect("interestPage.aspx");
        }

        protected void btnLoan_Click(object sender, EventArgs e)
        {
            Response.Redirect("loanPage.aspx");
        }
    }
}