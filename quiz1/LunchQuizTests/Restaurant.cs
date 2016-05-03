using System;

namespace LunchQuizTests
{
    internal class Restaurant
    {
        internal int Numberof2PersonTables;
        internal int Numberof4PersonTables;

        public object CurrentCustomers { get; internal set; }
        public object MenuItems { get; internal set; }

        internal void AddCustomerToList(Customer steve)
        {
            throw new NotImplementedException();
        }

        internal int capacity()
        {
            throw new NotImplementedException();
        }

        internal bool ItemIsOnMenu(string v)
        {
            throw new NotImplementedException();
        }

        internal bool ItemIsOnMenu(MenuItem flavorsOfFried)
        {
            throw new NotImplementedException();
        }
    }
}