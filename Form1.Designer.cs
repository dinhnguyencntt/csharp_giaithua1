namespace csharp_giaithua1
{
    partial class Form1
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
            this.btntinhgiaithua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtso = new System.Windows.Forms.TextBox();
            this.txtgiaithua = new System.Windows.Forms.TextBox();
            this.lblgiaithua = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntinhgiaithua
            // 
            this.btntinhgiaithua.Location = new System.Drawing.Point(215, 303);
            this.btntinhgiaithua.Name = "btntinhgiaithua";
            this.btntinhgiaithua.Size = new System.Drawing.Size(264, 23);
            this.btntinhgiaithua.TabIndex = 0;
            this.btntinhgiaithua.Text = "tính giai thừa";
            this.btntinhgiaithua.UseVisualStyleBackColor = true;
            this.btntinhgiaithua.Click += new System.EventHandler(this.btntinhgiaithua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nhập số";
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(379, 59);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(100, 20);
            this.txtso.TabIndex = 2;
            // 
            // txtgiaithua
            // 
            this.txtgiaithua.Location = new System.Drawing.Point(379, 127);
            this.txtgiaithua.Name = "txtgiaithua";
            this.txtgiaithua.Size = new System.Drawing.Size(100, 20);
            this.txtgiaithua.TabIndex = 3;
            // 
            // lblgiaithua
            // 
            this.lblgiaithua.AutoSize = true;
            this.lblgiaithua.Location = new System.Drawing.Point(225, 130);
            this.lblgiaithua.Name = "lblgiaithua";
            this.lblgiaithua.Size = new System.Drawing.Size(47, 13);
            this.lblgiaithua.TabIndex = 4;
            this.lblgiaithua.Text = "giai thừa";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(237, 189);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(43, 13);
            this.lblkq.TabIndex = 5;
            this.lblkq.Text = "kết quả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "tính giai thừa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.lblgiaithua);
            this.Controls.Add(this.txtgiaithua);
            this.Controls.Add(this.txtso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntinhgiaithua);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntinhgiaithua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.TextBox txtgiaithua;
        private System.Windows.Forms.Label lblgiaithua;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.Label label4;
    }
}

