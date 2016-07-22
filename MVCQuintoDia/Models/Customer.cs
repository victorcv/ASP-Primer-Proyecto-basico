using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCQuintoDia.Models
{
    public class Customer
    {
        private string _CustomerName;
        private double _Amount;
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }
        public double Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        } 
    }
}