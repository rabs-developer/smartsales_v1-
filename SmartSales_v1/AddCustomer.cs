﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSales_v1
{
    public partial class AddCustomer : Form
    {
        Hint h = new Hint();
        App app = new App();
        DatabaseService service;
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                customer_name = customergroupfield.Text,
                phone_number = phonenumberfield.Text,
                altphone_number = altphonenumberfield.Text,
                address = addressfield.Text,
                credit_limit = creditlimitfield.Text,
                customer_group = customergroupfield.Text,
            };

            if(customer.customer_name == "" || customer.customer_name == "Customer Name" )
                app.notifyTo(statusLabel, "Enter the Customer name ", "warning");

            if (customer.phone_number == "" || customer.phone_number == "Phone Number")
                app.notifyTo(statusLabel, "Enter the Customer Phone Number","warning");

            if (customer.altphone_number == "" || customer.altphone_number == "Alternate Phone Number")
                app.notifyTo(statusLabel, "Enter the Customer Alternative Phone Number", "warning");

            if (customer.address == "" || customer.address == "Address")
                app.notifyTo(statusLabel, "Enter The Customer Address", "warning");

            if (customer.credit_limit == "" || customer.credit_limit == "Credit Limit")
                app.notifyTo(statusLabel, "Enter Customer Credit Limit","warning");

            if (customer.customer_group == "" || customer.customer_group == "Customer Group")
                app.notifyTo(statusLabel, "Enter the Customer of the The Customer registration", "warning");

            if (customer.customer_name !="" && customer.customer_name !="Customer Name" && customer.phone_number !="" && customer.phone_number != "Phone Number" && customer.altphone_number != "Alternate Phone Number" && customer.altphone_number !="" && customer.address !="" && customer.address != "Address" && customer.credit_limit !="" && customer.credit_limit != "Credit Limit" && customer.customer_group != "Customer Group" && customer.customer_group !="")
            {
                app.notifyTo(statusLabel, "Processing...", "success");
                int status = service.registerproduct(customer);
                if (status != -1)
                {
                    app.notifyTo(statusLabel, "User Created Successfully", "success");
                }
                else
                {
                    app.notifyTo(statusLabel, "Failed to create the User", "success");
                }
            }
            else
            {
                app.notifyTo(statusLabel, "All fields are required!", "warning");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
