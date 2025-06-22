namespace Lect25_W3_LA.GUI
{
    partial class AdminMainGUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_Role = new System.Windows.Forms.ComboBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_BlockName = new System.Windows.Forms.TextBox();
            this.btn_Block = new System.Windows.Forms.Button();
            this.cmb_BlockRole = new System.Windows.Forms.ComboBox();
            this.txt_Block_Username = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(177, 137);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tabPage1.Controls.Add(this.txt_Name);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cmb_Role);
            this.tabPage1.Controls.Add(this.txt_Password);
            this.tabPage1.Controls.Add(this.txt_UserID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(638, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Account";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(235, 151);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(188, 22);
            this.txt_Name.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 283);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_Role
            // 
            this.cmb_Role.FormattingEnabled = true;
            this.cmb_Role.Items.AddRange(new object[] {
            "Student",
            "Faculty",
            "Academic Officer"});
            this.cmb_Role.Location = new System.Drawing.Point(235, 238);
            this.cmb_Role.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Role.Name = "cmb_Role";
            this.cmb_Role.Size = new System.Drawing.Size(188, 24);
            this.cmb_Role.TabIndex = 6;
            this.cmb_Role.Text = "Student";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(235, 196);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(188, 22);
            this.txt_Password.TabIndex = 5;
            // 
            // txt_UserID
            // 
            this.txt_UserID.Location = new System.Drawing.Point(235, 106);
            this.txt_UserID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(188, 22);
            this.txt_UserID.TabIndex = 4;
            this.txt_UserID.TextChanged += new System.EventHandler(this.txt_UserID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Account Admin Panel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tabPage2.Controls.Add(this.txt_Status);
            this.tabPage2.Controls.Add(this.btn_Search);
            this.tabPage2.Controls.Add(this.txt_BlockName);
            this.tabPage2.Controls.Add(this.btn_Block);
            this.tabPage2.Controls.Add(this.cmb_BlockRole);
            this.tabPage2.Controls.Add(this.txt_Block_Username);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(638, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Block Account";
            // 
            // txt_Status
            // 
            this.txt_Status.Enabled = false;
            this.txt_Status.Location = new System.Drawing.Point(249, 227);
            this.txt_Status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(188, 22);
            this.txt_Status.TabIndex = 20;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(298, 285);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(94, 36);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_BlockName
            // 
            this.txt_BlockName.Enabled = false;
            this.txt_BlockName.Location = new System.Drawing.Point(249, 186);
            this.txt_BlockName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_BlockName.Name = "txt_BlockName";
            this.txt_BlockName.Size = new System.Drawing.Size(188, 22);
            this.txt_BlockName.TabIndex = 17;
            // 
            // btn_Block
            // 
            this.btn_Block.Enabled = false;
            this.btn_Block.Location = new System.Drawing.Point(542, 374);
            this.btn_Block.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Block.Name = "btn_Block";
            this.btn_Block.Size = new System.Drawing.Size(128, 45);
            this.btn_Block.TabIndex = 15;
            this.btn_Block.Text = "Block/Unblock";
            this.btn_Block.UseVisualStyleBackColor = true;
            this.btn_Block.Click += new System.EventHandler(this.btn_Block_Click);
            // 
            // cmb_BlockRole
            // 
            this.cmb_BlockRole.Enabled = false;
            this.cmb_BlockRole.FormattingEnabled = true;
            this.cmb_BlockRole.Items.AddRange(new object[] {
            "Student",
            "Faculty",
            "Academic Officer"});
            this.cmb_BlockRole.Location = new System.Drawing.Point(249, 144);
            this.cmb_BlockRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_BlockRole.Name = "cmb_BlockRole";
            this.cmb_BlockRole.Size = new System.Drawing.Size(188, 24);
            this.cmb_BlockRole.TabIndex = 14;
            this.cmb_BlockRole.SelectedIndexChanged += new System.EventHandler(this.cmb_BlockRole_SelectedIndexChanged);
            // 
            // txt_Block_Username
            // 
            this.txt_Block_Username.Location = new System.Drawing.Point(249, 95);
            this.txt_Block_Username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Block_Username.Name = "txt_Block_Username";
            this.txt_Block_Username.Size = new System.Drawing.Size(188, 22);
            this.txt_Block_Username.TabIndex = 13;
            this.txt_Block_Username.TextChanged += new System.EventHandler(this.txt_Block_Username_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(148, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(363, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Block/Unblock Account Admin Panel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(177, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 118);
            this.panel1.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.Location = new System.Drawing.Point(424, 38);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "LogOut";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 87);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Friday, June 13, 2025  ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 16);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(228, 36);
            this.label13.TabIndex = 0;
            this.label13.Text = "Good Morning,";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // AdminMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminMainGUI";
            this.Text = "AdminMainGUI";
            this.Load += new System.EventHandler(this.AdminMainGUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_Role;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_BlockName;
        private System.Windows.Forms.Button btn_Block;
        private System.Windows.Forms.ComboBox cmb_BlockRole;
        private System.Windows.Forms.TextBox txt_Block_Username;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}