using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2048ClassLibrary;

namespace FrogsWinFormsApp
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
                MessageBox.Show("Вы не ввели имя!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else 
            {
                GameForm.user = new User(textBox.Text);
                new GameForm().Show();

                Hide();
            }
        }
    }
}
