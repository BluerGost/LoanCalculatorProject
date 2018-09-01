using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoanCalculatorProject
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            textNumberOfPayment.Text = "";
            labelErrorMsg.Visible = false;
        }

        protected void btnNumOfPayment_Click(object sender, EventArgs e)
        {
            if (textLoanAmount.Text == "" || textPaymentPerInstallment.Text == "")//Empty Field
            {
                labelErrorMsg.Visible = true;
                labelErrorMsg.Text = "Loan Amount or Payment Per Installment Can't Be Empty";
            }
            else
            {
                double loanAmount = Convert.ToDouble(textLoanAmount.Text);
                double paymentPerInstallment = Convert.ToDouble(textPaymentPerInstallment.Text);
                if (loanAmount <= 0 || paymentPerInstallment <= 0)//Negative Deposit Value
                {
                    labelErrorMsg.Visible = true;
                    labelErrorMsg.Text = "Loan Amount or Payment Per Installment Can't Be Negative or Zero";
                }
                else if (loanAmount < paymentPerInstallment)
                {
                    labelErrorMsg.Visible = true;
                    labelErrorMsg.Text = "Loan Amount Must Be  More than Per Installment Payment Amount";
                }
                else
                {
                    double numberOfPayment = loanAmount/paymentPerInstallment;
                    textNumberOfPayment.Text = Convert.ToString(numberOfPayment);
                }
            }
        }
    }
}