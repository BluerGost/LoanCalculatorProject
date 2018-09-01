using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoanCalculatorProject
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            labelErrorMsg.Visible = false;
        }

        protected void btnInterestCal_Click(object sender, EventArgs e)
        {
            if (textLoanAmount.Text == "" || textNumberOfInstallment.Text == "" || textInterestRate.Text == "")//Empty Field
            {
                labelErrorMsg.Visible = true;
                labelErrorMsg.Text = "Loan Amount or Installment Number or Interest Rate Can't Be Empty";
            }
            else
            {
                double loanAmount = Convert.ToDouble(textLoanAmount.Text);

                //installment cant be in float
                int numberOfInstallment = Convert.ToInt32(textNumberOfInstallment.Text);
                double interestRate = Convert.ToDouble(textInterestRate.Text) / 100;
               

                if (loanAmount < 0 || numberOfInstallment < 0 || interestRate<0)//Negative Value
                {
                    labelErrorMsg.Visible = true;
                    labelErrorMsg.Text = "Loan Amount or Installment Number or Interest Rate Can't Be Negative";
                }
                else
                {
                    double totalInterest = loanAmount * numberOfInstallment * interestRate;
                    textTotalInterest.Text = Convert.ToString(totalInterest);
                }
            }
        }
    }
}