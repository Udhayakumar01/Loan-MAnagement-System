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
    /// BUISNESS LOGIC LAYER FOR CUSTOMERS
    /// </summary>
    public class Bl_Customer
    {
        Customer customer = null;
        Dal_Customer dal_Customer = null;

        public Bl_Customer()
        {
            customer = new Customer();
            dal_Customer = new Dal_Customer();
        }
        public Bl_Customer(Customer customerObj)
        {
            customer = customerObj;
            dal_Customer= new Dal_Customer(customer);
        }

        //METHOD TO VALIDATE CUSTOMER LOGIN CREDENTIALS
        #region Customer Login
        public bool CustomerLogin(int Id, string password)
        {
            return dal_Customer.CustomerLogin(Id, password);
        }
        #endregion

        //METHOD TO ADD CUSTOMERS
        #region Add Customers
        public int AddCustomer()
        {
            return dal_Customer.AddCustomer();
        }
        #endregion

        //METHOD TO DELETE CUSTOMER
        #region Delete Customer
        public int DeleteCustomer(int Id)
        {
            return dal_Customer.DeleteCustomer(Id);
        }
        #endregion

        //METHOD TO UPDATE CUSTOMER
        #region Update Customer
        public int UpdateCustomer(int Id)
        {
            return dal_Customer.UpdateCustomer(Id);
        }
        #endregion

        //METHOD TO GET CUSTOMER ID AFTER REGISTRATION
        #region Get Customer ID After Registration
        public int GetCustomerIdAfterRegistration()
        {
            return dal_Customer.GetCustomerIdAfterRegistration();
        }
        #endregion

    }
}
