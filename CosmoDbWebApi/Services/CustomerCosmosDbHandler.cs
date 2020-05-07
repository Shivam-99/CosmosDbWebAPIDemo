using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CosmoDbWebApi.Models;
using Microsoft.Azure.Documents.Client;

namespace CosmoDbWebApi.Services
{
    public class CustomerCosmosDbHandler:ICustomer
    {
        static string DatabaseName = "Customers";
        static string CollectionName = "Customers";
        static DocumentClient dc;
        static string endpoint = "https://cosmosdbtesters.documents.azure.com:443/";
        private static string key = "NpdEM6hcrYAkCxoekd719M39MEKE8DPbkgDYrEw04Nmmw2ZB9RZkNE4frP1sCtzyPxwGbxwOM2UQEKMvM0lRlQ==";
        public IEnumerable<Customer> GetAllCustomers()
        {
            dc = new DocumentClient(new Uri(endpoint), key);
            FeedOptions queryOptions = new FeedOptions { MaxItemCount = -1, EnableCrossPartitionQuery = true };

            var query = dc.CreateDocumentQuery<Customer>(
                UriFactory.CreateDocumentCollectionUri(DatabaseName, CollectionName),
                queryOptions);
            return query;
        }
    }
}
