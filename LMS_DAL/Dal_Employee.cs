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
    /// DATA ACCESS LAYER FOR BANK EMPLOYEE DETAILS
    /// </summary>
   public class Dal_Employee
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        BankEmployee bankEmployee = null;

        public Dal_Employee()
        {
            bankEmployee = new BankEmployee();
            con = new SqlConnection();
            con.ConnectionString = @"Server = DESKTOP-MBKK1D2\CAPG; Integrated Security = true; Database = LMS_DB";
        }
        public Dal_Employee(BankEmployee bankEmployeeObj)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Server = DESKTOP-MBKK1D2\CAPG; Integrated Security = true; Database = LMS_DB";
            bankEmployee = bankEmployeeObj;
        }

        //METHOD TO ADD EMPLOYEE
        #region Add Employee
        public bool AddEmployee()
        {
            try
            {
                con.Open();
                SqlParameter p1, p2, p3, p4, p5;

                //p1 = new SqlParameter("@EmpId", employee.EmpId);
                p1 = new SqlParameter("@EmpName", bankEmployee.EmpName);
                p2 = new SqlParameter("@Contact_Number", bankEmployee.CONTACT_NUMBER);
                p3 = new SqlParameter("@Email", bankEmployee.EMAIL);
                p4 = new SqlParameter("@Employee_Type", bankEmployee.EMP_TYPE);
                p5 = new SqlParameter("@Password", bankEmployee.Password);

                cmd = new SqlCommand("usp_InsertBankEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                //cmd.Parameters.Add(p6);
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

        #region Get Employee Id After Registration
        public int GetEmployeeIdAfterRegistration()
        {
            int EmployeeId = 0;
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandText = "usp_GetEmployeeIdAfterRegistration";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    EmployeeId = int.Parse(sdr[0].ToString());
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
            return EmployeeId;
        }
        #endregion
    }
}
