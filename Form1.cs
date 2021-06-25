using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Contact_Tracing_Form
{
    public partial class FormInst : Form
    {
        public FormInst()
        {
            InitializeComponent();
        }

        private void tb_info_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mainform = new mainform();
            mainform.Show();
        }
    }
}
