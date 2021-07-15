using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_EXCEPTION;

namespace LMS_ENTITY
{
    /// <summary>
    /// ENTITY LAYER FOR APPLYING LOAN
    /// </summary>
    public class ApplyLoan
    {
        #region Attributes
        private int Customer_Id;
        private string Customer_Name;
        private decimal Loan_Amount;
        private string Loan_Type;
        private int _Tenure;
        private int Credit_Limit;
        private string Status_Type;
        #endregion

        #region Properties 

        public int CUSTOMER_ID 
        { 
            get { return Customer_Id;  } 
            set
            { 
            
                Customer_Id = value; 
            } 
        }
        public string CUSTOMER_NAME
        {
            get { return Customer_Name; }
            set
            {

                Customer_Name = value;
            }
        }
        public decimal LOAN_AMOUNT
        { 
            get { return Loan_Amount; }
            set 
            {
                if(value <= 0)
                {
                    throw new Lms_Exception("Loan Amount Cannot be 0 or negative");
                }
                else
                {
                    Loan_Amount = value;
                }
            }
        }
        public string LOAN_TYPE
        {
            get { return Loan_Type; }
            set
            {
                if (value == "Home Loan" || value == "Vehicle Loan" || value == "Education Loan")
                {
                    Loan_Type = value;
                }
                else
                {
                    throw new Lms_Exception("Invalid Loan Type");
                }
            }
        }
        public int CREDIT_LIMIT
        {
            get { return Credit_Limit; }
            set
            {
                Credit_Limit = value;
            }
        }

        public int TENURE
        {
            get { return _Tenure; }
            set
            {
                _Tenure = value;
            }
        }
        public string STATUS_TYPE
        {
            get { return Status_Type; }
            set
            {
                Status_Type = value;
            }
        }
        #endregion
    }
}
