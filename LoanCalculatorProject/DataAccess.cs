using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace LoanCalculatorProject
{
    public class DataAccess: System.Web.UI.Page //So I can use session
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter da;//data adapter
        private DataSet ds;//data set
        public DataAccess()
        {
            conn = new SqlConnection();
            cmd = new SqlCommand();
            //Setting the Connection String From Web.config Page.
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connLoanCalculator"].ConnectionString;
            //Setting the SqlCommand Connection String to the Web.config Connection String.
            cmd.Connection = conn;

            //initialize dataset
            ds = new DataSet(); 
        }

        public int registerUser(string userName,double balance,string firstName,string lastName,string password)
        {
            cmd.CommandText = "INSERT INTO tblUser(userName,balance,firstName,lastName,password) VALUES( '" + userName + "'," + balance + ",'" + firstName + "','" + lastName + "','" + password + "')";
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        public bool loginUser(string userName, string password)
        {
            cmd.CommandText = "SELECT userName,balance,firstName,lastName FROM tblUser WHERE userName = '" + userName + "' AND password = '" + password + "'";
            da = new SqlDataAdapter();
            da.SelectCommand = this.cmd;
            conn.Open();
            da.Fill(ds, "tblUser");
            conn.Close();
            DataTable dt = ds.Tables["tblUser"];
            if (dt.Rows.Count>0)
            {
                Session["userName"] = dt.Rows[0]["userName"];
                Session["balance"] = dt.Rows[0]["balance"];
                Session["firstName"] = dt.Rows[0]["firstName"];
                Session["lastName"] = dt.Rows[0]["lastName"];
                return true;
            }
            else //didnt fetch any rows
            {
                return false;
            }
        }

        public bool logOutUser()
        {
            if(Session["userName"] != null  && Session["balance"] != null && Session["firstName"] != null && Session["lastName"] != null)
            {
                Session["userName"] = null;
                Session["balance"] = null;
                Session["firstName"] = null;
                Session["lastName"] = null;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}