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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "Enter Email")
            {
                UserEmailField.Text = "";
                UserEmailField.ForeColor = Color.White;
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
            if (((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "")
            {
                UserPasswordField.Text = "Enter Password";
                UserEmailField.ForeColor = Color.Gray;
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




        private void EditBth_Click(object sender, EventArgs e)
        {
            if (UserPasswordField.Text.Trim() == "" || UserPasswordField.Text.Trim() == "Enter Password")
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `email` = @email, `paswsword` = @paswsword WHERE login = 'admin'", db.GetConnection());

            command.Parameters.AddWithValue("@email", UserEmailField.Text);
            command.Parameters.AddWithValue("@paswsword", Hash(UserPasswordField.Text));

            db.OpenConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Account was edited successfully.");
                    this.Hide();
                    Menu menu = new Menu();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error: No rows affected.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

    }
}
