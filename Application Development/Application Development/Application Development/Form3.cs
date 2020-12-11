using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Development
{
    public partial class Form3 : Form
    {
        public Form3(string staffFirstName, string staffSurname,
            string managerFirstName, string managerSurname)
        {
            InitializeComponent();
            lblStaffFirstName.Text = staffFirstName;
            lblStaffSurname.Text = staffSurname;
            lblManagerFirstName.Text = managerFirstName;
            lblManagerSurname.Text = managerSurname;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void txtReason_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
            this.Close();
        }
    }
}
