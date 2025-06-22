using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lect25_W3_LA.GUI
{
    public partial class WrongUserGUI : Form
    {
        public WrongUserGUI()
        {
            InitializeComponent();
            SetupCustomStyle();
        }

        private void WrongUserGUI_Load(object sender, EventArgs e)
        {
            // This method can be used for additional initialization if needed
        }
        private void SetupCustomStyle()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.Size = new Size(350, 180);

            // Red cross icon
            PictureBox icon = new PictureBox();
            icon.Image = SystemIcons.Error.ToBitmap();
            icon.SizeMode = PictureBoxSizeMode.StretchImage;
            icon.Size = new Size(48, 48);
            icon.Location = new Point(30, 40);
            this.Controls.Add(icon);

            // Message label
            Label label = new Label();
            label.Text = "Invalid username or password.";
            label.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            label.AutoSize = true;
            label.Location = new Point(90, 55);
            label.ForeColor = Color.Black;
            this.Controls.Add(label);

            // OK button
            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            okButton.Size = new Size(80, 35);
            okButton.Location = new Point((this.Width - okButton.Width) / 2, 120);
            okButton.BackColor = Color.FromArgb(0, 120, 215);
            okButton.ForeColor = Color.White;
            okButton.FlatStyle = FlatStyle.Flat;
            okButton.FlatAppearance.BorderSize = 0;
            okButton.Cursor = Cursors.Hand;
            okButton.Click += (s, e) => this.Close();
            this.Controls.Add(okButton);
        }
    }
}
