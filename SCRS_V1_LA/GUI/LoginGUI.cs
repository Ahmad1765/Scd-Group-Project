using Lect25_W3_LA.BL;
using Lect25_W3_LA.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lect25_W3_LA
{
    public partial class LoginGUI : Form
    {
        private const string PlaceholderText = "Enter username";
        private const string PlaceholderText2 = "Password";
        private readonly Color PlaceholderColor = Color.Gray;
        private readonly Color NormalColor = Color.Black;

        private LoginDTO lgDTO;
        private LoginBL lgBL;

        public LoginGUI()
        {
            InitializeComponent();

            lgDTO = new LoginDTO();
            lgBL = new LoginBL();

            // Attach event handlers for both textboxes
            SetPlaceholders();
            txt_Usernname.GotFocus += TextBox1_GotFocus;
            txt_Usernname.LostFocus += TextBox1_LostFocus;
            txt_Password.GotFocus += TextBox2_GotFocus;
            txt_Password.LostFocus += TextBox2_LostFocus;
            txt_Password.TextChanged += TextBox2_TextChanged;

            // Attach event handler for checkbox
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
        }
        private void SetPlaceholders()
        {
            // Username placeholder
            if (string.IsNullOrWhiteSpace(txt_Usernname.Text))
            {
                txt_Usernname.Text = PlaceholderText;
                txt_Usernname.ForeColor = PlaceholderColor;
            }

            // Password placeholder
            if (string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                txt_Password.UseSystemPasswordChar = false; // Show placeholder text
                txt_Password.Text = PlaceholderText2;
                txt_Password.ForeColor = PlaceholderColor;
            }
        }

        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            if (txt_Usernname.Text == PlaceholderText)
            {
                txt_Usernname.Text = "";
                txt_Usernname.ForeColor = NormalColor;
            }
        }

        private void TextBox1_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Usernname.Text))
            {
                txt_Usernname.Text = PlaceholderText;
                txt_Usernname.ForeColor = PlaceholderColor;
            }
        }
        private void TextBox2_GotFocus(object sender, EventArgs e)
        {
            if (txt_Password.Text == PlaceholderText2)
            {
                txt_Password.Text = "";
                txt_Password.ForeColor = NormalColor;
                txt_Password.UseSystemPasswordChar = !checkBox1.Checked;
            }
        }

        private void TextBox2_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                txt_Password.UseSystemPasswordChar = false;
                txt_Password.Text = PlaceholderText2;
                txt_Password.ForeColor = PlaceholderColor;
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (txt_Password.Text != PlaceholderText2)
            {
                txt_Password.ForeColor = NormalColor;
                txt_Password.UseSystemPasswordChar = !checkBox1.Checked;
            }
        }


        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_Password.Text != PlaceholderText2)
            {
                txt_Password.UseSystemPasswordChar = !checkBox1.Checked;
            }
        }


        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Usernname.Clear();
            txt_Password.Text = "";
            SetPlaceholders();
            txt_Usernname.Focus();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Prevent login if placeholders are present or fields are empty
            if (string.IsNullOrWhiteSpace(txt_Usernname.Text) ||
                string.IsNullOrWhiteSpace(txt_Password.Text) ||
                txt_Usernname.Text == PlaceholderText ||
                txt_Password.Text == PlaceholderText2)
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            lgDTO.Username = txt_Usernname.Text.Trim();
            lgDTO.Password = txt_Password.Text.Trim();
            lgBL.VerifyUser(lgDTO).ShowDialog();
            //this.Close();
        }

        private void LoginGUI_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_Usernname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
