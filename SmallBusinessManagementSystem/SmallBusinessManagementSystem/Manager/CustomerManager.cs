using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

using SmallBusinessManagementSystem.Model;
using SmallBusinessManagementSystem.Repository;

namespace SmallBusinessManagementSystem.Manager
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        public bool Save(CustomerModel customerModel)
        {
            return _customerRepository.Save(customerModel);
        }

        public bool IsExists(CustomerModel customerModel)
        {
            return _customerRepository.IsExists(customerModel);
        }

        public List<CustomerModel> ShowAll()
        {
            return _customerRepository.ShowAll();
        }

        public bool UpdateCustomer(CustomerModel customerModel)
        {
            return _customerRepository.UpdateCustomer(customerModel);
        }

        public DataTable SearchCustomer(CustomerModel customerModel)
        {
            return _customerRepository.SearchCustomer(customerModel);
        }
    }
}
