using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        const int MaxSize = 10;
        Customer[] customerArray = new Customer[MaxSize];
        private int customerNum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            if (customerNum < MaxSize)
            {
                Customer cus = new Customer(NewCusFirstNameTextBox.Text, NewCusLastNameTextBox.Text,
                    DateTime.Parse(NewCusBirthdayTextBox.Text));
                cus.Address = NewCusAddressTextBox.Text;
                cus.Description = NewCusDescriptionTextBox.Text;

                this.customerArray[customerNum++] = cus;
                CustomerListBox.Items.Add(cus.FullName);
            }
            else
            {
                MessageBox.Show($"{MaxSize}명까지만 입력 가능합니다.");
            }
        }

        public void ShowDetails(Customer cus)
        {
            CusFullNameLabel.Text = cus.FullName;
            CusAgeLabel.Text = cus.Age.ToString();
            CusIsQualifiedLabel.Text = cus.IsQualified.ToString();
            CusAddressLabel.Text = cus.Address;
            CusDescriptionLabel.Text = cus.Description;
        }

        private void CustomerListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i=0;i<customerNum;i++)
            {
                if (this.customerArray[i].FullName == CustomerListBox.SelectedItem.ToString())
                    ShowDetails(customerArray[i]);
            }
        }
    }
}
