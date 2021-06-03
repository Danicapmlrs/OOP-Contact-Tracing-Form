
namespace OOP_Contact_Tracing_Form
{
    partial class Read
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_read = new System.Windows.Forms.TextBox();
            this.btn_okay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_read
            // 
            this.tb_read.Location = new System.Drawing.Point(63, 25);
            this.tb_read.Multiline = true;
            this.tb_read.Name = "tb_read";
            this.tb_read.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_read.Size = new System.Drawing.Size(542, 346);
            this.tb_read.TabIndex = 0;
            this.tb_read.TextChanged += new System.EventHandler(this.tb_read_TextChanged);
            // 
            // btn_okay
            // 
            this.btn_okay.Location = new System.Drawing.Point(271, 398);
            this.btn_okay.Name = "btn_okay";
            this.btn_okay.Size = new System.Drawing.Size(94, 29);
            this.btn_okay.TabIndex = 1;
            this.btn_okay.Text = "OKAY";
            this.btn_okay.UseVisualStyleBackColor = true;
            this.btn_okay.Click += new System.EventHandler(this.btn_okay_Click);
            // 
            // Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.btn_okay);
            this.Controls.Add(this.tb_read);
            this.MaximizeBox = false;
            this.Name = "Read";
            this.Text = "Read Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_read;
        private System.Windows.Forms.Button btn_okay;
    }
}