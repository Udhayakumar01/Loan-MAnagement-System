using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LMS_DAL;

namespace LMS_UNIT_TEST
{
    [TestClass]
    public class Test_Dal_Customer
    {
        #region VALIDATION FOR CustomerLogin With Correct password
        [TestMethod]
        public void CustomerLogin_ValidatingPassWord_ReturnTrue()
        {
            //arrange
            Dal_Customer obj = new Dal_Customer();
            //act
            var result = obj.CustomerLogin(1, "udhaya");
            //
            Assert.IsTrue(result);
        }
        #endregion

        #region VALIDATION FOR  CustomerLogin With incorrect password
        [TestMethod]
        public void CustomerLogin_ValidatingPassWord_ReturnFalse()
        {
            //arrange
            Dal_Customer obj = new Dal_Customer();
            //act
            var result = obj.CustomerLogin(1, "234");
            //
            Assert.IsFalse(result);
        }
        #endregion


    }
}
