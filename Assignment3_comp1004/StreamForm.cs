﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_comp1004
{
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }

        private void StreamOkButton_Click(object sender, EventArgs e)
        {
            // Exit the application
            this.Close();
        }
    }
}
