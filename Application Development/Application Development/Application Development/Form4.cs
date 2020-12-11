using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application_Development;
using System.IO;

namespace Application_Development
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Length < 3 || txtPass.Text.Length < 5)
            {
                MessageBox.Show("Username or Password is invaled or too short!");
            }
            else
            {
                string dir = txtUser.Text;
                if (!Directory.Exists("data\\" + dir))
                    MessageBox.Show("User was not found!", dir);
                else
                {
                    var sr = new StreamReader("data\\" + dir + "\\data.ls");

                    string encusr = sr.ReadLine();
                    string encpass = sr.ReadLine();
                    sr.Close();

                    string decusr = AES.Decrypt(encusr);
                    string decpass = AES.Decrypt(encpass);

                    if (decusr == txtUser.Text && decpass == txtPass.Text)
                    {
                        MessageBox.Show("Welcome to the private area!", decusr);
                        this.Hide();
                        Form1 frm1 = new Form1();
                        frm1.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error user or password is wrong!");
                    }

                }
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Length < 3 || txtPass.Text.Length < 5)
            {
                MessageBox.Show("Username or Password is invaled or too short!");
            }
            else
            {
                string dir = txtUser.Text;
                Directory.CreateDirectory("data\\" + dir);

                var sw = new StreamWriter("data\\" + dir + "\\data.ls");

                string encusr = AES.Encrypt(txtUser.Text);
                string encpass = AES.Encrypt(txtPass.Text);

                sw.WriteLine(encusr);
                sw.WriteLine(encpass);
                sw.Close();

                MessageBox.Show("User was successfully created.", txtUser.Text);
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked == true)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }
    }
}
