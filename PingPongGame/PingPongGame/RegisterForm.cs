using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            UserLoginField.Text = "Enter Login";
            UserEmailField.Text = "Enter Email";
            UserPasswordField.Text = "Enter Password";
            this.Text = "Registration in program";
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            if(((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "Enter Login")
            {
                UserLoginField.Text = "";
                
                UserLoginField.ForeColor = Color.White;
            }
            if(((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "Enter Email")
            {
                UserEmailField.Text = "";
                UserEmailField.ForeColor = Color.White;
            }
            if(((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "Enter Password")
            {
                UserPasswordField.Text = "";
                UserPasswordField.UseSystemPasswordChar = true;
                UserPasswordField.ForeColor = Color.White;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "")
            {
                UserLoginField.Text = "Enter Login";
                UserLoginField.ForeColor = Color.Gray;
            }
            if (((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "")
            {
                UserEmailField.Text = "Enter Email";
                UserEmailField.ForeColor = Color.Gray;
            }
            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "")
            {
                UserPasswordField.Text = "Enter Password";
                UserPasswordField.UseSystemPasswordChar = false;
                UserPasswordField.ForeColor = Color.Gray;
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            if (UserLoginField.Text.Trim() == "" || UserLoginField.Text.Trim() == "Enter Login") 
            {
                MessageBox.Show("Pls Enter name");
            }if (UserEmailField.Text.Trim() == "" || UserEmailField.Text.Trim() == "Enter Email") 
            {
                MessageBox.Show("Pls Enter name");
            }if (UserPasswordField.Text.Trim() == "" || UserPasswordField.Text.Trim() == "Enter Password") 
            {
                MessageBox.Show("Pls Enter name");
            }
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(login, paswsword, email) VALUES(@login,@paswsword,@email)",db.GetConnection());
            command.Parameters.AddWithValue("login", UserLoginField.Text);
            command.Parameters.AddWithValue("email", UserEmailField.Text);
            command.Parameters.AddWithValue("paswsword", Hash(UserPasswordField.Text));

            db.OpenConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Account created");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch(MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate entry"))
                    { MessageBox.Show("Already reg"); }
                MessageBox.Show(ex.Message);
            }
           
            db.CloseConnection();
        }

        private string Hash(string input)
        {
            byte[] temp = Encoding.UTF8.GetBytes(input);
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(temp);
                return Convert.ToBase64String(hash);
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
            this.Close();
        }
    }
}
