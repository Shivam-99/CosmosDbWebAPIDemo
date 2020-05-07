using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CosmoDbWebApi.Models;

namespace CosmoDbWebApi.Services
{
    interface ICustomer
    {
        IEnumerable<Customer> GetAllCustomers();
    }
}
