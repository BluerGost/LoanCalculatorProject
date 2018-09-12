using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoanCalculatorProject
{
    public partial class logOutPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccess obj = new DataAccess();

            obj.logOutUser();
            Response.Redirect("~/homePage.aspx");
        }
    }
}