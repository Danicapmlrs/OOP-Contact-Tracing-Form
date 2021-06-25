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

        }

        private void btn_okay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Read_Load(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StreamReader ContactTraceFormRead;
            ContactTraceFormRead = File.OpenText(openFileDialog1.FileName);
            while (!ContactTraceFormRead.EndOfStream)
            {
                tb_read.Text = (ContactTraceFormRead.ReadToEnd());
            }
        }
    }
}
