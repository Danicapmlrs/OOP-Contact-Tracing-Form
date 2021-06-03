
namespace OOP_Contact_Tracing_Form
{
    partial class FormInst
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInst));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.lbl_Inst = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLEASE READ THE INSTRUCTIONS CAREFULLY";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_info.Location = new System.Drawing.Point(11, 60);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(454, 150);
            this.lbl_info.TabIndex = 1;
            this.lbl_info.Text = resources.GetString("lbl_info.Text");
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Inst
            // 
            this.lbl_Inst.AutoSize = true;
            this.lbl_Inst.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Inst.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Inst.Location = new System.Drawing.Point(13, 228);
            this.lbl_Inst.Name = "lbl_Inst";
            this.lbl_Inst.Size = new System.Drawing.Size(435, 207);
            this.lbl_Inst.TabIndex = 2;
            this.lbl_Inst.Text = resources.GetString("lbl_Inst.Text");
            this.lbl_Inst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 207);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_next.Location = new System.Drawing.Point(371, 676);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(94, 29);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "NEXT";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // FormInst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Inst);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInst";
            this.Text = "Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label lbl_Inst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_next;
    }
}

