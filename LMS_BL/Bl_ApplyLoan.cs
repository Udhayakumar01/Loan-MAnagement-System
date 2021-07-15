using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_ENTITY;
using LMS_DAL;

namespace LMS_BL
{
    /// <summary>
    /// BUISNESS LOGIC LAYER TO MANAGE LOAN APPLIATIONS
    /// </summary>
    public class Bl_ApplyLoan
    {
        
            ApplyLoan applyLoan = null;
            Dal_ApplyLoan dal_ApplyLoan = null;
            Dal_ApplyLoan dal_Customer = null;
            Customer customer = null;
        public Bl_ApplyLoan()
        {
            applyLoan = new ApplyLoan();
            dal_ApplyLoan = new Dal_ApplyLoan();
            dal_Customer = new Dal_ApplyLoan();
            customer = new Customer();
        }
        
        public Bl_ApplyLoan(ApplyLoan applyLoanObj)
        {
            applyLoan = applyLoanObj;
            dal_ApplyLoan = new Dal_ApplyLoan(applyLoan);

        }
        public Bl_ApplyLoan(Customer customerObj)
        {
            customer = customerObj;
            dal_Customer = new Dal_ApplyLoan(customer);
        }

        //METHOD TO UPDATE CUSTOMER DETAILS
        #region Update Customer 
        public bool UpdateCustomer(int Id)
        {
            return dal_Customer.UpdateCustomer(Id);
        }
        #endregion

        //METHOD TO VIEW CUSTOMER DETAILS
        #region View Customer Details
        public Customer ViewCustomerDetails(int Id)
        {
            return dal_Customer.ViewCustomerDetails(Id);
        }
        #endregion

        //METHOD TO APPLY LOAN APPLICATIONS
        #region Apply Loan Application
        public bool ApplyLoanApplication()
        {
            return dal_ApplyLoan.ApplyLoanApplication();
        }
        #endregion

        //METHOD TO VIEW LOAN STATUS
        #region View Loan Status
        public ApplyLoan ViewLoanStatus(int Id)
        {
            return dal_ApplyLoan.ViewLoanStatus(Id);
        }
        #endregion
    }

}
