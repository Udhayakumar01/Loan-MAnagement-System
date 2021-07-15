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
    /// BUISNESS LOGIC LAYER TO MANAGE LOAN
    /// </summary>
    public class Bl_ManageLoan
    {
        Dal_ManageLoan lms_Dal = null;
        public Bl_ManageLoan()
        {
            lms_Dal = new Dal_ManageLoan();
        }

        //DAL METHOD TO SHOW ALL LOAN APPLICATIONS
        #region Show All Loan Applications
        public List<ApplyLoan> ShowAllLoanApplications()
        {
            return lms_Dal.ShowAllLoanApplications();
        }
        #endregion

        //DAL METHOD TO ADD LOAN DETAILS
        #region Add Loan Details
        public int AddLoanDetails(int id)
        {
            return lms_Dal.AddLoanDetails(id);
        }
        #endregion

        //DAL METHOD TO DELETE APPLICATIONS IN APPLY LOAN TABLE
        #region Delete From Apply Loan
        public int DeleteFromApplyLoan(int id)
        {
            return lms_Dal.DeleteFromApplyLoan(id);
        }
        #endregion

        //DAL METHOD TO UPDATE STATUS TYPE TO APPROVED
        #region Update Status Type Approved
        public int UpdateStatusTypeApproved(int Id)
        {
            return lms_Dal.UpdateStatusTypeApproved(Id);
        }
        #endregion

        //DAL METHOD TO UPDATE STATUS TYPE TO REJECTED 
        #region Update Status Type Rejected
        public int UpdateStatusTypeRejected(int Id)
        {
            return lms_Dal.UpdateStatusTypeRejected(Id);
        }
        #endregion

        //DAL METHOD TO SHOW MANAGE LOAN
        #region Show Manage Loan
        public List<ApplyLoan> ShowManageLoan()
        {
            return lms_Dal.ShowManageLoan();
        }
        #endregion
        //DAL TO COPY FROM APPLY LOAN TO MANAGE LOAN
        #region Insert Manage Loan
        public int InsertManageLoan(int Id)
        {
            return lms_Dal.InsertManageLoan(Id);
        }
        #endregion

        //DAL METHOD TO DISPLAY ALL ELIGIBLE CUSTOMERS ON ACCEPT LOAN WINDOW
        #region Show All Eligible Customers
        public List<ApplyLoan> ShowAllEligibleCustomers()
        {
            return lms_Dal.ShowAllEligibleCustomers();
        }
        #endregion

        //DAL METHOD TO DISPLAY ALL ELIGIBLE CUSTOMERS ON ACCEPT LOAN WINDOW
        #region Show All Non Eligible Customers
        public List<ApplyLoan> ShowAllNonEligibleCustomers()
        {
            return lms_Dal.ShowAllNonEligibleCustomers();
        }
        #endregion



    }
}
