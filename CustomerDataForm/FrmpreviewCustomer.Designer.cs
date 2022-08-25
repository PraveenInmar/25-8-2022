
namespace CustomerDataForm
{
    partial class FrmpreviewCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ld5 = new System.Windows.Forms.Label();
            this.ld4 = new System.Windows.Forms.Label();
            this.ld3 = new System.Windows.Forms.Label();
            this.ld2 = new System.Windows.Forms.Label();
            this.Id1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer name :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Country :-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender :-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hobby :-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status :-";
            // 
            // ld5
            // 
            this.ld5.AutoSize = true;
            this.ld5.Location = new System.Drawing.Point(252, 257);
            this.ld5.Name = "ld5";
            this.ld5.Size = new System.Drawing.Size(0, 20);
            this.ld5.TabIndex = 5;
            this.ld5.Click += new System.EventHandler(this.label6_Click);
            // 
            // ld4
            // 
            this.ld4.AutoSize = true;
            this.ld4.Location = new System.Drawing.Point(252, 193);
            this.ld4.Name = "ld4";
            this.ld4.Size = new System.Drawing.Size(0, 20);
            this.ld4.TabIndex = 6;
            // 
            // ld3
            // 
            this.ld3.AutoSize = true;
            this.ld3.Location = new System.Drawing.Point(252, 131);
            this.ld3.Name = "ld3";
            this.ld3.Size = new System.Drawing.Size(0, 20);
            this.ld3.TabIndex = 7;
            // 
            // ld2
            // 
            this.ld2.AutoSize = true;
            this.ld2.Location = new System.Drawing.Point(252, 85);
            this.ld2.Name = "ld2";
            this.ld2.Size = new System.Drawing.Size(0, 20);
            this.ld2.TabIndex = 8;
            // 
            // Id1
            // 
            this.Id1.AutoSize = true;
            this.Id1.Location = new System.Drawing.Point(252, 27);
            this.Id1.Name = "Id1";
            this.Id1.Size = new System.Drawing.Size(0, 20);
            this.Id1.TabIndex = 9;
            this.Id1.Click += new System.EventHandler(this.Id1_Click);
            // 
            // FrmpreviewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(448, 345);
            this.Controls.Add(this.Id1);
            this.Controls.Add(this.ld2);
            this.Controls.Add(this.ld3);
            this.Controls.Add(this.ld4);
            this.Controls.Add(this.ld5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmpreviewCustomer";
            this.Text = "PreviewCustomer";
            this.Load += new System.EventHandler(this.FrmpreviewCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ld5;
        private System.Windows.Forms.Label ld4;
        private System.Windows.Forms.Label ld3;
        private System.Windows.Forms.Label ld2;
        private System.Windows.Forms.Label Id1;
    }
}