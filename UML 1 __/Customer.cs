using System;
using System.Collections.Generic;
using System.Text;

namespace UML_1___
{
    class Customer
    {
        string _customerName;

        #region
        public Customer()
        {
            _customerName = "";
        }
        #endregion

        #region
        public Customer(string CustomerName)
        {
            _customerName = CustomerName;
        }
        #endregion

        #region
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }
        #endregion

        public override string ToString()
        {
            return $"CustomerName: {CustomerName}";

        }

    }
}
