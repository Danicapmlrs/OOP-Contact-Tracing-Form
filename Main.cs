using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP_Contact_Tracing_Form
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_name.Text = "";
            tb_gender.Text = "";
            tb_age.Text = "";
            tb_address.Text = "";
            tb_number.Text = "";
            tb_email.Text = "";

            MessageBox.Show("Form was reset. Please input information again.","Reset");
        }
    }
}
