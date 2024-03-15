using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab1
{
    public partial class nForm : Lab1.Form2
    {
        public nForm()
        {
            InitializeComponent();
        }

        private void nForm_Load(object sender, EventArgs e)
        {
            button1.Text = "Hello!!!";
            button1.BackColor = Color.Brown;
        }
    }
}
