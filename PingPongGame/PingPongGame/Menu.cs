using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
        }

        private void StartGameBth_Click(object sender, EventArgs e)
        {
            this.Hide();
            PingPong pingPong = new PingPong();
            pingPong.ShowDialog();
            this.Close();
        }

        private void EditBth_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditForm edit = new EditForm();
            edit.ShowDialog();
            this.Close();
        }

        private void ExitBth_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
