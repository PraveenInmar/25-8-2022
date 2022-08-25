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
    public partial class FrmpreviewCustomer : Form
    {
        public FrmpreviewCustomer()
        {
            InitializeComponent();
        }

        private void FrmpreviewCustomer_Load(object sender, EventArgs e)
        {

        }
        public void SetValues(string CustomerName,string Country,string Gender,string Hobby,string Status)
        {
            Id1.Text = CustomerName;
            ld2.Text = Country;
            ld3.Text = Gender;
            ld4.Text = Hobby;
            ld5.Text = Status;
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Id1_Click(object sender, EventArgs e)
        {

        }
    }
}
