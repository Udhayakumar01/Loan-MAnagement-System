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
    /// DATA ACCESS LAYER TO MANAGE LOAN 
    /// </summary>
    public class Dal_ManageLoan
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader sdr = null;
        Customer customer = null;
        public Dal_ManageLoan()
        {
            customer = new Customer();
            con = new SqlConnection();
            con.ConnectionString = @"Server = DESKTOP-MBKK1D2\CAPG; Integrated Security = true; Database = LMS_DB";
        }
       
        //METHOD TO ADD LOAN DETAILS 
        #region Add Loan Details
        public int AddLoanDetails(int id)
        {
            int flag = 0;
            int Customer_Id = GetCustomerId(id);
            try
            {
                if (Customer_Id > 0)
                {
                    LoanDetails details = new LoanDetails();
                    details.LOAN_AMOUNT = GetLoanAmount(id);
                    details.CUSTOMER_ID = id;
                    details.LOAN_TYPE = GetLoanType(id);
                    details.LOAN_APPROVED_DATE = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                    details.DISPERSAL_DATE = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                    details.INTEREST_RATE = GetInterestRate(id);
                    details.TENURE = GetTenure(id);
                    details.EMI_START_DATE = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                    details.EMI_END_DATE = GetEmiEndDate(id);
                    details.EMI_AMOUNT = GetEmiAmount(id);
                    details.CREDIT_LIMIT = GetCreditLimit(id);
                    details.LAST_UPDATED_CREDIT_DATE = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                    if (details.LOAN_AMOUNT <= details.CREDIT_LIMIT)
                    {
                        con.Open();
                        cmd = new SqlCommand();
                        cmd.Parameters.AddWithValue("@LOAN_AMOUNT", details.LOAN_AMOUNT);
                        cmd.Parameters.AddWithValue("@CUSTOMER_ID", details.CUSTOMER_ID);
                        cmd.Parameters.AddWithValue("@LOAN_TYPE", details.LOAN_TYPE);
                        cmd.Parameters.AddWithValue("@LOAN_APPROVED_DATE", details.LOAN_APPROVED_DATE);
                        cmd.Parameters.AddWithValue("@DISPERSAL_DATE", details.DISPERSAL_DATE);
                        cmd.Parameters.AddWithValue("@INTEREST_RATE", details.INTEREST_RATE);
                        cmd.Parameters.AddWithValue("@TENURE", details.TENURE);
                        cmd.Parameters.AddWithValue("@EMI_START_DATE", details.EMI_START_DATE);
                        cmd.Parameters.AddWithValue("@EMI_END_DATE", details.EMI_END_DATE);
                        cmd.Parameters.AddWithValue("@EMI_AMOUNT", details.EMI_AMOUNT);
                        cmd.Parameters.AddWithValue("@CREDIT_LIMIT", details.CREDIT_LIMIT);
                        cmd.Parameters.AddWithValue("@LAST_UPDATED_CREDIT_DATE", details.LAST_UPDATED_CREDIT_DATE);
                        cmd.CommandText = "usp_InsertLoan";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        flag = cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    throw new Lms_Exception("Customer is not Eligible for a Loan");
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
            finally 
            {
                con.Close();
            }

            return flag;
        }
        #endregion

        //METHOD TO GET CUSTOMER ID
        #region Get Customer ID
        public int GetCustomerId(int Id)
        {
            int CustomerId = 0;

            try
            {
                con.Open();
                SqlParameter P1 = new SqlParameter("@cust_id", Id);
                cmd = new SqlCommand();
                cmd.CommandText = "usp_GetCustomerId";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(P1);
                cmd.Connection = con;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    CustomerId = int.Parse(sdr[0].ToString());
                }
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
            return CustomerId;
        }
        #endregion

        //METHID TO GET LOAN AMOUNT
        #region Get Loan Amount
        public decimal GetLoanAmount(int id)
        {
            decimal LoanAmount = 0;
            try
            {
                con.Open();
                SqlParameter P1 = new SqlParameter("@cust_id", id);
                SqlCommand cmd = new SqlCommand("usp_GetLoanAmount", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(P1);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    LoanAmount = decimal.Parse(sdr[0].ToString());
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

            return LoanAmount;
        }
        #endregion

        //METHOD TO GET LOAN TYPE
        #region Get Loan Type
        public string GetLoanType(int id)
        {
            string LoanType = null;
            try
            {
                con.Open();
                SqlParameter P1 = new SqlParameter("@cust_id", id);
                SqlCommand cmd = new SqlCommand("usp_GetLoanType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(P1);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    LoanType = sdr[0].ToString();
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

            return LoanType;
        }
        #endregion

        //METHOD TO GET INTEREST RATE
        #region Get Interest Rate
        public decimal GetInterestRate(int id)
        {
            decimal interest = 0;
            try
            {
                con.Open();
                SqlParameter P1 = new SqlParameter("@cust_id", id);
                SqlCommand cmd = new SqlCommand("usp_GetInterestRate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(P1);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    interest = decimal.Parse(sdr[0].ToString());
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

            return interest;
        }
        #endregion

        //METHOD TO CALCULATE EMI AMOUNT
        #region Get Emi Amount
        public decimal GetEmiAmount(int id)
        {
            decimal Emi = 0;
            try
            {
               
                decimal LoanAmount = GetLoanAmount(id);
                int Tenure = GetTenure(id);
                decimal IntrestRate = GetInterestRate(id);
                decimal temp;
                temp = ((LoanAmount / Tenure) * IntrestRate / 100);
                Emi = LoanAmount / Tenure + temp;
            }
            catch (SqlException SE)
            {
                System.Windows.Forms.MessageBox.Show(SE.Message);
            }
            catch (Exception EX)
            {
                System.Windows.Forms.MessageBox.Show(EX.Message);
            }
            return Emi;

        }
        #endregion

        //METHOD TO GET CREDIT LIMIT
        #region Get Credit Limit
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
            }
            catch (SqlException SE)
            {
                System.Windows.Forms.MessageBox.Show(SE.Message);
            }
            catch (Exception EX)
            {
                System.Windows.Forms.MessageBox.Show(EX.Message);
            }
            con.Close();
            return Credit;
        }
        #endregion

        //METHOD TO GET TENURE
        #region Get Tenure
        public int GetTenure(int id)
        {
            int Tenure = 0;
            try
            {
                con.Open();
                SqlParameter P1 = new SqlParameter("@cust_id", id);
                SqlCommand cmd = new SqlCommand("usp_GetTenure", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(P1);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Tenure = int.Parse(sdr[0].ToString());
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
            return Tenure;
        }
        #endregion

        //METHOD TO CALCULATE EMI END DATE
        #region Get Emi End Date
        public DateTime GetEmiEndDate(int id)
        {
            int Tenure = GetTenure(id);
            DateTime EmiEndDate;
            DateTime current = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
            Console.WriteLine($"{current}");

            for (int i = 1; i <= Tenure; i++)
            {
                int Month = 1;
                current = DateTime.Parse(current.AddMonths(Month).ToString());

            }
            EmiEndDate = current;
            return EmiEndDate;
        }
        #endregion

        //METHOD TO GET CUSTOMER NAME 
        #region Get Customer Name
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
            catch(SqlException SE)
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

        //METHOD TO SHOW ALL LOAN APPLICATIONS 
        
        #region Show All Loan Applications
        public List<ApplyLoan> ShowAllLoanApplications()
        {
            List<ApplyLoan> LoanApplications = new List<ApplyLoan>();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "usp_ShowAllLoanApplications";
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Connection = con;
                sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    ApplyLoan applyLoan = null;
                    foreach (DataRow row in dt.Rows)
                    {
                        applyLoan = new ApplyLoan();
                        applyLoan.CUSTOMER_ID = int.Parse(row[0].ToString());
                        applyLoan.CUSTOMER_NAME = GetCustomerName(applyLoan.CUSTOMER_ID);
                        applyLoan.LOAN_AMOUNT = int.Parse(row[1].ToString());
                        applyLoan.LOAN_TYPE = row[2].ToString();
                        applyLoan.TENURE = int.Parse(row[3].ToString());
                        applyLoan.CREDIT_LIMIT = GetCreditLimit(applyLoan.CUSTOMER_ID);
                        applyLoan.STATUS_TYPE = row[4].ToString();
                        LoanApplications.Add(applyLoan);
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
            return LoanApplications;           
        }
        #endregion

        //METHOD TO SHOW ALL ELIGIBLE CUSTOMERS --- APPLIED FOR LOAN
        #region Show All Eligible Customers
        public List<ApplyLoan> ShowAllEligibleCustomers()
        {

            List<ApplyLoan> LoanApplications = new List<ApplyLoan>();
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "usp_ShowAllLoanApplications";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    ApplyLoan applyLoan = null;
                    foreach (DataRow row in dt.Rows)
                    {
                        applyLoan = new ApplyLoan();
                        applyLoan.CUSTOMER_ID = int.Parse(row[0].ToString());
                        applyLoan.CUSTOMER_NAME = GetCustomerName(applyLoan.CUSTOMER_ID);
                        applyLoan.LOAN_AMOUNT = int.Parse(row[1].ToString());
                        applyLoan.LOAN_TYPE = row[2].ToString();
                        applyLoan.TENURE = int.Parse(row[3].ToString());
                        applyLoan.CREDIT_LIMIT = GetCreditLimit(applyLoan.CUSTOMER_ID);
                        applyLoan.STATUS_TYPE = row[4].ToString();
                        if (applyLoan.LOAN_AMOUNT <= GetCreditLimit(applyLoan.CUSTOMER_ID))
                        {
                            LoanApplications.Add(applyLoan);
                        }
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
            return LoanApplications;
        }
        #endregion

        //METHOD TO SHOW ALL NON ELIGIBLE CUSTOMERS --- APPLIED FOR LOAN
        #region Show All Non Eligible Customers
        public List<ApplyLoan> ShowAllNonEligibleCustomers()
        {
            
            List<ApplyLoan> LoanApplications = new List<ApplyLoan>();
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "usp_ShowAllLoanApplications";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    ApplyLoan applyLoan = null;
                    foreach (DataRow row in dt.Rows)
                    {
                        applyLoan = new ApplyLoan();
                        applyLoan.CUSTOMER_ID = int.Parse(row[0].ToString());
                        applyLoan.CUSTOMER_NAME = GetCustomerName(applyLoan.CUSTOMER_ID);
                        applyLoan.LOAN_AMOUNT = int.Parse(row[1].ToString());
                        applyLoan.LOAN_TYPE = row[2].ToString();
                        applyLoan.TENURE = int.Parse(row[3].ToString());
                        applyLoan.CREDIT_LIMIT = GetCreditLimit(applyLoan.CUSTOMER_ID);
                        applyLoan.STATUS_TYPE = row[4].ToString();
                        if (applyLoan.LOAN_AMOUNT > GetCreditLimit(applyLoan.CUSTOMER_ID))
                        {
                            LoanApplications.Add(applyLoan);
                        }
                    }
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
            return LoanApplications;
        }
        #endregion

        //METHOD TO DELETE DATA (AFTER APPROVED OR REJECTED) FROM APPLY LOAN 
        #region Delete From ApplyLoan
        public int DeleteFromApplyLoan(int id)
        {
            int flag = 0;

            try
            {
                con.Open();
                SqlParameter P1 = new SqlParameter("@cust_id", id);
                cmd = new SqlCommand();
                cmd.CommandText = "usp_DeleteFromApplyLoan";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(P1);
                cmd.Connection = con;
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
            finally
            {
                con.Close();
            }
            return flag;
        }
        #endregion

        //METHOD TO UPDATE STATUSTYPE TO APPROVED IF LOAN IS APPROVED
        #region Update Status Type Approved
        public int UpdateStatusTypeApproved(int Id)
        {
            int flag = 0;
            try
            {
                con.Open();
                SqlParameter P1 = new SqlParameter("cust_id", Id);
                cmd = new SqlCommand();
                cmd.CommandText = "usp_UpdateApproved";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add(P1);
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

        //METHOD TO UPDATE STATUSTYPE TO REJECTED IF LOAN IS NOT APPRORVED
        #region Update Status Type Rejected
        public int UpdateStatusTypeRejected(int Id)
        {
            int flag = 0;

            try
            {
                con.Open();
                SqlParameter P1 = new SqlParameter("cust_id", Id);
                cmd = new SqlCommand();
                cmd.CommandText = "usp_UpdateRejected";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add(P1);
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
            finally
            {
                con.Close();
            }
            return flag;
        }
        #endregion

        //METHOD TO INSERT DATA FROM APPLY LOAN TO MANAGE LOAN AFTER THE LOAN IS PROCESSED
        #region Insert ManageLoan
        public int InsertManageLoan(int Id)
        {
            int flag = 0;
            try
            {
                con.Open();
                SqlParameter P1 = new SqlParameter("@cust_id", Id);
                cmd = new SqlCommand();
                cmd.CommandText = "usp_InsertManageLoan";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Add(P1);
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
            finally
            {
                con.Close();
            }
            return flag;
        }
        #endregion

        //METHOD TO DISPLAY DATA FROM MANAGE LOAN( ALL MANAGED LOAN APPLICATIONS )
        #region Show ManageLoan
        public List<ApplyLoan> ShowManageLoan()
        {
            List<ApplyLoan> LoanList = new List<ApplyLoan>();
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "usp_ShowManageLoan";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    ApplyLoan applyLoan = null;
                    foreach (DataRow row in dt.Rows)
                    {
                        applyLoan = new ApplyLoan();
                        applyLoan.CUSTOMER_ID = int.Parse(row[0].ToString());
                        applyLoan.CUSTOMER_NAME = GetCustomerName(applyLoan.CUSTOMER_ID);
                        applyLoan.LOAN_AMOUNT = int.Parse(row[1].ToString());
                        applyLoan.LOAN_TYPE = row[2].ToString();
                        applyLoan.TENURE = int.Parse(row[3].ToString());
                        applyLoan.CREDIT_LIMIT = GetCreditLimit(applyLoan.CUSTOMER_ID);
                        applyLoan.STATUS_TYPE = row[4].ToString();
                        LoanList.Add(applyLoan);
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
            
            return LoanList;
        }
        #endregion

    }
}
