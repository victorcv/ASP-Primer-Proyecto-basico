using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCQuintoDia.ViewModels;
using MVCQuintoDia.Models;

namespace MVCQuintoDia.ViewModels
{
    public class CustomerViewModel
    {
        private Customer Customer = new Customer();
        public string txtName
        {
            get { return Customer.CustomerName; }
            set { Customer.CustomerName = value; }
        }
        public string txtAmount
        {
            get { return Customer.Amount.ToString(); }
            set { Customer.Amount = Convert.ToDouble(value); }
        }
        public string lblCustomerLevelColor
        {
            get
            {
                if (Customer.Amount > 2000)
                {
                    return "red";
                }
                else if (Customer.Amount > 1500)
                {
                    return "orange";
                }
                else
                {
                    return "yellow";
                }
            }
        }
    }
}       
