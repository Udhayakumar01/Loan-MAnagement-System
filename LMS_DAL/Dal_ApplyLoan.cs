using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LMS_ENTITY;
using LMS_EXCEPTION;

namespace LMS_DAL
{
    /// <summary>
    /// DATA ACCESS LAYER FOR LOAN APPLICATION
    /// </summary>
    public class Dal_ApplyLoan
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader sdr = null;
        ApplyLoan applyLoan = null;
        Customer customer = null;
        public Dal_ApplyLoan()
        {
            applyLoan = new ApplyLoan();
            customer = new Customer();
            con = new SqlConnection();
            con.ConnectionString = @"Server = DESKTOP-MBKK1D2\CAPG; Integrated Security = true; Database = LMS_DB";
        }
        public Dal_ApplyLoan(ApplyLoan applyLoanObj)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Server = DESKTOP-MBKK1D2\CAPG; Integrated Security = true; Database = LMS_DB";
            applyLoan = applyLoanObj;
        }
        public Dal_ApplyLoan(Customer customerObj)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Server = DESKTOP-MBKK1D2\CAPG; Integrated Security = true; Database = LMS_DB";
            customer = customerObj;
        }

        //METHOD TO UPDATE CUSTOMER 
        #region Update Customer
        public bool UpdateCustomer(int Id)
        {
            try
            {

                SqlParameter p1, p2, p3, p4, p5, p6, p7, p8, p9, p10;

                p1 = new SqlParameter("@cust_id", Id);
                p2 = new SqlParameter("@FIRST_NAME", customer.FIRST_NAME);
                p3 = new SqlParameter("@LAST_NAME", customer.LAST_NAME);
                p4 = new SqlParameter("@ADDRESS", customer.ADDRESS);
                p5 = new SqlParameter("@PAN_NUMBER", customer.PAN_NUMBER);
                p6 = new SqlParameter("@AADHAR_NUMBER", customer.AADHAR_NUMBER);
                p7 = new SqlParameter("@CONTACT_NUMBER", customer.CONTACT_NUMBER);
                p8 = new SqlParameter("@DOB", customer.DOB);
                p9 = new SqlParameter("@CREDIT_LIMIT", customer.CREDIT_LIMIT);
                p10 = new SqlParameter("@LAST_UPDATED_CREDIT_DATE", customer.LAST_UPDATED_CREDIT_DATE);


                cmd = new SqlCommand();
                cmd.CommandText = "usp_UpdateCustomerDetails";
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Connection = con;
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);
                cmd.Parameters.Add(p9);
                cmd.Parameters.Add(p10);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(SqlException SE)
            {
                System.Windows.Forms.MessageBox.Show(SE.Message);
            }
            catch (Exception EX)
            {
                System.Windows.Forms.MessageBox.Show(EX.Message);
            }
            return true;
        }
        #endregion

        //METHOD TO VIEW CUSTOMER DETAILS
        #region View Customer Details
        public Customer ViewCustomerDetails(int Id)
        {
            Customer p1 = new Customer();
            try
            {
                con.Open();
                SqlParameter p;
                p = new SqlParameter("@cust_id", Id);

                cmd = new SqlCommand();
                cmd.CommandText = "usp_ViewCustomerDetails";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                cmd.Parameters.Add(p);
                sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr != null)
                {
                    p1.CUSTOMER_ID = Int32.Parse(sdr[0].ToString());
                    p1.FIRST_NAME = sdr[1].ToString();
                    p1.LAST_NAME = sdr[2].ToString();
                    p1.ADDRESS = sdr[3].ToString();
                    p1.PAN_NUMBER = sdr[4].ToString();
                    p1.AADHAR_NUMBER = long.Parse(sdr[5].ToString());
                    p1.CONTACT_NUMBER = long.Parse(sdr[6].ToString());
                    p1.EMAIL = sdr[7].ToString();
                    p1.DOB = DateTime.Parse(sdr[8].ToString());
                    p1.CREDIT_LIMIT = Int32.Parse(sdr[9].ToString());
                    p1.LAST_UPDATED_CREDIT_DATE = DateTime.Parse(sdr[10].ToString());

                }
                con.Close();
            }
            catch (SqlException SE)
            {
                System.Windows.Forms.MessageBox.Show(SE.Message);
            }
            catch (Exception EX)
            {
                System.Windows.Forms.MessageBox.Show(EX.Message);
            }

            return p1;
        }
        #endregion

        //METHOD TO APPLY LOAN APPLICATION
        #region Apply Loan Application
        public bool ApplyLoanApplication()
        {
            try
            {
                con.Open();
                SqlParameter p1, p2, p3, p4;
                p1 = new SqlParameter("@CUSTOMER_ID", applyLoan.CUSTOMER_ID);
                p2 = new SqlParameter("@LoanAmount", applyLoan.LOAN_AMOUNT);
                p3 = new SqlParameter("@LoanType", applyLoan.LOAN_TYPE);
                p4 = new SqlParameter("@Tenure", applyLoan.TENURE);
                cmd = new SqlCommand();
                cmd.CommandText = "usp_InsertApplyLoan";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException SE)
            {
                System.Windows.Forms.MessageBox.Show(SE.Message);
            }
            catch (Exception EX)
            {
                System.Windows.Forms.MessageBox.Show(EX.Message);
            }
             return true;
        }
        #endregion

        //METHOD TO VIEW LOAN STATUS
        #region View Loan Status
        public ApplyLoan ViewLoanStatus(int Id)
        {
            ApplyLoan p1 = new ApplyLoan();
            try
            {
                con.Open();
                SqlParameter p;
                p = new SqlParameter("@cust_id", Id);

                cmd = new SqlCommand();
                cmd.CommandText = "usp_ViewLoanStatus";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                cmd.Parameters.Add(p);
                sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr != null)
                {
                    p1.CUSTOMER_ID = Int32.Parse(sdr[0].ToString());
                    p1.LOAN_AMOUNT = Int32.Parse(sdr[1].ToString());
                    p1.LOAN_TYPE = sdr[2].ToString();
                    p1.TENURE = Int32.Parse(sdr[3].ToString());
                    p1.STATUS_TYPE = sdr[4].ToString();
                    con.Close();
                    p1.CUSTOMER_NAME = GetCustomerName(p1.CUSTOMER_ID);
                    p1.CREDIT_LIMIT = GetCreditLimit(p1.CUSTOMER_ID);
                }
            }
            catch(SqlException SE)
            {
                System.Windows.Forms.MessageBox.Show(SE.Message);
            }

            catch (Exception EX)
            {
                System.Windows.Forms.MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }

            return p1;
        }
        #endregion

        //METHOD TO GET CUSTOMER NAME
        #region GetCustomerName
        public string GetCustomerName(int Id)
        {
            string Customer_Name = null;
            string First_Name = null;
            string Last_Name = null;
            try
            {
                con.Open();
                SqlParameter P1 = new SqlParameter("@cust_id", Id);
                cmd = new SqlCommand("usp_GetCustomerFirstName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(P1);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    First_Name = sdr[0].ToString();
                }
                sdr.Close();
                SqlParameter P2 = new SqlParameter("@cust_id", Id);
                SqlCommand cmd1 = new SqlCommand("usp_GetCustomerLastName", con);
                cmd1.Parameters.Add(P2);
                cmd1.CommandType = CommandType.StoredProcedure;
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                while (sdr1.Read())
                {
                    Last_Name = sdr1[0].ToString();
                }
                Customer_Name = First_Name + " " + Last_Name;
                con.Close();
            }
            catch (SqlException SE)
            {
                System.Windows.Forms.MessageBox.Show(SE.Message);
            }
            catch (Exception EX)
            {
                System.Windows.Forms.MessageBox.Show(EX.Message);
            }
            return Customer_Name;
        }
        #endregion

        //METHOD TO GET CREDIT LIMIT
        #region GetCreditLimit
        public int GetCreditLimit(int id)
        {
            int Credit = 0;
            try
            {
                con.Open();
                SqlParameter P1 = new SqlParameter("@cust_id", id);
                cmd = new SqlCommand();
                cmd.CommandText = "usp_GetCreditLimit";
                //SqlCommand cmd = new SqlCommand("usp_GetCreditLimit", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(P1);
                cmd.Connection = con;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Credit = int.Parse(sdr[0].ToString());
                }
                con.Close();


            }
            catch (SqlException SE)
            {
                System.Windows.Forms.MessageBox.Show(SE.Message);
            }
            catch (Exception EX)
            {
                System.Windows.Forms.MessageBox.Show(EX.Message);
            }
            return Credit;
        }
        #endregion
    }
}
