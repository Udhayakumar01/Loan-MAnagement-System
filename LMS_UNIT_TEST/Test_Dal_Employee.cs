using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LMS_DAL;
using LMS_ENTITY;

namespace LMS_UNIT_TEST
{
    [TestClass]
    public class Test_Dal_Employee
    {
        #region Test Add Employee
        [TestMethod]
        public void Test_AddEmployee()
        {
            //ARRANGE
            BankEmployee bankEmployee = new BankEmployee();
            bankEmployee.EmpName = "Rajesh";
            bankEmployee.CONTACT_NUMBER = 9564712077;
            bankEmployee.EMAIL = "abc@gmail.com";
            bankEmployee.EMP_TYPE = "Permanent";
            bankEmployee.Password = "123";
            Dal_Employee obj = new Dal_Employee();
            //ACT
            var result = obj.AddEmployee();
            //ASSERT
            Assert.IsTrue(result);
        }
        #endregion

        #region Test Get Employee Id After Registration
        [TestMethod]
        public void Test_GetEmployeeIdAfterRegistration()
        {
            //ARRANGE
            Dal_Employee dal_Employee = new Dal_Employee();
            //ACT
            var result = dal_Employee.GetEmployeeIdAfterRegistration();
            //ASSERT
            Assert.AreEqual(result,6);

        }
        #endregion

        #region VALIDATION FOR AddCustomer
        [TestMethod]
        public void AddCustomer_ValidatingPassWord_ReturnFalse()
        {
            //arrange
            Dal_Customer obj = new Dal_Customer();
            //act
            var result = obj.AddCustomer();
            //
            Assert.AreEqual<int>(result, 0);
        }
        #endregion

        #region VALIDATION FOR DeleteCustomer
        [TestMethod]
        public void DeleteCustomer_ValidatingPassWord_ReturnFalse()
        {
            //arrange
            Dal_Customer obj = new Dal_Customer();
            //act
            var result = obj.DeleteCustomer(0);
            //
            Assert.AreEqual<int>(result, 0);
        }
        #endregion

        #region VALIDATION FOR UpdateCustomer
        [TestMethod]
        public void UpdateCustomer_ValidatingPassWord_ReturnFalse()
        {
            //arrange
            Dal_Customer obj = new Dal_Customer();
            //act
            var result = obj.UpdateCustomer(1);
            //
            Assert.AreEqual<int>(result, 0);
        }
        #endregion

        #region VALIDATION FOR GetCustomerIdAfterRegistration
        [TestMethod]
        public void GetCustomerIdAfterRegistration_ValidatingPassWord_ReturnFalse()
        {
            //arrange
            Dal_Customer obj = new Dal_Customer();
            //act
            var result = obj.GetCustomerIdAfterRegistration();
            //
            Assert.AreEqual<int>(result, 5);
        }

        #endregion
    }
}
