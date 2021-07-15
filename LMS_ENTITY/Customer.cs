using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS_EXCEPTION;

namespace LMS_ENTITY
{
    /// <summary>
    /// ENTITY LAYER FOR CUSTOMER
    /// </summary>
    public class Customer
    {

        #region Attributes
        public int cUSTOMER_ID;
        public string fIRST_NAME;
        public string lAST_NAME;
        public string aDDRESS;
        public string pAN_NUMBER;
        public long aADHAR_NUMBER;
        public long cONTACT_NUMBER;
        public string eMAIL;
        public DateTime dOB;
        public int cREDIT_LIMIT;
        public DateTime lAST_UPDATED_CREDIT_DATE;
        public string pASSWORD;




        #endregion

        #region Properties
        public int CUSTOMER_ID { get { return cUSTOMER_ID; } set { cUSTOMER_ID = value; } }
        public string FIRST_NAME
        {
            get { return fIRST_NAME; }
            set
            {
                if (value != null)
                {
                    fIRST_NAME = value;
                }
                else
                {
                    throw new Lms_Exception("Name cannot be Null");
                }
            }
        }
        public string LAST_NAME { get { return lAST_NAME; } set { lAST_NAME = value; } }
        public string ADDRESS { get { return aDDRESS; } set { aDDRESS = value; } }
        public string PAN_NUMBER
        {
            get { return pAN_NUMBER; }
            set
            {
                if (value != null)
                {
                    pAN_NUMBER = value;
                }
                else
                {
                    throw new Lms_Exception("PAN Number cannot be Null");
                }
            }
        }
        public long AADHAR_NUMBER
        {
            get { return aADHAR_NUMBER; }
            set
            {
                if (value > 0)
                {
                    aADHAR_NUMBER = value;
                }
                else
                {
                    throw new Lms_Exception("AADHAR Number cannot be Null");
                }
            }
        }
        public long  CONTACT_NUMBER
        {
            get { return cONTACT_NUMBER; }
            set
            {
                if (value > 0)
                {
                    cONTACT_NUMBER = value;
            }
                else
                {
                    throw new Lms_Exception("Contact Number cannot be Null");
                }
            }
        }
        public string EMAIL { get { return eMAIL; } set { eMAIL = value; } }
        public DateTime DOB { get { return dOB; } set { dOB = value; } }
        public int CREDIT_LIMIT
        {
            get { return cREDIT_LIMIT; }
            set
            {
                if (value > 0)
                {
                    cREDIT_LIMIT = value;
                }
                else
                {
                    throw new Lms_Exception("Credit Limit cannot be Null");
                }
            }
        }
        public DateTime LAST_UPDATED_CREDIT_DATE 
        { 
            get { return lAST_UPDATED_CREDIT_DATE; } 
            set { lAST_UPDATED_CREDIT_DATE = value; } 
        }

        public string Password { get { return pASSWORD; } set { pASSWORD = value; } }

        #endregion
    }
}