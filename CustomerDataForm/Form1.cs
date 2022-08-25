using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerDataForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonSingle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonPreview_Click(object sender, EventArgs e)
        {
            string gender = "";
            string status = "";
            string hobby = "";
            if (radioButtonMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if(RadioButtonMarried.Checked)
            {
                status = "Married";
            }
            else
            {
                status = "Single";
            }
            
            if(checkBox1.Checked)
            {
                hobby = "Cricket";
            }
            else
            {
                hobby = "painting";
            }

            FrmpreviewCustomer frn = new FrmpreviewCustomer();
            frn.SetValues(IdName.Text,
                          IdCountry.Text.ToString(),
                          gender,
                          hobby,
                          status);
            frn.ShowDialog();
        }
    }
}
