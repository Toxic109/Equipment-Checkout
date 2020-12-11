
namespace Application_Development
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstMalvern = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstWorcester = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstBromsgrove = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstRedditch = new System.Windows.Forms.ListBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoMalvern = new System.Windows.Forms.RadioButton();
            this.rdoWorcester = new System.Windows.Forms.RadioButton();
            this.rdoBromsgrove = new System.Windows.Forms.RadioButton();
            this.rdoRedditch = new System.Windows.Forms.RadioButton();
            this.txtFeatures = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(165, 561);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 28);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update Availability";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(484, 561);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(100, 28);
            this.btnAddStaff.TabIndex = 6;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstMalvern);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lstWorcester);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lstBromsgrove);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lstRedditch);
            this.groupBox3.Controls.Add(this.txtDate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(13, 211);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(730, 345);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Equipment Detail";
            // 
            // lstMalvern
            // 
            this.lstMalvern.FormattingEnabled = true;
            this.lstMalvern.ItemHeight = 16;
            this.lstMalvern.Location = new System.Drawing.Point(377, 222);
            this.lstMalvern.Margin = new System.Windows.Forms.Padding(4);
            this.lstMalvern.Name = "lstMalvern";
            this.lstMalvern.Size = new System.Drawing.Size(345, 116);
            this.lstMalvern.TabIndex = 9;
            this.lstMalvern.Tag = "m";
            this.lstMalvern.SelectedIndexChanged += new System.EventHandler(this.lstMalvern_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Malvern";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Worcester";
            // 
            // lstWorcester
            // 
            this.lstWorcester.FormattingEnabled = true;
            this.lstWorcester.ItemHeight = 16;
            this.lstWorcester.Location = new System.Drawing.Point(20, 222);
            this.lstWorcester.Margin = new System.Windows.Forms.Padding(4);
            this.lstWorcester.Name = "lstWorcester";
            this.lstWorcester.Size = new System.Drawing.Size(349, 116);
            this.lstWorcester.TabIndex = 6;
            this.lstWorcester.Tag = "w";
            this.lstWorcester.SelectedIndexChanged += new System.EventHandler(this.lstWorcester_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bromsgrove";
            // 
            // lstBromsgrove
            // 
            this.lstBromsgrove.FormattingEnabled = true;
            this.lstBromsgrove.ItemHeight = 16;
            this.lstBromsgrove.Location = new System.Drawing.Point(377, 74);
            this.lstBromsgrove.Margin = new System.Windows.Forms.Padding(4);
            this.lstBromsgrove.Name = "lstBromsgrove";
            this.lstBromsgrove.Size = new System.Drawing.Size(345, 116);
            this.lstBromsgrove.TabIndex = 4;
            this.lstBromsgrove.Tag = "b";
            this.lstBromsgrove.SelectedIndexChanged += new System.EventHandler(this.lstBromsgrove_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Redditch";
            // 
            // lstRedditch
            // 
            this.lstRedditch.FormattingEnabled = true;
            this.lstRedditch.ItemHeight = 16;
            this.lstRedditch.Location = new System.Drawing.Point(20, 74);
            this.lstRedditch.Margin = new System.Windows.Forms.Padding(4);
            this.lstRedditch.Name = "lstRedditch";
            this.lstRedditch.Size = new System.Drawing.Size(349, 116);
            this.lstRedditch.TabIndex = 2;
            this.lstRedditch.Tag = "r";
            this.lstRedditch.SelectedIndexChanged += new System.EventHandler(this.lstRedditch_SelectedIndexChanged);
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(209, 23);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.ShortcutsEnabled = false;
            this.txtDate.Size = new System.Drawing.Size(245, 22);
            this.txtDate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date Updated:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAvailable);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtFeatures);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEquipment);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(104, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(547, 166);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Equipment";
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Location = new System.Drawing.Point(380, 87);
            this.chkAvailable.Margin = new System.Windows.Forms.Padding(4);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(138, 21);
            this.chkAvailable.TabIndex = 6;
            this.chkAvailable.Text = "Available for Hire";
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(380, 128);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoMalvern);
            this.groupBox2.Controls.Add(this.rdoWorcester);
            this.groupBox2.Controls.Add(this.rdoBromsgrove);
            this.groupBox2.Controls.Add(this.rdoRedditch);
            this.groupBox2.Location = new System.Drawing.Point(9, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(300, 80);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Site";
            // 
            // rdoMalvern
            // 
            this.rdoMalvern.AutoSize = true;
            this.rdoMalvern.Location = new System.Drawing.Point(200, 54);
            this.rdoMalvern.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMalvern.Name = "rdoMalvern";
            this.rdoMalvern.Size = new System.Drawing.Size(79, 21);
            this.rdoMalvern.TabIndex = 3;
            this.rdoMalvern.TabStop = true;
            this.rdoMalvern.Text = "Malvern";
            this.rdoMalvern.UseVisualStyleBackColor = true;
            this.rdoMalvern.CheckedChanged += new System.EventHandler(this.rdoMalvern_CheckedChanged);
            // 
            // rdoWorcester
            // 
            this.rdoWorcester.AutoSize = true;
            this.rdoWorcester.Location = new System.Drawing.Point(200, 25);
            this.rdoWorcester.Margin = new System.Windows.Forms.Padding(4);
            this.rdoWorcester.Name = "rdoWorcester";
            this.rdoWorcester.Size = new System.Drawing.Size(94, 21);
            this.rdoWorcester.TabIndex = 2;
            this.rdoWorcester.TabStop = true;
            this.rdoWorcester.Text = "Worcester";
            this.rdoWorcester.UseVisualStyleBackColor = true;
            this.rdoWorcester.CheckedChanged += new System.EventHandler(this.rdoWorcester_CheckedChanged);
            // 
            // rdoBromsgrove
            // 
            this.rdoBromsgrove.AutoSize = true;
            this.rdoBromsgrove.Location = new System.Drawing.Point(9, 56);
            this.rdoBromsgrove.Margin = new System.Windows.Forms.Padding(4);
            this.rdoBromsgrove.Name = "rdoBromsgrove";
            this.rdoBromsgrove.Size = new System.Drawing.Size(105, 21);
            this.rdoBromsgrove.TabIndex = 1;
            this.rdoBromsgrove.TabStop = true;
            this.rdoBromsgrove.Text = "Bromsgrove";
            this.rdoBromsgrove.UseVisualStyleBackColor = true;
            this.rdoBromsgrove.CheckedChanged += new System.EventHandler(this.rdoBromsgrove_CheckedChanged);
            // 
            // rdoRedditch
            // 
            this.rdoRedditch.AutoSize = true;
            this.rdoRedditch.Location = new System.Drawing.Point(9, 25);
            this.rdoRedditch.Margin = new System.Windows.Forms.Padding(4);
            this.rdoRedditch.Name = "rdoRedditch";
            this.rdoRedditch.Size = new System.Drawing.Size(85, 21);
            this.rdoRedditch.TabIndex = 0;
            this.rdoRedditch.TabStop = true;
            this.rdoRedditch.Text = "Redditch";
            this.rdoRedditch.UseVisualStyleBackColor = true;
            this.rdoRedditch.CheckedChanged += new System.EventHandler(this.rdoRedditch_CheckedChanged);
            // 
            // txtFeatures
            // 
            this.txtFeatures.Location = new System.Drawing.Point(164, 54);
            this.txtFeatures.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeatures.Name = "txtFeatures";
            this.txtFeatures.ShortcutsEnabled = false;
            this.txtFeatures.Size = new System.Drawing.Size(245, 22);
            this.txtFeatures.TabIndex = 3;
            this.txtFeatures.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFeatures_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Features:";
            // 
            // txtEquipment
            // 
            this.txtEquipment.Location = new System.Drawing.Point(164, 21);
            this.txtEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.ShortcutsEnabled = false;
            this.txtEquipment.Size = new System.Drawing.Size(245, 22);
            this.txtEquipment.TabIndex = 1;
            this.txtEquipment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEquipment_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipment:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.LogoutToolStripMenuItem.Text = "Signout";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 596);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Equipment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoMalvern;
        private System.Windows.Forms.RadioButton rdoWorcester;
        private System.Windows.Forms.RadioButton rdoBromsgrove;
        private System.Windows.Forms.RadioButton rdoRedditch;
        private System.Windows.Forms.TextBox txtFeatures;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEquipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        public System.Windows.Forms.ListBox lstWorcester;
        public System.Windows.Forms.ListBox lstMalvern;
        public System.Windows.Forms.ListBox lstBromsgrove;
        public System.Windows.Forms.ListBox lstRedditch;
    }
}

