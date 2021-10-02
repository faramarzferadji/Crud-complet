using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Complet_Crud.DataAccesses;
using System.Windows.Forms;
using Complet_Crud.Validations;

namespace Complet_Crud.business
{
   public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhonNumber{ get; set; }

        public void SaveCustomer(Customer cus)
        {
            CustomerIO.SaveRecord(cus);
        }
        public Customer AddRecord(int id)
        {
            return CustomerIO.AddRecord(id);
        }
        public Customer Search(int cusID)
        {
            return CustomerIO.Search(cusID);
        }
        public void  Delete(int cusID)
        {
             CustomerIO.Delete( cusID);
        }
        public void UpDate(Customer cust)
        {
            CustomerIO.UpDate(cust);
        }
        public bool IsValidID(TextBox text)
        {
            return true;
        }
        public bool IsValid(string inpt)
        {
            return false;
        }
        


    }
}
