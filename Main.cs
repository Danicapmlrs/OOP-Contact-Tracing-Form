using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void btn_done_Click(object sender, EventArgs e)
        {
            formSubmit();
            MessageBox.Show("Your information is saved. Thank you");
            Application.Exit();
        }

        private void formSubmit()
        {
            StreamWriter ContactTraceForm;
            ContactTraceForm = File.AppendText(@"C:\Users\user\Documents\CovidTraceForm.txt");
            ContactTraceForm.WriteLine("~~~~~~~~~~~");
            ContactTraceForm.WriteLine(lbl_name.Text);
            ContactTraceForm.WriteLine(tb_name.Text);
            ContactTraceForm.WriteLine(lbl_gender.Text);
            ContactTraceForm.WriteLine(tb_gender.Text);
            ContactTraceForm.WriteLine(lbl_age.Text);
            ContactTraceForm.WriteLine(tb_age.Text);
            ContactTraceForm.WriteLine(lbl_address.Text);
            ContactTraceForm.WriteLine(tb_address.Text);
            ContactTraceForm.WriteLine(lbl_number.Text);
            ContactTraceForm.WriteLine(tb_number.Text);
            ContactTraceForm.WriteLine(lbl_email.Text);
            ContactTraceForm.WriteLine(tb_email.Text);
            ContactTraceForm.Close();

        }
    }
}
