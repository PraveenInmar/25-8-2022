
namespace CustomerDataForm
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
            this.CustomerName = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.IdName = new System.Windows.Forms.TextBox();
            this.IdCountry = new System.Windows.Forms.ComboBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.RadioButtonMarried = new System.Windows.Forms.RadioButton();
            this.radioButtonSingle = new System.Windows.Forms.RadioButton();
            this.ButtonPreview = new System.Windows.Forms.Button();
            this.IdGender = new System.Windows.Forms.GroupBox();
            this.IdHobby = new System.Windows.Forms.GroupBox();
            this.IdStatus = new System.Windows.Forms.GroupBox();
            this.IdGender.SuspendLayout();
            this.IdHobby.SuspendLayout();
            this.IdStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(39, 27);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(137, 20);
            this.CustomerName.TabIndex = 0;
            this.CustomerName.Text = "Customer Name :-";
            this.CustomerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(39, 75);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(77, 20);
            this.Country.TabIndex = 1;
            this.Country.Text = "Country :-";
            // 
            // IdName
            // 
            this.IdName.Location = new System.Drawing.Point(280, 27);
            this.IdName.Name = "IdName";
            this.IdName.Size = new System.Drawing.Size(144, 26);
            this.IdName.TabIndex = 6;
            // 
            // IdCountry
            // 
            this.IdCountry.FormattingEnabled = true;
            this.IdCountry.Items.AddRange(new object[] {
            "India ",
            "USA",
            "Nepal",
            "Srilanka"});
            this.IdCountry.Location = new System.Drawing.Point(280, 88);
            this.IdCountry.Name = "IdCountry";
            this.IdCountry.Size = new System.Drawing.Size(144, 28);
            this.IdCountry.TabIndex = 7;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(116, 25);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(68, 24);
            this.radioButtonMale.TabIndex = 8;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(227, 25);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(87, 24);
            this.radioButtonFemale.TabIndex = 9;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(116, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Cricket";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(227, 25);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(92, 24);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Painting";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMarried
            // 
            this.RadioButtonMarried.AutoSize = true;
            this.RadioButtonMarried.Location = new System.Drawing.Point(116, 16);
            this.RadioButtonMarried.Name = "RadioButtonMarried";
            this.RadioButtonMarried.Size = new System.Drawing.Size(87, 24);
            this.RadioButtonMarried.TabIndex = 12;
            this.RadioButtonMarried.TabStop = true;
            this.RadioButtonMarried.Text = "Married";
            this.RadioButtonMarried.UseVisualStyleBackColor = true;
            // 
            // radioButtonSingle
            // 
            this.radioButtonSingle.AutoSize = true;
            this.radioButtonSingle.Location = new System.Drawing.Point(238, 16);
            this.radioButtonSingle.Name = "radioButtonSingle";
            this.radioButtonSingle.Size = new System.Drawing.Size(78, 24);
            this.radioButtonSingle.TabIndex = 13;
            this.radioButtonSingle.TabStop = true;
            this.radioButtonSingle.Text = "Single";
            this.radioButtonSingle.UseVisualStyleBackColor = true;
            this.radioButtonSingle.CheckedChanged += new System.EventHandler(this.radioButtonSingle_CheckedChanged);
            // 
            // ButtonPreview
            // 
            this.ButtonPreview.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonPreview.Location = new System.Drawing.Point(43, 371);
            this.ButtonPreview.Name = "ButtonPreview";
            this.ButtonPreview.Size = new System.Drawing.Size(386, 41);
            this.ButtonPreview.TabIndex = 14;
            this.ButtonPreview.Text = "Preview";
            this.ButtonPreview.UseVisualStyleBackColor = false;
            this.ButtonPreview.Click += new System.EventHandler(this.ButtonPreview_Click);
            // 
            // IdGender
            // 
            this.IdGender.Controls.Add(this.radioButtonMale);
            this.IdGender.Controls.Add(this.radioButtonFemale);
            this.IdGender.Location = new System.Drawing.Point(43, 123);
            this.IdGender.Name = "IdGender";
            this.IdGender.Size = new System.Drawing.Size(386, 68);
            this.IdGender.TabIndex = 15;
            this.IdGender.TabStop = false;
            this.IdGender.Text = "Gender";
            this.IdGender.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // IdHobby
            // 
            this.IdHobby.Controls.Add(this.checkBox1);
            this.IdHobby.Controls.Add(this.checkBox2);
            this.IdHobby.Location = new System.Drawing.Point(43, 208);
            this.IdHobby.Name = "IdHobby";
            this.IdHobby.Size = new System.Drawing.Size(386, 69);
            this.IdHobby.TabIndex = 16;
            this.IdHobby.TabStop = false;
            this.IdHobby.Text = "Hobby";
            // 
            // IdStatus
            // 
            this.IdStatus.Controls.Add(this.RadioButtonMarried);
            this.IdStatus.Controls.Add(this.radioButtonSingle);
            this.IdStatus.Location = new System.Drawing.Point(43, 283);
            this.IdStatus.Name = "IdStatus";
            this.IdStatus.Size = new System.Drawing.Size(386, 60);
            this.IdStatus.TabIndex = 17;
            this.IdStatus.TabStop = false;
            this.IdStatus.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.IdStatus);
            this.Controls.Add(this.IdHobby);
            this.Controls.Add(this.IdGender);
            this.Controls.Add(this.ButtonPreview);
            this.Controls.Add(this.IdCountry);
            this.Controls.Add(this.IdName);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.CustomerName);
            this.Name = "Form1";
            this.Text = "Customer Data Entry Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.IdGender.ResumeLayout(false);
            this.IdGender.PerformLayout();
            this.IdHobby.ResumeLayout(false);
            this.IdHobby.PerformLayout();
            this.IdStatus.ResumeLayout(false);
            this.IdStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.TextBox IdName;
        private System.Windows.Forms.ComboBox IdCountry;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RadioButton RadioButtonMarried;
        private System.Windows.Forms.RadioButton radioButtonSingle;
        private System.Windows.Forms.Button ButtonPreview;
        private System.Windows.Forms.GroupBox IdGender;
        private System.Windows.Forms.GroupBox IdHobby;
        private System.Windows.Forms.GroupBox IdStatus;
    }
}

