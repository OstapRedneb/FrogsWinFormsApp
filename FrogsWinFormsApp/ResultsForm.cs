using Microsoft.VisualBasic.ApplicationServices;
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
using User = _2048ClassLibrary.User;

namespace FrogsWinFormsApp
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
            List<User> users = FileWorker.GetUsersList();
            users.Sort();

            resultsLabel.Text = string.Join("\n", users);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить все реультаты?\nВсе данные будут безвозвратно утеряны!", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                FileWorker.Clear();

                resultsLabel.Text = "";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
            Hide();
        }
    }
}
