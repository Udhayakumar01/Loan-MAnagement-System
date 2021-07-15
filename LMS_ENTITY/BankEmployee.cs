using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_EXCEPTION;

namespace LMS_ENTITY
{
    /// <summary>
    /// ENTITY LAYER FOR BANK EMPLOYEE
    /// </summary>
    public class BankEmployee
    {
        #region Attributes
        private int empId;
        private string empName;
        private long con_number;
        private string email;
        private string empType;
        private string password;

        #endregion

        #region Properties
        public int EmpId 
        { 
            get { return empId; } 
            set 
            {
                if( value < 0)
                {
                    throw new Lms_Exception("Employee ID cannot be 0 or Negative");
                }
                else
                {
                    empId = value;
                }
            }
        }


        public string EmpName
        {
            get { return empName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Lms_Exception("Employee Name cannot be Null or Empty");

                }
                else
                {
                    empName = value;
                }
                
            }
        }


        public long CONTACT_NUMBER
        {
            get { return con_number; }
            set
            {
                if (value <= 0)
                {
                    throw new Lms_Exception("Contact Number cannot be Null or Empty");
                }
                else
                {
                    con_number = value;
                }
            }
        }

        public string EMAIL
        {
            get { return email; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Lms_Exception("Employee Name cannot be Null or Empty");

                }
                else
                {
                    email = value;
                }
            }
        }

        public string EMP_TYPE
        {
            get { return empType; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Lms_Exception("Employee Type cannot be Null or Empty");

                }
                else
                {
                    empType = value;
                }
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        #endregion
    }
}
