using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Complet_Crud.business;
using System.Windows.Forms;
using Complet_Crud.Validations;

namespace Complet_Crud.DataAccesses
{
  public static  class CustomerIO

    {
         private static string filepath = Application.StartupPath + @"\Customer.dat";
         private static string filetemp = Application.StartupPath + @"\Temo.dat";
       

        public static void SaveRecord(Customer cus)
        {
            StreamWriter streamWriter = new StreamWriter(filepath,true);
            streamWriter.WriteLine(cus.CustomerID + "," + cus.FirstName + "," + cus.LastName + "," + cus.PhonNumber);
            MessageBox.Show("Record save successfully");

            streamWriter.Close();
        }

        public static Customer AddRecord(int id)
        {
            Customer cus = new Customer();
            if (File.Exists(filepath))
            {
                StreamReader streamReader = new StreamReader(filepath);
                string line = streamReader.ReadLine();
                bool found = false;
                while(line != null)
                {
                    string[] fildes = line.Split(',');
                    if(Convert.ToInt32(fildes[0]) == id)
                    {
                        cus.CustomerID = Convert.ToInt32(fildes[0]);
                        cus.FirstName = fildes[1];
                        cus.LastName = fildes[2];
                        cus.PhonNumber = fildes[3];
                        found = true;
                        break;
                    }
                    line = streamReader.ReadLine();
                   
                }
               
                streamReader.Close();
                     if (!found) { cus = null; }
            }
            else
            {
                MessageBox.Show("file not found");
            }
            
            
            return cus;
        }
        public static Customer AddRecord(string input)
        {
            Customer cus = new Customer();
            return cus;
        }
        public static  Customer Search(int cusID)
        {
            Customer cus = new Customer();
            StreamReader streamReader = new StreamReader(filepath);
            string line = streamReader.ReadLine();
            while(line != null)
            {
                string[] fields = line.Split(",");
                if(cusID == Convert.ToInt32(fields[0]))
                {
                    cus.CustomerID = Convert.ToInt32(fields[0]);
                    cus.FirstName = fields[1];
                    cus.LastName = fields[2];
                    cus.PhonNumber = fields[3];
                    return cus;
                }
                line = streamReader.ReadLine();
            }

            streamReader.Close();

            return null;
        }
        public static Customer Search(string otherInfo)
        {
            Customer cus = new Customer();
            StreamReader streamReader = new StreamReader(filepath);
            string line = streamReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(",");
                if (otherInfo == fields[1] || otherInfo == fields[2] ||
                     otherInfo == fields[3])
                {
                    cus.CustomerID = Convert.ToInt32(fields[0]);
                    cus.FirstName = fields[1];
                    cus.LastName = fields[2];
                    cus.PhonNumber = fields[3];
                    streamReader.Close();
                    return cus;
                }
                line = streamReader.ReadLine();
            }

            streamReader.Close();

            return null;
        }
        public static void Delete(int cusID)
        {
            StreamReader streamReader = new StreamReader(filepath);
            string line = streamReader.ReadLine();
            StreamWriter streamWriter = new StreamWriter(filetemp);
            while(line != null)
            {
                string[] fields = line.Split(",");
                if(cusID != Convert.ToInt32(fields[0]))
                {
                    streamWriter.WriteLine(fields[0] + "," + fields[1] + ","
                        + fields[2] + "," + fields[3]);

                }
                line = streamReader.ReadLine();

            }
            
            streamReader.Close();
            streamWriter.Close();
            File.Delete(filepath);
            File.Move(filetemp, filepath);
        }
        public static void UpDate(Customer cust)
        {
            StreamReader streamReader = new StreamReader(filepath);
            StreamWriter streamWriter = new StreamWriter(filetemp);
            string line = streamReader.ReadLine();
            while(line != null)
            {
                string[] fields = line.Split(",");
                if (Convert.ToInt32(fields[0]) != cust.CustomerID)
                {
                    streamWriter.WriteLine(fields[0] + "," + fields[1] + ","
                      + fields[2] + "," + fields[3]);


                }

                line = streamReader.ReadLine();

            }
            streamWriter.WriteLine(cust.CustomerID + "," + cust.FirstName + "," +
                cust.LastName + "," + cust.PhonNumber);
            streamReader.Close();
            streamWriter.Close();
            File.Delete(filepath);
            File.Move(filetemp, filepath);

        }



    }
}
