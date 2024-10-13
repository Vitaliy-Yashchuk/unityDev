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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            UserLoginField.Text = "Enter Login";
            UserPasswordField.Text = "Enter Password";
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "Enter Login")
            {
                UserLoginField.Text = "";

                UserLoginField.ForeColor = Color.White;
            }
            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "Enter Password")
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
            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "")
            {
                UserPasswordField.Text = "Enter Password";
                UserPasswordField.UseSystemPasswordChar = false;
                UserPasswordField.ForeColor = Color.Gray;
            }
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


        private void AuthForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void AuthButton_Click_1(object sender, EventArgs e)
        {
            if (UserLoginField.Text.Trim() == "" || UserLoginField.Text.Trim() == "Enter Login")
            {
                MessageBox.Show("Pls Enter name");
                return;
            }
            if (UserPasswordField.Text.Trim() == "" || UserPasswordField.Text.Trim() == "Enter Password")
            {
                MessageBox.Show("Pls Enter password");
                return;
            }
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT COUNT(id) FROM `users` WHERE login = @login AND paswsword = @paswsword", db.GetConnection());
            command.Parameters.AddWithValue("login", UserLoginField.Text);
            command.Parameters.AddWithValue("paswsword", Hash(UserPasswordField.Text));

            db.OpenConnection();
            int countUser = Convert.ToInt32(command.ExecuteScalar());
            if (countUser > 0)
            {
                MessageBox.Show("User exists");
            }
            else
            {
                MessageBox.Show("User not exists");
            }

            db.CloseConnection();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}
