using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinOperators.Classes
{
    public class LinqSamples
    {
        private Customer customer;
        private Product product;
        private Supplier supplier;

        public LinqSamples()
        {
            customer = new Customer();
            product = new Product();
            supplier = new Supplier();
        }

        [Category("Join Operators")]
        [Description("This sample shows how to perform a simple inner equijoin of two sequences to " +
            "produce a flat result set that consists of each element in suppliers that has a matching element " +
            "in customers.")]
        public void Linq102()
        {
            List<Customer> customers = customer.GetCustomerList();
            List<Supplier> suppliers = supplier.GetSupplierList();

            var custSuppJoin = from sup in suppliers
                               join cust in customers
                               on sup.Country equals cust.Country
                               select new
                               {
                                   Country = sup.Country,
                                   SupplierName = sup.SupplierName,
                                   CustomerName = cust.CompanyName
                               };

            foreach (var item in custSuppJoin)
            {
                Console.WriteLine("Country = {0}, Supplier = {1}, Customer = {2}", 
                                  item.Country, item.SupplierName, item.CustomerName);
            }
        }

        [Category("Join Operators")]
        [Description("A group join produces a hierarchical sequence. The following query is an inner join " +
                    " that produces a sequence of objects, each of which has a key and an inner sequence of all matching elements.")]
        public void Linq103()
        {
            List<Customer> customers = customer.GetCustomerList();
            List<Supplier> suppliers = supplier.GetSupplierList();

            var custSuppQuery = from sup in suppliers
                                join cust in customers
                                on sup.Country equals cust.Country into cs
                                select new
                                {
                                    Key = sup.Country,
                                    Items = cs
                                };

            foreach(var item in custSuppQuery)
            {
                Console.WriteLine(item.Key + ":");
                foreach (var element in item.Items)
                {
                    Console.WriteLine("   " + element.CompanyName);
                }
            }
        }

        [Category("Join Operators")]
        [Description("The group join operator is more general than join, as this slightly more verbose " +
            "version of the cross join sample shows.")]
        public void Linq104()
        {
            string[] categories = new string[]{ 
                "Beverages", 
                "Condiments", 
                "Vegetables", 
                "Dairy Products", 
                "Seafood" };

            List<Product> products = product.GetProductList();

            var prodByCategory = from cat in categories
                                 join prod in products
                                 on cat equals prod.Category into ps
                                 from p in ps
                                 select new
                                 {
                                     Category = cat,
                                     p.ProductName
                                 };
            foreach (var item in prodByCategory)
            {
                Console.WriteLine(item.ProductName + ": " + item.Category);
            }
        }

        [Category("Join Operators")]
        [Description("A left outer join produces a result set that includes all the left hand side elements at " +
            "least once, even if they don't match any right hand side elements.")]
        public void Linq105()
        {
            List<Customer> customers = customer.GetCustomerList();
            List<Supplier> suppliers = supplier.GetSupplierList();

            var supplierCustomer = from sup in suppliers
                                   join cust in customers
                                   on sup.Country equals cust.Country into cs
                                   from c in cs.DefaultIfEmpty() // DefaultIfEmpty preserves left-hand elements that have no matches on the right side 
                                   orderby sup.SupplierName
                                   select new
                                   {
                                       Country = sup.Country,
                                       CompanyName = c == null? "(No customers)": c.CompanyName,
                                       SupplierName = sup.SupplierName
                                   };

            foreach (var item in supplierCustomer)
            {
                Console.WriteLine("{0} ({1}): {2}", item.SupplierName, item.Country, item.CompanyName);
            }
        }

        [Category("Join Operators")]
        [Description("For each customer in the table of customers, this query returns all the suppliers " +
                     "from that same country, or else a string indicating that no suppliers from that country were found.")]
        public void Linq106()
        {
            List<Customer> customers = customer.GetCustomerList();
            List<Supplier> suppliers = supplier.GetSupplierList();

            var customerSupplier = from cust in customers
                                   join sup in suppliers
                                   on cust.Country equals sup.Country into cs
                                   from s in cs.DefaultIfEmpty()
                                   orderby cust.CompanyName
                                   select new
                                   {
                                       Country = cust.Country,
                                       CompanyName = cust.CompanyName,
                                       SupplierName = s == null ? "(No suppliers)" : s.SupplierName
                                   };
            foreach (var item in customerSupplier)
            {
                Console.WriteLine("{0} ({1}): {2}", item.CompanyName, item.Country, item.SupplierName);
            }
        }

        [Category("Join Operators")]
        [Description("For each supplier in the table of suppliers, this query returns all the customers " +
                     "from the same city and country, or else a string indicating that no customers from that city/country were found. " +
                     "Note the use of anonymous types to encapsulate the multiple key values.")]
        public void Linq107()
        {
            List<Customer> customers = customer.GetCustomerList();
            List<Supplier> suppliers = supplier.GetSupplierList();

            var supplierCustomer = from sup in suppliers
                                   join cust in customers
                                   on new { sup.City, sup.Country} equals new { cust.City, cust.Country} into cs
                                   from c in cs.DefaultIfEmpty()
                                   orderby sup.SupplierName
                                   select new
                                   {
                                       Country = sup.Country,
                                       City = sup.City,
                                       SupplierName = sup.SupplierName,
                                       CompanyName = c == null ? "(No customers)" : c.CompanyName
                                   };

            foreach (var item in supplierCustomer)
            {
                Console.WriteLine("{0} ({1}, {2}): {3}", item.SupplierName, item.City, item.Country, item.CompanyName);
            }
        }
    }
}
