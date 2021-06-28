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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        public string ContactTracef;
        private void reset()
        {
            tb_name.Text = "";
            tb_gender.Text = "";
            tb_age.Text = "";
            tb_address.Text = "";
            tb_number.Text = "";
            tb_email.Text = "";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
            MessageBox.Show("Form was reset. Please input information again.","Reset");
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            MessageBox.Show("Your information is saved. To view information, please press READ button. Thank you");
            reset();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please make sure you press DONE before pressing read to see your information and after clicking okay" +
                " find the filename you entered awhile ago to view the information");
            Read mainform2 = new Read();
            mainform2.Show();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StreamWriter ContactTraceForm;
            ContactTraceForm = File.AppendText(saveFileDialog1.FileName);
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
