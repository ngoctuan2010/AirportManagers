using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BLL
{
    public class CustomerServices
    {
        public static List<Customer> loadCutomers()
        {
            List<Customer> listCus = new List<Customer>();
            using (var db = new AirportManager())
            {
                listCus = db.Customers.ToList();
            }
            return listCus;
        }

        public static bool updateCustomer(Customer customer)
        {
            using (var db = new AirportManager())
            {
                var eCustomer = db.Customers.Find(customer.CustomerID);
                if (eCustomer != null)
                {
                    db.Entry(eCustomer).CurrentValues.SetValues(customer);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public static bool deleteCustomer(int id)
        {
            using (var db = new AirportManager())
            {
                var record = db.Customers.Find(id);
                db.Entry(record).State = EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool addCustomer(Customer newCustomer)
        {
            using (var db = new AirportManager())
            {
                var customer = db.Customers.FirstOrDefault(c => c.NationalID == newCustomer.NationalID);
                if (customer == null)
                {
                    db.Customers.Add(newCustomer); db.SaveChanges(); return true;
                }
            }
            return false;
        }
    }
}
