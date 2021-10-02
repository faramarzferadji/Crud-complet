using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Complet_Crud.business;
using Complet_Crud.DataAccesses;
using Complet_Crud.Validations;

namespace Complet_Crud.GUI
{
    public partial class Customer_form : Form
    {
       // List<Customer> listC = new List<Customer>();
        
        public Customer_form()
        {
            InitializeComponent();
            buttonLISTCUSTOMER.Enabled = false;

        }

        private void Customer_form_Load(object sender, EventArgs e)
        {

        }

        private void buttonSEARCH_Click(object sender, EventArgs e)
        {
            int choice = comboBoxSearchBY.SelectedIndex;
            switch (choice)
            {
                case -1:MessageBox.Show("please enter one choice");
                    break;
                case 0:
                    Customer customer = new Customer();
                    customer = CustomerIO.Search(Convert.ToInt32(textBoxInPut.Text));
                    if (customer != null)
                    {
                        textBoxCustomerID.Text = (customer.CustomerID).ToString();
                        textBoxFirstName.Text = customer.FirstName;
                        textBoxLASTNAME.Text = customer.LastName;
                        maskedTextBoxPhonNumber.Text = customer.PhonNumber;
                    }
                    else
                    {
                        MessageBox.Show("customer not found");
                        textBoxInPut.Clear();
                        textBoxInPut.Focus();
                    }
                    break;
                case 1:
                    Customer cust1 = new Customer();
                    cust1 = CustomerIO.Search(textBoxInPut.Text);
                    if (cust1 != null)
                    {
                        textBoxCustomerID.Text = (cust1.CustomerID).ToString();
                        textBoxFirstName.Text = cust1.FirstName;
                        textBoxLASTNAME.Text = cust1.LastName;
                       maskedTextBoxPhonNumber.Text = cust1.PhonNumber;

                    }
                    else
                    {
                        MessageBox.Show("customer not fund");
                        textBoxInPut.Clear();
                        textBoxInPut.Focus();
                    }
                    textBoxInPut.Clear();
                    break;

                case 2:
                    Customer cust2 = new Customer();
                    cust2 = CustomerIO.Search(textBoxInPut.Text);
                    if (cust2 != null)
                    {
                        textBoxCustomerID.Text = (cust2.CustomerID).ToString();
                        textBoxFirstName.Text = cust2.FirstName;
                        textBoxLASTNAME.Text = cust2.LastName;
                        maskedTextBoxPhonNumber.Text = cust2.PhonNumber;

                    }
                    else
                    {
                        MessageBox.Show("customer not fund");
                        textBoxInPut.Clear();
                        textBoxInPut.Focus();
                    }
                    textBoxInPut.Clear();
                    break;

                case 3:
                    Customer cust3 = new Customer();
                    cust3 = CustomerIO.Search(Convert.ToInt32 (textBoxInPut.Text));
                    if (cust3 != null)
                    {
                        textBoxCustomerID.Text = (cust3.CustomerID).ToString();
                        textBoxFirstName.Text = cust3.FirstName;
                        textBoxLASTNAME.Text = cust3.LastName;
                        maskedTextBoxPhonNumber.Text = cust3.PhonNumber;

                    }
                    else
                    {
                        MessageBox.Show("customer not fund");
                        textBoxInPut.Clear();
                        textBoxInPut.Focus();
                    }
                    textBoxInPut.Clear();
                    break;








                default:break;


            }

            textBoxInPut.Clear();
            comboBoxSearchBY.Text = "";


        }

        private void maskedTextBoxPhonNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonSAVE_Click(object sender, EventArgs e)
        {
           // List<Customer> listC = CustomerIO.SaveRecord();

            if (Validation.IsValidID(textBoxCustomerID) && Validation.isValidName
                (textBoxFirstName) && Validation.isValidName(textBoxLASTNAME) )
            {
                Customer cus = new Customer();
                cus.CustomerID = Convert.ToInt32(textBoxCustomerID.Text);
                cus.FirstName = textBoxFirstName.Text;
                cus.LastName = textBoxLASTNAME.Text;
                cus.PhonNumber = maskedTextBoxPhonNumber.Text;
                cus.SaveCustomer(cus);

            }
           

        }

        private void buttonLISTCUSTOMER_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus = cus.AddRecord(Convert.ToInt32(textBoxCustomerID.Text));
            ListViewItem item = new ListViewItem(cus.CustomerID.ToString());
            item.SubItems.Add(cus.FirstName);
            item.SubItems.Add(cus.LastName);
            item.SubItems.Add(cus.PhonNumber);
             listView1.Items.Add(item);
           
          
            textBoxCustomerID.Text = "";
            textBoxFirstName.Text = "";
            textBoxLASTNAME.Text = "";
            maskedTextBoxPhonNumber.Text = "";
            textBoxCustomerID.Focus();
           // buttonLISTCUSTOMER.Enabled = true;



        }

        private void buttonaADD_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus = cus.AddRecord(Convert.ToInt32(textBoxCustomerID.Text));
            if(cus != null)
            {
                ListViewItem item = new ListViewItem(cus.CustomerID.ToString());
                item.SubItems.Add(cus.FirstName);
                item.SubItems.Add(cus.LastName);
                item.SubItems.Add(cus.PhonNumber);
                MessageBox.Show("CustomerID is" + cus.CustomerID + "first name is" + cus.FirstName +
                    "Last name is " + cus.LastName + "Phon Number is" + cus.PhonNumber+"are added!");
                

            }
            else
            {
                MessageBox.Show("Customer not found");
            }
            buttonLISTCUSTOMER.Enabled = true;

        }

        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure to exit?",
                "confermation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            
            Customer cus = new Customer();
            cus.Delete(Convert.ToInt32(textBoxCustomerID.Text));
            textBoxCustomerID.Text = "";
            textBoxCustomerID.Focus();


            MessageBox.Show("customer successfuly deleted");
           
           
          







        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUPDATE_Click(object sender, EventArgs e)
        {
            Customer custo = new Customer();
            custo.CustomerID = Convert.ToInt32(textBoxCustomerID.Text);
            custo.FirstName = textBoxFirstName.Text;
            custo.LastName = textBoxLASTNAME.Text;
            custo.PhonNumber = maskedTextBoxPhonNumber.Text;
            DialogResult answer = MessageBox.Show("Are you sure to up date data", "confermation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (answer == DialogResult.Yes)
            {
                custo.UpDate(custo);
                MessageBox.Show("customer Uptodated");


            }
            textBoxCustomerID.Text = "";
            textBoxFirstName.Text = "";
            textBoxLASTNAME.Clear();
            maskedTextBoxPhonNumber.Clear();
            buttonLISTCUSTOMER.Enabled = true;






        }

        private void textBoxInPut_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLASTNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSearchBY_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choice = comboBoxSearchBY.SelectedIndex;
            switch (choice)
            {
                case 0: labelinfo.Text = "Please enter Customer ID";
                    textBoxInPut.Focus();
                   
                    break;
                case 1:
                    labelinfo.Text = "Please enter First Name";
                    textBoxInPut.Focus();
                    break;
                case 2:
                    labelinfo.Text = "Please enter Last Name";
                    textBoxInPut.Focus();
                    break;
                case 3:
                    labelinfo.Text = "Please enter Phone Number";
                    textBoxInPut.Focus();
                    break;

                default:
                    break;

            }
           

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCustomerID.Clear();
            textBoxFirstName.Clear();
            textBoxLASTNAME.Clear();
            maskedTextBoxPhonNumber.Clear();
            textBoxCustomerID.Focus();
        }
    }
}
