using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LMS_DAL;

namespace LMS_UNIT_TEST
{
    [TestClass]
    public class Test_Dal_ManageLoan
    {
        #region Test Add Loan Details
        [TestMethod]
        public void Test_AddLoanDetails()
        {
            //ARRANGE
            Dal_ManageLoan dal_ManageLoan = new Dal_ManageLoan();
            //ACT
            int flag = 0;
            if (dal_ManageLoan.GetLoanAmount(4) < dal_ManageLoan.GetCreditLimit(4))
            {
                flag = 1;
            }
            //ASSERT
            Assert.AreEqual(flag, 0);
        }
        #endregion

        #region Test Get Customer Id
        [TestMethod]
        public void Test_GetCustomerId()
        {
            //ARRANGE
            Dal_ManageLoan dal_ManageLoan = new Dal_ManageLoan();
            //ACT
            int flag = 0;
            flag = dal_ManageLoan.GetCustomerId(4);
            //ASSERT
            Assert.AreEqual(flag, 4);
        }
        #endregion

        #region Test Loan Amount
        [TestMethod]
        public void Test_LoanAmount()
        {
            //ARRANGE
            Dal_ManageLoan dal_ManageLoan = new Dal_ManageLoan();
            //ACT
            decimal flag = 0;
            flag = dal_ManageLoan.GetLoanAmount(4);
            //ASSERT
            Assert.AreEqual(flag, 200000);
        }
        #endregion

        #region Test Loan Type
        [TestMethod]
        public void Test_LoanType()
        {
            //ARRANGE
            Dal_ManageLoan dal_ManageLoan = new Dal_ManageLoan();
            //ACT
            string flag = null;
            flag = dal_ManageLoan.GetLoanType(4);
            //ASSERT
            Assert.AreEqual(flag, "Education Loan");
        }
        #endregion

        #region Test Get Interest Rate
        [TestMethod]
        public void Test_GetInterestRate()
        {
            //ARRANGE
            Dal_ManageLoan dal_ManageLoan = new Dal_ManageLoan();
            //ACT
            decimal flag = 0;
            flag = dal_ManageLoan.GetInterestRate(4);
            //ASSERT
            Assert.AreEqual<decimal>(flag, 10);
        }
        #endregion

        #region Test Get Credit Limit
        [TestMethod]
        public void Test_GetCreditLimit()
        {
            //ARRANGE
            Dal_ManageLoan dal_ManageLoan = new Dal_ManageLoan();
            //ACT
            decimal flag = 0;
            flag = dal_ManageLoan.GetCreditLimit(2);
            //ASSERT
            Assert.AreEqual<decimal>(flag, 700000);
        }
        #endregion

        #region TestGe tTenure
        [TestMethod]
        public void Test_GetTenure()
        {
            //ARRANGE
            Dal_ManageLoan dal_ManageLoan = new Dal_ManageLoan();
            //ACT
            decimal flag = 0;
            flag = dal_ManageLoan.GetTenure(4);
            //ASSERT
            Assert.AreEqual<decimal>(flag, 30);
        }
        #endregion

        #region VALIDATION FOR CUSTOMER NAME
        [TestMethod]
        public void GetCustomerName_ValidateFullName_ReturnFullName()
        {
            //arange
            Dal_ManageLoan obj = new Dal_ManageLoan();
            //act
            var result = obj.GetCustomerName(4);
            //assert
            Assert.AreEqual<string>(result, "Venkat MK");
        }
        #endregion

        #region VALIDATION FOR GET EMI END DATE 
        [TestMethod]
        public void GetEmiEndDate_ValidateEmiEndDate_ReturnEmiEndDate()
        {
            //arange
            Dal_ManageLoan obj = new Dal_ManageLoan();
            //act
            var result = obj.GetEmiEndDate(4);
            //assert
            Assert.AreEqual<DateTime>(result, Convert.ToDateTime("23-09-2023"));
        }
        #endregion

        #region VALIDATION FOR UpdateStatusTypeRejected
        [TestMethod]
        public void InsertManageLoan_ValidateInsertManageLoan_ReturnInt()
        {
            //arange
            Dal_ManageLoan obj = new Dal_ManageLoan();
            //act
            var result = obj.InsertManageLoan(0);
            //assert
            Assert.AreEqual<int>(result, 0);
        }

        #endregion




    }
}

