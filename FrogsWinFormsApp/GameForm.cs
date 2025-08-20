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
        bool isWin = false;

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

                scoreLabel.Text = (int.Parse(scoreLabel.Text) + 1).ToString();

                if (isWin) 
                {

                }
            }
            else
            {
                MessageBox.Show("Так низя!!1!");
            }
        }
        private void CheckWin()
        {
            foreach(PictureBox pictureBox in pictureBoxes) 
            {
                if (pictureBox.Tag == "1") { }
            }
        }
    }
}
