using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_ENTITY
{
    /// <summary>
    /// ENTITY LAYER FOR LOAN DETAILS
    /// </summary>
    public class LoanDetails
    {
        #region Attributes
        private int Loan_Acc_Number;
        private decimal Loan_Amount;
        private int Customer_Id;
        private string Loan_Type;
        private DateTime Loan_Approved_Date;
        private DateTime Dispersal_Date;
        private decimal Interest_Rate;
        private int Tenure;
        private DateTime Emi_Start_Date;
        private DateTime Emi_End_Date;
        private decimal Emi_Amount;
        private int Credit_Limit;
        private DateTime Last_Updated_Credit_Date;
        #endregion

        #region Properties
        public int LOAN_ACC_NUMBER
        {
            get
            {
                return Loan_Acc_Number;
            }
            set
            {
                Loan_Acc_Number = value;
            }
        }
        public decimal LOAN_AMOUNT 
        {
            get 
            {
                return Loan_Amount;
            } set 
            {
                Loan_Amount = value;
            } 
        }
        public int CUSTOMER_ID
        {
            get
            {
                return Customer_Id;
            }
            set
            {
                Customer_Id = value;
            }
        }
        public string LOAN_TYPE
        {
            get
            {
                return Loan_Type;
            }
            set
            {
                Loan_Type = value;
            }
        }
        public DateTime LOAN_APPROVED_DATE
        {
            get
            {
                return Loan_Approved_Date;
            }
            set
            {
                Loan_Approved_Date = value;
            }
        }
        public DateTime DISPERSAL_DATE
        {
            get
            {
                return Dispersal_Date;
            }
            set
            {
                Dispersal_Date = value;
            }
        }
        public decimal INTEREST_RATE
        {
            get
            {
                return Interest_Rate;
            }
            set
            {
                Interest_Rate = value;
            }
        }
        public int TENURE
        {
            get
            {
                return Tenure;
            }
            set
            {
                Tenure = value;
            }
        }
        public DateTime EMI_START_DATE
        {
            get
            {
                return Emi_Start_Date;
            }
            set
            {
                 Emi_Start_Date = value;
            }
        }
        public DateTime EMI_END_DATE
        {
            get
            {
                return Emi_End_Date;
            }
            set
            {
                Emi_End_Date = value;
            }
        }
        public Decimal EMI_AMOUNT
        {
            get
            {
                return Emi_Amount;
            }
            set
            {
                Emi_Amount = value;
            }
        }
        public int CREDIT_LIMIT
        {
            get
            {
                return Credit_Limit ;
            }
            set
            {
                Credit_Limit = value;
            }
        }
        public DateTime LAST_UPDATED_CREDIT_DATE
        {
            get
            {
                return Last_Updated_Credit_Date;
            }
            set
            {
               Last_Updated_Credit_Date = value;
            }
        }
        
        #endregion

    }
}

