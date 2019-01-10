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
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer("Ian", "Na", new DateTime(1990,1,1));
            cus.Address = "123 Wilshire Blvd.";

            CusFullNameLabel.Text = cus.FullName;
            CusAgeLabel.Text = cus.Age.ToString();
            CusIsQualifiedLabel.Text = cus.IsQualified.ToString();
            CusAddressLabel.Text = cus.Address;
            CusDescriptionLabel.Text = cus.Description;
        }
    }
}
