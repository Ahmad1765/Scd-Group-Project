namespace Lect25_W3_LA.GUI
{
    partial class FacultyMainGUI
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
            this.dgv_Requests = new System.Windows.Forms.DataGridView();
            this.btn_SelectAll = new System.Windows.Forms.Button();
            this.btn_Approve = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Requests)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Requests
            // 
            this.dgv_Requests.AllowUserToAddRows = false;
            this.dgv_Requests.AllowUserToDeleteRows = false;
            this.dgv_Requests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Requests.Location = new System.Drawing.Point(174, 181);
            this.dgv_Requests.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Requests.Name = "dgv_Requests";
            this.dgv_Requests.ReadOnly = true;
            this.dgv_Requests.RowHeadersWidth = 51;
            this.dgv_Requests.RowTemplate.Height = 40;
            this.dgv_Requests.Size = new System.Drawing.Size(646, 278);
            this.dgv_Requests.TabIndex = 0;
            this.dgv_Requests.SelectionChanged += new System.EventHandler(this.dgv_Requests_SelectionChanged);
            // 
            // btn_SelectAll
            // 
            this.btn_SelectAll.Location = new System.Drawing.Point(616, 488);
            this.btn_SelectAll.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SelectAll.Name = "btn_SelectAll";
            this.btn_SelectAll.Size = new System.Drawing.Size(89, 41);
            this.btn_SelectAll.TabIndex = 1;
            this.btn_SelectAll.Text = "Select All";
            this.btn_SelectAll.UseVisualStyleBackColor = true;
            this.btn_SelectAll.Click += new System.EventHandler(this.btn_SelectAll_Click);
            // 
            // btn_Approve
            // 
            this.btn_Approve.Enabled = false;
            this.btn_Approve.Location = new System.Drawing.Point(736, 488);
            this.btn_Approve.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Approve.Name = "btn_Approve";
            this.btn_Approve.Size = new System.Drawing.Size(84, 41);
            this.btn_Approve.TabIndex = 2;
            this.btn_Approve.Text = "Approve";
            this.btn_Approve.UseVisualStyleBackColor = true;
            this.btn_Approve.Click += new System.EventHandler(this.btn_Approve_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(174, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 118);
            this.panel1.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.Location = new System.Drawing.Point(507, 37);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "LogOut";
            this.button4.UseVisualStyleBackColor = false;
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
            // FacultyMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Approve);
            this.Controls.Add(this.btn_SelectAll);
            this.Controls.Add(this.dgv_Requests);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FacultyMainGUI";
            this.Text = "FacultyMainGUI";
            this.Load += new System.EventHandler(this.FacultyMainGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Requests)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Requests;
        private System.Windows.Forms.Button btn_SelectAll;
        private System.Windows.Forms.Button btn_Approve;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}