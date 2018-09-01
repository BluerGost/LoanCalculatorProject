using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoanCalculatorProject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            textNewBalance.Text = "";
            labelErrorMsg.Visible = false;
            if (Session["balance"] != null)
            {
                textBalance.Text = Session["balance"].ToString();
            }
        }

        protected void btnTrnasfer_Click(object sender, EventArgs e)
        {
            if (textBalance.Text == "" || textTransferAmount.Text == "")//Empty Field
            {
                labelErrorMsg.Visible = true;
                labelErrorMsg.Text = "Balance or Transfer Amount Can't Be Empty";
            }
            else
            {
                double balance = Convert.ToDouble(textBalance.Text);
                double transferAmount = Convert.ToDouble(textTransferAmount.Text);
                if (balance < 0 || transferAmount < 0)//Negative Deposit Value
                {
                    labelErrorMsg.Visible = true;
                    labelErrorMsg.Text = "Balance or Transfer Amount Can't Be Negative";
                }
                else if(balance < transferAmount)
                {
                    labelErrorMsg.Visible = true;
                    labelErrorMsg.Text = "Not Enough Balance";
                }
                else
                {
                    double newBalance = balance - transferAmount;
                    textNewBalance.Text = Convert.ToString(newBalance);
                }
            }
        }
    }
}