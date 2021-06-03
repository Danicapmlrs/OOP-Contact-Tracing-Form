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
    public partial class Read : Form
    {
        public Read()
        {
            InitializeComponent();
        }

        private void tb_read_TextChanged(object sender, EventArgs e)
        {
            StreamReader ContactTraceFormRead;
            ContactTraceFormRead = File.OpenText(@"C:\Users\user\Documents\CovidTraceForm.txt");
            while (!ContactTraceFormRead.EndOfStream)
            {
                tb_read.Text=(ContactTraceFormRead.ReadToEnd());
            }

        }

        private void btn_okay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
