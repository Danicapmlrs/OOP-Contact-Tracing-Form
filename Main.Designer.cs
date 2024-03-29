﻿
namespace OOP_Contact_Tracing_Form
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_gender = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(24, 40);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(70, 23);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "NAME:";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_gender.Location = new System.Drawing.Point(24, 91);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(94, 23);
            this.lbl_gender.TabIndex = 1;
            this.lbl_gender.Text = "GENDER:";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_age.Location = new System.Drawing.Point(24, 146);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(58, 23);
            this.lbl_age.TabIndex = 2;
            this.lbl_age.Text = "AGE:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_address.Location = new System.Drawing.Point(24, 199);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(106, 23);
            this.lbl_address.TabIndex = 3;
            this.lbl_address.Text = "ADDRESS:";
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_number.Location = new System.Drawing.Point(23, 254);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(190, 23);
            this.lbl_number.TabIndex = 4;
            this.lbl_number.Text = "CONTACT NUMBER:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_email.Location = new System.Drawing.Point(24, 313);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(178, 23);
            this.lbl_email.TabIndex = 5;
            this.lbl_email.Text = "EMAIL ADDRESS:";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_name.Location = new System.Drawing.Point(224, 36);
            this.tb_name.Name = "tb_name";
            this.tb_name.PlaceholderText = "-Please enter complete name-";
            this.tb_name.Size = new System.Drawing.Size(377, 31);
            this.tb_name.TabIndex = 6;
            // 
            // tb_gender
            // 
            this.tb_gender.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_gender.Location = new System.Drawing.Point(224, 87);
            this.tb_gender.Name = "tb_gender";
            this.tb_gender.PlaceholderText = "-Please enter female/f or male/m-";
            this.tb_gender.Size = new System.Drawing.Size(377, 31);
            this.tb_gender.TabIndex = 7;
            // 
            // tb_age
            // 
            this.tb_age.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_age.Location = new System.Drawing.Point(224, 142);
            this.tb_age.Name = "tb_age";
            this.tb_age.PlaceholderText = "-Please enter age-";
            this.tb_age.Size = new System.Drawing.Size(377, 31);
            this.tb_age.TabIndex = 8;
            // 
            // tb_address
            // 
            this.tb_address.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_address.Location = new System.Drawing.Point(224, 195);
            this.tb_address.Name = "tb_address";
            this.tb_address.PlaceholderText = "-Please enter complete address-";
            this.tb_address.Size = new System.Drawing.Size(377, 31);
            this.tb_address.TabIndex = 9;
            // 
            // tb_number
            // 
            this.tb_number.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_number.Location = new System.Drawing.Point(224, 250);
            this.tb_number.Name = "tb_number";
            this.tb_number.PlaceholderText = "-Please enter home address-";
            this.tb_number.Size = new System.Drawing.Size(377, 31);
            this.tb_number.TabIndex = 10;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_email.Location = new System.Drawing.Point(224, 309);
            this.tb_email.Name = "tb_email";
            this.tb_email.PlaceholderText = "-Please put NA if you have no email address-";
            this.tb_email.Size = new System.Drawing.Size(377, 31);
            this.tb_email.TabIndex = 11;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(24, 395);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(94, 29);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(507, 395);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(94, 29);
            this.btn_done.TabIndex = 13;
            this.btn_done.Text = "DONE";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(24, 360);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(94, 29);
            this.btn_read.TabIndex = 14;
            this.btn_read.Text = "READ";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_gender);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_number);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainform";
            this.Text = "Contact Tracing Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_gender;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}