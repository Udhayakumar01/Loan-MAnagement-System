using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_DAL;
using LMS_ENTITY;

namespace LMS_BL
{
    /// <summary>
    /// BUISNESS LOGIC LAYER FOR EMPLOYEES
    /// </summary>
    public class Bl_Employee
    {
        BankEmployee bankEmployee = null;
        Dal_Employee dal_Employee = null;

        public Bl_Employee()
        {
            bankEmployee = new BankEmployee();
            dal_Employee = new Dal_Employee();
        }
        public Bl_Employee(BankEmployee bankEmployeeObj)
        {
            bankEmployee = bankEmployeeObj;
            dal_Employee = new Dal_Employee(bankEmployee);
        }

        //METHOD TO ADD EMPLOYEE
        #region Add Employee
        public bool AddEmployee()
        {
            return dal_Employee.AddEmployee();
        }
        #endregion

        public int GetEmployeeIdAfterRegistration()
        {
            return dal_Employee.GetEmployeeIdAfterRegistration();
        }

    }
}
