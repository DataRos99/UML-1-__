using System;
using System.Collections.Generic;
using System.Text;

namespace UML_1___
{
    class Order
    {
        #region
        double _taxPct;
        int _DeliveryCosts;
        Pizza p;
        Customer c;
        private string _name;
        #endregion

        #region
        public Order(Pizza pizza, Customer customer)
        {
            p = pizza;
            c = customer;
            _taxPct = 25;
            _DeliveryCosts = 50;
        }
        #endregion

        #region
        public double taxPct
        {
            get { return _taxPct; }
            set { _taxPct = value; }
        }
        #endregion

        #region
        public int DeliveryCosts
        {
            get { return _DeliveryCosts; }
            set { _DeliveryCosts = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion

        #region
        public override string ToString()
        {
            return $"Pizza: {p.Name} Customer: {c.CustomerName} Total: {CalculateTotalPrice()}";
        }
        #endregion
        public double CalculateTotalPrice()
        {
            return p.PizzaPrice * (1 + taxPct / 100) + DeliveryCosts;
        }
    }
}
