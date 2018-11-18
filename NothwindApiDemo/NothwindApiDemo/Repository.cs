using System.Collections.Generic;
using Foundation.ObjectHydrator;
using NothwindApiDemo.Models;

namespace NothwindApiDemo
{
    public class Repository
    {
        public static Repository Instance { get; } = new Repository();
        public IList<CustomerDTO> Customers { get; set; }

        public Repository()
        {
            Hydrator<CustomerDTO> hydrator = new Hydrator<CustomerDTO>();
            Customers = hydrator.GetList(5);
        }
    }
}
