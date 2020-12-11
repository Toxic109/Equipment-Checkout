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
    public partial class Form2 : Form
    {
        private Staff[] staff = new Staff[20]; //Array of 20 items
        private int staffArrayIndex; //used to iterate through array
        private Manager[] manager = new Manager[20]; //Array of 20 items
        private int managerArrayIndex; //used to iterate through array
        private DateTime updated; //Date record updated
        private int staffItem;
        private int managerItem;
        private bool chk;



        public Form2()
        {
            InitializeComponent();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            staffArrayIndex = -1;
            managerArrayIndex = -1;
            staffItem = 0;
            managerItem = 0;
            updated = DateTime.Now;
            txtDate.Text = updated.ToString("dd/MM/yyyy HH:mm");
        }

        private void populateList()
        {
            if (rdoStaff.Checked == true)
            {
                lstStaff.Items.Clear();

                for (int i = 0; i <= staffArrayIndex; i++)
                {
                    lstStaff.Items.Add(staff[i].getFirstName()+" "+ staff[i].getSurname() + " "+ staff[i].getDate().ToString("dd/MM/yyyy"));
                }
            }
            if (rdoManager.Checked == true)
            {
                lstManagers.Items.Clear();

                for (int i = 0; i <= managerArrayIndex; i++)
                {
                    lstManagers.Items.Add(manager[i].getFirstName()+" "+ manager[i].getSurname()+" "+manager[i].getDate().ToString("dd/MM/yyyy"));
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirstName.Text) || String.IsNullOrEmpty(txtSurname.Text)
                || txtFirstName.TextLength < 2 || txtSurname.TextLength < 2  
                ||chk == false )
            {
                MessageBox.Show("Error");
            }
            else 
            {
                if (rdoStaff.Checked == true)
                {
                    staffArrayIndex++;
                    if (staffArrayIndex == staff.Length) //Resize if needed
                    {
                        Array.Resize(ref staff, staffArrayIndex + 10);
                    }

                    Staff newstaff = new Staff();//Create new temporary equipment instance
                    newstaff.setFirstName(txtFirstName.Text);
                    newstaff.setSurname(txtSurname.Text);
                    newstaff.updateDate(DateTime.Today);
                    
                    staff[staffArrayIndex] = newstaff;//Assign to permanent array "Equipment"
                }
                if (rdoManager.Checked == true)
                {
                    managerArrayIndex++;
                    if (managerArrayIndex == manager.Length) //Resize if needed
                    {
                        Array.Resize(ref manager, managerArrayIndex + 10);
                    }

                    Manager newmanager = new Manager();//Create new temporary equipment instance
                    newmanager.setFirstName(txtFirstName.Text);
                    newmanager.setSurname(txtSurname.Text);
                    newmanager.updateDate(DateTime.Today);

                    manager[managerArrayIndex] = newmanager;//Assign to permanent array "Equipment"
                }

                txtFirstName.Text = ""; //Clear fields
                txtSurname.Text = "";

                populateList(); //Refresh list
            }

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (staffItem == 0 || managerItem==0)
            {
                MessageBox.Show("Error");
            }
            else
            {
                this.Hide();
                Form3 frm3 = new Form3(staff[lstStaff.SelectedIndex].getFirstName().ToString(),
                    staff[lstStaff.SelectedIndex].getSurname().ToString(),
                    manager[lstManagers.SelectedIndex].getFirstName().ToString(),
                    manager[lstManagers.SelectedIndex].getSurname().ToString()
                    );
                frm3.ShowDialog();
                this.Close();
            }
        }

        private void lstStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStaff.SelectedIndex > -1)
            {
                staffItem = 1;
            }
            else
            {
                lstStaff.SelectedIndex = -1;
            }
        }

        private void lstManagers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstManagers.SelectedIndex > -1)
            {
                managerItem = 1;
            }
            else
            {
                lstManagers.SelectedIndex = -1;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void rdoStaff_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStaff.Checked == true)
            {
                chk = true;
            }
            else
            {
                chk = false;
            }
        }

        private void rdoManager_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoManager.Checked == true)
            {
                chk = true;
            }
            else
            {
                chk = false;
            }
        }
    }
}
