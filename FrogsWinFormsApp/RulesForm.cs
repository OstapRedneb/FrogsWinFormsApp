using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogsWinFormsApp
{
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
            ruleLabel.Text = "Правила:\nВ игре есть 9 кувшинок.\nСлева на 4 кувшинках лягушки смотрят вправо,\nа справа 4 смотрят влево.\nКадая лягушка может прыгать на свободную кувшинку и в право,\nи влево либо через 1 лягушку, либо через 0 лягушек.\nВаша задача - переместить всех лягушек\nна противополоный конец.\nВсе кто смотрят вправо - вправо, а влево - влево";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
            Close();
        }
    }
}
