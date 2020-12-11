using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Application_Development
{
    public partial class Form1 : Form
    {
        //Global variables for the form
        private Redditch[] redditch = new Redditch[20]; //Array of 20 items
        private int redditchArrayIndex; //used to iterate through array
        private DateTime updated; //Date record updated

        private Bromsgrove[] bromsgrove = new Bromsgrove[20]; //Array of 20 items
        private int bromsgroveArrayIndex; //used to iterate through array

        private Worcester[] worcester = new Worcester[20]; //Array of 20 items
        private int worcesterArrayIndex; //used to iterate through array

        private Malvern[] malvern = new Malvern[20]; //Array of 20 items
        private int malvernArrayIndex; //used to iterate through array

        private int index;
        private bool site;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            redditchArrayIndex = -1;
            bromsgroveArrayIndex = -1;
            worcesterArrayIndex = -1;
            malvernArrayIndex = -1;
            updated = DateTime.Now;
            txtDate.Text = updated.ToString("dd/MM/yyyy HH:mm");
        }

        private void populateList()
        {
            if (rdoRedditch.Checked == true)
            {
                lstRedditch.Items.Clear();

                for (int i = 0; i <= redditchArrayIndex; i++)
                {
                    if (redditch[i].getAvailable() == true)
                    {
                        lstRedditch.Items.Add(redditch[i].getName() + " - Available");
                    }
                    else
                    {
                        redditch[i].updateDate(DateTime.Today);
                        lstRedditch.Items.Add(redditch[i].getName() + " - Not Available - "
                            + redditch[i].getDate().ToString("dd/MM/yyyy"));
                    }
                }
            }
            else if (rdoBromsgrove.Checked == true)
            {
                lstBromsgrove.Items.Clear();

                for (int i = 0; i <= bromsgroveArrayIndex; i++)
                {
                    if (bromsgrove[i].getAvailable() == true)
                    {
                        lstBromsgrove.Items.Add(bromsgrove[i].getName() + " - Available");
                    }
                    else
                    {
                        bromsgrove[i].updateDate(DateTime.Today);
                        lstBromsgrove.Items.Add(bromsgrove[i].getName() + " - Not Available - "
                            + bromsgrove[i].getDate().ToString("dd/MM/yyyy"));
                    }
                }
            }
            else if (rdoWorcester.Checked == true)
            {
                lstWorcester.Items.Clear();

                for (int i = 0; i <= worcesterArrayIndex; i++)
                {
                    if (worcester[i].getAvailable() == true)
                    {
                        lstWorcester.Items.Add(worcester[i].getName() + " - Available");
                    }
                    else
                    {
                        worcester[i].updateDate(DateTime.Today);
                        lstWorcester.Items.Add(worcester[i].getName() + " - Not Available - "
                            + worcester[i].getDate().ToString("dd/MM/yyyy"));
                    }
                }
            }
            else if (rdoMalvern.Checked == true)
            {
                lstMalvern.Items.Clear();

                for (int i = 0; i <= malvernArrayIndex; i++)
                {
                    if (malvern[i].getAvailable() == true)
                    {
                        lstMalvern.Items.Add(malvern[i].getName() + " - Available");

                    }
                    else
                    {
                        malvern[i].updateDate(DateTime.Today);
                        lstMalvern.Items.Add(malvern[i].getName() + " - Not Available - "
                            + malvern[i].getDate().ToString("dd/MM/yyyy"));
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEquipment.Text) || String.IsNullOrEmpty(txtFeatures.Text)
                || txtEquipment.TextLength < 3 || txtFeatures.TextLength < 3 || site==false)
            {
                MessageBox.Show("Error");
            }
            else 
            {
                if (rdoWorcester.Checked == true)
                {
                    worcesterArrayIndex++;
                    if (worcesterArrayIndex == worcester.Length) //Resize if needed
                    {
                        Array.Resize(ref worcester, worcesterArrayIndex + 10);
                    }

                    Worcester newworcester = new Worcester();
                    newworcester.setName(txtEquipment.Text + " - Features: " + txtFeatures.Text);
                    worcester[worcesterArrayIndex] = newworcester;
                    newworcester.setAvailable(chkAvailable.Checked);
                }
                if (rdoBromsgrove.Checked == true)
                {
                    bromsgroveArrayIndex++;
                    if (bromsgroveArrayIndex == bromsgrove.Length) //Resize if needed
                    {
                        Array.Resize(ref bromsgrove, bromsgroveArrayIndex + 10);
                    }

                    Bromsgrove newbromsgrove = new Bromsgrove();
                    newbromsgrove.setName(txtEquipment.Text + " - Features: " + txtFeatures.Text);
                    bromsgrove[bromsgroveArrayIndex] = newbromsgrove;
                    newbromsgrove.setAvailable(chkAvailable.Checked);
                }
                if (rdoMalvern.Checked == true)
                {
                    malvernArrayIndex++;
                    if (malvernArrayIndex == malvern.Length) //Resize if needed
                    {
                        Array.Resize(ref malvern, malvernArrayIndex + 10);
                    }

                    Malvern newmalvern = new Malvern();//Create new temporary equipment instance
                    newmalvern.setName(txtEquipment.Text + " - Features: " + txtFeatures.Text);
                    malvern[malvernArrayIndex] = newmalvern;//Assign to permanent array "Equipment"
                    newmalvern.setAvailable(chkAvailable.Checked);
                }
                if (rdoRedditch.Checked == true)
                {
                    redditchArrayIndex++;
                    if (redditchArrayIndex == redditch.Length) //Resize if needed
                    {
                        Array.Resize(ref redditch, redditchArrayIndex + 10);
                    }

                    Redditch newredditch = new Redditch();//Create new temporary equipment instance
                    newredditch.setName(txtEquipment.Text + " - Features: " + txtFeatures.Text);
                    redditch[redditchArrayIndex] = newredditch;//Assign to permanent array "Equipment"
                    newredditch.setAvailable(chkAvailable.Checked);
                }

                txtEquipment.Text = ""; //Clear fields
                txtFeatures.Text = "";

                populateList(); //Refresh list
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (index == 3)
            {
                Worcester newworcester = new Worcester();
                newworcester.setName(txtEquipment.Text + " - Features: " + txtFeatures.Text);
                worcester[lstWorcester.SelectedIndex] = newworcester;
                newworcester.setAvailable(chkAvailable.Checked);
                lstWorcester.Items.Clear();
                for (int i = 0; i <= worcesterArrayIndex; i++)
                {
                    if (worcester[i].getAvailable() == true)
                    {
                        lstWorcester.Items.Add(worcester[i].getName() + " - Available");
                    }
                    else
                    {
                        worcester[i].updateDate(DateTime.Today);
                        lstWorcester.Items.Add(worcester[i].getName() + " - Not Available - "
                            + worcester[i].getDate().ToString("dd/MM/yyyy"));
                    }
                }
            }
            if (index == 1)
            {
                Malvern newmalvern = new Malvern();//Create new temporary equipment instance
                newmalvern.setName(txtEquipment.Text + " - Features: " + txtFeatures.Text);
                malvern[lstMalvern.SelectedIndex] = newmalvern;//Assign to permanent array "Equipment"
                newmalvern.setAvailable(chkAvailable.Checked);
                lstMalvern.Items.Clear();
                for (int i = 0; i <= malvernArrayIndex; i++)
                {
                    if (malvern[i].getAvailable() == true)
                    {
                        lstMalvern.Items.Add(malvern[i].getName() + " - Available");

                    }
                    else
                    {
                        malvern[i].updateDate(DateTime.Today);
                        lstMalvern.Items.Add(malvern[i].getName() + " - Not Available - "
                            + malvern[i].getDate().ToString("dd/MM/yyyy"));
                    }
                }
            }
            if (index == 2)
            {
                Redditch newredditch = new Redditch();//Create new temporary equipment instance
                newredditch.setName(txtEquipment.Text + " - Features: " + txtFeatures.Text);
                redditch[lstRedditch.SelectedIndex] = newredditch;//Assign to permanent array "Equipment"
                newredditch.setAvailable(chkAvailable.Checked);
                lstRedditch.Items.Clear();

                for (int i = 0; i <= redditchArrayIndex; i++)
                {
                    if (redditch[i].getAvailable() == true)
                    {
                        lstRedditch.Items.Add(redditch[i].getName() + " - Available");
                    }
                    else
                    {
                        redditch[i].updateDate(DateTime.Today);
                        lstRedditch.Items.Add(redditch[i].getName() + " - Not Available - "
                            + redditch[i].getDate().ToString("dd/MM/yyyy"));
                    }
                }
            }
            if (index == 4)
            {
                Bromsgrove newbromsgrove = new Bromsgrove();
                newbromsgrove.setName(txtEquipment.Text + " - Features: " + txtFeatures.Text);
                bromsgrove[lstBromsgrove.SelectedIndex] = newbromsgrove;
                newbromsgrove.setAvailable(chkAvailable.Checked);
                lstBromsgrove.Items.Clear();

                for (int i = 0; i <= bromsgroveArrayIndex; i++)
                {
                    if (bromsgrove[i].getAvailable() == true)
                    {
                        lstBromsgrove.Items.Add(bromsgrove[i].getName() + " - Available");
                    }
                    else
                    {
                        bromsgrove[i].updateDate(DateTime.Today);
                        lstBromsgrove.Items.Add(bromsgrove[i].getName() + " - Not Available - "
                            + bromsgrove[i].getDate().ToString("dd/MM/yyyy"));
                    }
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            Array[] worc;


            /*
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            this.Close();
            */
        }

        private void lstRedditch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRedditch.SelectedIndex > -1)
            {
                index = 2;
                lstWorcester.SelectedIndex = -1;
                lstBromsgrove.SelectedIndex = -1;
                lstMalvern.SelectedIndex = -1;
            }
            else
            {
                lstRedditch.SelectedIndex = -1;
            }


        }

        private void lstBromsgrove_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBromsgrove.SelectedIndex > -1)
            {
                index = 4;
                lstWorcester.SelectedIndex = -1;
                lstRedditch.SelectedIndex = -1;
                lstMalvern.SelectedIndex = -1;
            }
            else
            {
                lstBromsgrove.SelectedIndex = -1;
            }



        }

        private void lstWorcester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstWorcester.SelectedIndex > -1)
            {
                index = 3;
                lstRedditch.SelectedIndex = -1;
                lstBromsgrove.SelectedIndex = -1;
                lstMalvern.SelectedIndex = -1;
            }
            else
            {
                lstWorcester.SelectedIndex = -1;
            }


        }

        private void lstMalvern_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMalvern.SelectedIndex > -1)
            {
                index = 1;
                lstWorcester.SelectedIndex = -1;
                lstBromsgrove.SelectedIndex = -1;
                lstRedditch.SelectedIndex = -1;
            }
            else
            {
                lstMalvern.SelectedIndex = -1;
            }


        }

        private void rdoWorcester_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoWorcester.Checked)
            {
                site = true;
            }
            else
            {
                site = false;
            }
        }

        private void rdoMalvern_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMalvern.Checked==true)
            {
                site = true;
            }
            else
            {
                site = false;
            }
        }

        private void rdoBromsgrove_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBromsgrove.Checked ==true )
            {
                site = true;
            }
            else
            {
                site = false;
            }
        }

        private void rdoRedditch_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRedditch.Checked==true)
            {
                site = true;
            }
            else
            {
                site = false;
            }
        }

        private void txtEquipment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtFeatures_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
            this.Close();
        }
    }
}
