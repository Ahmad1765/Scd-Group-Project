namespace Lect25_W3_LA.GUI
{
    partial class StudentMainGUI
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
            this.lb_Status = new System.Windows.Forms.Label();
            this.btn_Add_Course = new System.Windows.Forms.Button();
            this.dgv_ViewOffered = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_DropCourse = new System.Windows.Forms.Button();
            this.dgv_View_Registered = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewOffered)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Registered)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(115, 153);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 362);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.lb_Status);
            this.tabPage1.Controls.Add(this.btn_Add_Course);
            this.tabPage1.Controls.Add(this.dgv_ViewOffered);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(753, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Offered Courses";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(4, 20);
            this.lb_Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(50, 16);
            this.lb_Status.TabIndex = 3;
            this.lb_Status.Text = "Status: ";
            // 
            // btn_Add_Course
            // 
            this.btn_Add_Course.Enabled = false;
            this.btn_Add_Course.Location = new System.Drawing.Point(319, 253);
            this.btn_Add_Course.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Add_Course.Name = "btn_Add_Course";
            this.btn_Add_Course.Size = new System.Drawing.Size(96, 44);
            this.btn_Add_Course.TabIndex = 1;
            this.btn_Add_Course.Text = "Add Course Request";
            this.btn_Add_Course.UseVisualStyleBackColor = true;
            this.btn_Add_Course.Click += new System.EventHandler(this.btn_Add_Course_Click);
            // 
            // dgv_ViewOffered
            // 
            this.dgv_ViewOffered.AllowUserToAddRows = false;
            this.dgv_ViewOffered.AllowUserToDeleteRows = false;
            this.dgv_ViewOffered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ViewOffered.Location = new System.Drawing.Point(4, 57);
            this.dgv_ViewOffered.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_ViewOffered.Name = "dgv_ViewOffered";
            this.dgv_ViewOffered.ReadOnly = true;
            this.dgv_ViewOffered.RowHeadersWidth = 51;
            this.dgv_ViewOffered.RowTemplate.Height = 40;
            this.dgv_ViewOffered.Size = new System.Drawing.Size(745, 177);
            this.dgv_ViewOffered.TabIndex = 0;
            this.dgv_ViewOffered.SelectionChanged += new System.EventHandler(this.dgv_ViewOffered_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.btn_DropCourse);
            this.tabPage2.Controls.Add(this.dgv_View_Registered);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(753, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registered Courses";
            // 
            // btn_DropCourse
            // 
            this.btn_DropCourse.Enabled = false;
            this.btn_DropCourse.Location = new System.Drawing.Point(316, 267);
            this.btn_DropCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DropCourse.Name = "btn_DropCourse";
            this.btn_DropCourse.Size = new System.Drawing.Size(121, 44);
            this.btn_DropCourse.TabIndex = 3;
            this.btn_DropCourse.Text = "Drop Course Request";
            this.btn_DropCourse.UseVisualStyleBackColor = true;
            this.btn_DropCourse.Click += new System.EventHandler(this.btn_DropCourse_Click);
            // 
            // dgv_View_Registered
            // 
            this.dgv_View_Registered.AllowUserToAddRows = false;
            this.dgv_View_Registered.AllowUserToDeleteRows = false;
            this.dgv_View_Registered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Registered.Location = new System.Drawing.Point(33, 43);
            this.dgv_View_Registered.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_View_Registered.Name = "dgv_View_Registered";
            this.dgv_View_Registered.ReadOnly = true;
            this.dgv_View_Registered.RowHeadersWidth = 51;
            this.dgv_View_Registered.RowTemplate.Height = 40;
            this.dgv_View_Registered.Size = new System.Drawing.Size(675, 192);
            this.dgv_View_Registered.TabIndex = 2;
            this.dgv_View_Registered.SelectionChanged += new System.EventHandler(this.dgv_View_Registered_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(119, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 118);
            this.panel1.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.Location = new System.Drawing.Point(576, 39);
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
            // StudentMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentMainGUI";
            this.Text = "StudentMainGUI";
            this.Load += new System.EventHandler(this.StudentMainGUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ViewOffered)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Registered)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Add_Course;
        private System.Windows.Forms.DataGridView dgv_ViewOffered;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_DropCourse;
        private System.Windows.Forms.DataGridView dgv_View_Registered;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}