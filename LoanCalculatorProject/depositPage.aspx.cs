using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoanCalculatorProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            textNewBalance.Text = "";
            labelErrorMsg.Visible = false;
            if(Session["balance"]!= null)
            {
                textBalance.Text = Session["balance"].ToString();
            }
        }

        protected void btnDeposit_Click(object sender, EventArgs e)
        {
            
            if (textBalance.Text == "" || textDepositAmount.Text == "")//Empty Field
            {
                labelErrorMsg.Visible = true;
                labelErrorMsg.Text = "Balance or Deposit Amount Can't Be Empty";
            }
            else
            {
                double balance = Convert.ToDouble(textBalance.Text);
                double depositAmount = Convert.ToDouble(textDepositAmount.Text);
                if (balance < 0 || depositAmount < 0)//Negative Deposit Value
                {
                    labelErrorMsg.Visible = true;
                    labelErrorMsg.Text = "Balance or Deposit Amount Can't Be Negative";
                }
                else
                {
                    double newBalance = balance + depositAmount;
                    textNewBalance.Text = Convert.ToString(newBalance);
                }
            }
        }
    }
}