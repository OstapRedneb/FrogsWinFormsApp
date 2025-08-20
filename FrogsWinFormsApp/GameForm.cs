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
    public partial class GameForm : Form
    {
        public static User user;

        public GameForm()
        {
            InitializeComponent();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;


            if (MathF.Abs(pictureBox.Location.X - centerPictureBox.Location.X) <= pictureBox.Size.Width * 2)
            {
                (pictureBox.Location, centerPictureBox.Location) = (centerPictureBox.Location, pictureBox.Location);

                if (pictureBox != centerPictureBox)
                    scoreLabel.Text = (int.Parse(scoreLabel.Text) + 1).ToString();


                if (CheckWin())
                {
                    string congratulations = scoreLabel.Text == "24" ? "Вам удалось пройти игру за минимальное количество ходов" : "К соджалению вам не уалось пройти игу за минимальное количество ходов";
                    MessageBox.Show($"Поздравляю! вы победили!\n{congratulations}", "Поздравление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    user.Result = int.Parse(scoreLabel.Text);
                    FileWorker.AddUser(user);

                    new MenuForm().Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Так низя!!1!");
            }
        }
        private bool CheckWin()
        {
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if ((pictureBox.Tag == "1" && pictureBox.Location.X < 10 + (pictureBox.Size.Width * 5)) || (pictureBox.Tag == "2" && pictureBox.Location.X >= 10 + (pictureBox.Size.Width * 4)))
                    return false;
            }
            return true;
        }
    }
}
