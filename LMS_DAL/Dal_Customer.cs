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
    /// DATA ACCESS LAYER FOR CUSTOMER
    /// </summary>
    public class Dal_Customer
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        Customer customer = null;

        public Dal_Customer()
        {
            customer = new Customer();
            con = new SqlConnection();
            con.ConnectionString = @"Server = DESKTOP-MBKK1D2\CAPG; Integrated Security = true; Database = LMS_DB";
        }
        public Dal_Customer(Customer customerObj)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Server = DESKTOP-MBKK1D2\CAPG; Integrated Security = true; Database = LMS_DB";
            customer = customerObj;
        }

        //METHOD TO GET CUSTOMER LOGIN
        #region Customer Login
        public bool CustomerLogin(int Id, string password)
        {
            int CustomerId = Id;
            string Password = password;
            bool flag = false;
            try
            {
                SqlConnection con = new SqlConnection();
                SqlDataReader myReader = null;
                con.ConnectionString = @"Server = DESKTOP-MBKK1D2\CAPG; Integrated Security = true; Database = LMS_DB";
                con.Open();
                SqlParameter P1 = new SqlParameter("@CUSTOMER_ID", Id);
                SqlCommand myCommand = new SqlCommand("select PASSWORD from CUSTOMER where CUSTOMER_ID = @CUSTOMER_ID");
                myCommand.CommandType = CommandType.Text;
                myCommand.Parameters.Add(P1);
                myCommand.Connection = con;
                myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {
                    string password1 = myReader[0].ToString();
                    con.Close();
                    if (password1 == Password)
                    {
                        flag = true;
                    }

                }
            }
            catch (SqlException SE)
            {
                System.Windows.Forms.MessageBox.Show(SE.Message);
            }
            catch (Exception EX)
            {
                System.Windows.Forms.MessageBox.Show(EX.Message);
            }
            return flag;
        }
        #endregion

        //METHOD TO ADD CUSTOMER 
        #region Add Customer
        public int AddCustomer()
        {
            int flag = 0;
            try
            {
                SqlParameter p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11;
                p1 = new SqlParameter("@first_name", customer.FIRST_NAME);
                p2 = new SqlParameter("@last_name", customer.LAST_NAME);
                p3 = new SqlParameter("@address", customer.ADDRESS);
                p4 = new SqlParameter("@pan_num", customer.PAN_NUMBER);
                p5 = new SqlParameter("@aadhar_num", customer.AADHAR_NUMBER);
                p6 = new SqlParameter("@con_num", customer.CONTACT_NUMBER);
                p7 = new SqlParameter("@email", customer.EMAIL);
                p8 = new SqlParameter("@dob", customer.DOB);
                p9 = new SqlParameter("@credit_lim", customer.CREDIT_LIMIT);
                p10 = new SqlParameter("@last_updated_credit_date", customer.LAST_UPDATED_CREDIT_DATE);
                p11 = new SqlParameter("@password", customer.Password);
                con.Open();
                cmd = new SqlCommand("usp_InsertCustomers");
                cmd.CommandType = CommandType.StoredProcedure;
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
                cmd.Parameters.Add(p11);
                cmd.Connection = con;
                flag = cmd.ExecuteNonQuery();
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
            return flag;

        }
        #endregion

        // METHOD TO DELETE CUSTOMER
        #region Delete Customer
        public int DeleteCustomer(int Id)
        {
            int flag = 0;
            try
            {
                SqlParameter p1;
                p1 = new SqlParameter("cust_id", Id);
                con.Open();
                cmd = new SqlCommand("usp_DeleteCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(p1);
                flag = cmd.ExecuteNonQuery();
            }
            catch (SqlException SE)
            {
                System.Windows.Forms.MessageBox.Show(SE.Message);
            }
            catch (Exception EX)
            {
                System.Windows.Forms.MessageBox.Show(EX.Message);
            }
            return flag;

        }
        #endregion

        //METHOD TO UPDATE CUSTOMER
        #region Update Customer
        public int UpdateCustomer(int Id)
        {
            int flag = 0;
            try
            {
                SqlParameter p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11;
                p1 = new SqlParameter("cust_id", Id);
                p2 = new SqlParameter("@FIRST_NAME", customer.FIRST_NAME);
                p3 = new SqlParameter("@LAST_NAME", customer.LAST_NAME);
                p4 = new SqlParameter("@ADDRESS", customer.ADDRESS);
                p5 = new SqlParameter("@PAN_NUMBER", customer.PAN_NUMBER);
                p6 = new SqlParameter("@AADHAR_NUMBER", customer.AADHAR_NUMBER);
                p7 = new SqlParameter("@CONTACT_NUMBER", customer.CONTACT_NUMBER);
                p8 = new SqlParameter("@EMAIL", customer.EMAIL);
                p9 = new SqlParameter("@DOB", customer.DOB);
                p10 = new SqlParameter("@CREDIT_LIMIT", customer.CREDIT_LIMIT);
                p11 = new SqlParameter("@LAST_UPDATED_CREDIT_DATE", customer.LAST_UPDATED_CREDIT_DATE);
                con.Open();
                cmd = new SqlCommand("usp_UpdateCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
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
                cmd.Parameters.Add(p11);
                cmd.Connection = con;
                flag = cmd.ExecuteNonQuery();
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
            return flag;

        }
        #endregion

        //METHOD TO GET CUSTOMER ID AFTER REGISTRATION
        #region Get Customer Id After Registration
        public int GetCustomerIdAfterRegistration()
        {
            int CustomerId = 0;
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "usp_GetCustomerIdAfterRegistration";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    CustomerId = int.Parse(sdr[0].ToString());
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
            return CustomerId;
        }
        #endregion
    }
}
