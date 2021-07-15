using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LMS_DAL;

namespace LMS_UNIT_TEST
{
    [TestClass]
    public class Test_Dal_ApplyLoan
    {
        #region Validation for GetCustomerName
        [TestMethod]
        public void GetCustomerName_ValidationForGetCustomerName_ReturnString()
        {
            //arrange
            Dal_ApplyLoan obj = new Dal_ApplyLoan();

            //act
            var result = obj.GetCustomerName(1);
            //assert
            Assert.AreEqual<string>(result, "udhaya kumar");

        }
        #endregion

        #region VALIDATION FOR THE GetCreditLimit
        [TestMethod]
        public void GetCreditLimit_ValidationForCreditLimit_ReturnCreditLimit()
        {
            //arange
            Dal_ApplyLoan obj = new Dal_ApplyLoan();
            //act
            var resutt = obj.GetCreditLimit(1);
            //assert
            Assert.AreEqual<int>(resutt, 200000);
        }
        #endregion
    }
}
