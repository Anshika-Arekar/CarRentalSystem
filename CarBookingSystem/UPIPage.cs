﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBookingSystem
{
    public partial class UPIPage : Form
    {
        public UPIPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Successful.");
            MessageBox.Show("Hope you enjoy the ride!");
        }
    }
}
