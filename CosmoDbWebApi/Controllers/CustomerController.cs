using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CosmoDbWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Documents.Client;
using CosmoDbWebApi;
using Newtonsoft.Json;
using CosmoDbWebApi.Services;

namespace CosmoDbWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        ICustomer customer = new CustomerCosmosDbHandler();
        // GET: api/Customer
        [HttpGet]
        public IEnumerable<Customer> Get()
        {

            return customer.GetAllCustomers();
        }

    }
}
