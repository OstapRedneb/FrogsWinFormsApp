namespace FrogsWinFormsApp
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            leftPictureBox1 = new PictureBox();
            leftPictureBox2 = new PictureBox();
            leftPictureBox4 = new PictureBox();
            leftPictureBox3 = new PictureBox();
            rightPictureBox3 = new PictureBox();
            rightPictureBox2 = new PictureBox();
            rightPictureBox1 = new PictureBox();
            centerPictureBox = new PictureBox();
            rightPictureBox4 = new PictureBox();

            pictureBoxes = new PictureBox[9];

            pictureBoxes[0] = leftPictureBox1;
            pictureBoxes[1] = leftPictureBox2;
            pictureBoxes[2] = leftPictureBox3;
            pictureBoxes[3] = leftPictureBox4;
            pictureBoxes[4] = centerPictureBox;
            pictureBoxes[5] = rightPictureBox1;
            pictureBoxes[6] = rightPictureBox2;
            pictureBoxes[7] = rightPictureBox3;
            pictureBoxes[8] = rightPictureBox4;

            showLabel = new Label();
            scoreLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)centerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox4).BeginInit();
            SuspendLayout();
            // 
            // leftPictureBox1
            // 
            leftPictureBox1.BackgroundImage = Properties.Resources.Левая_лягушка;
            leftPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            leftPictureBox1.Location = new Point(10, 10);
            leftPictureBox1.Name = "leftPictureBox1";
            leftPictureBox1.Size = new Size(110, 110);
            leftPictureBox1.TabIndex = 0;
            leftPictureBox1.TabStop = false;
            leftPictureBox1.Tag = "1";
            leftPictureBox1.Click += PictureBox_Click;
            // 
            // leftPictureBox2
            // 
            leftPictureBox2.BackgroundImage = Properties.Resources.Левая_лягушка;
            leftPictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            leftPictureBox2.Location = new Point(120, 10);
            leftPictureBox2.Name = "leftPictureBox2";
            leftPictureBox2.Size = new Size(110, 110);
            leftPictureBox2.TabIndex = 1;
            leftPictureBox2.TabStop = false;
            leftPictureBox2.Tag = "1";
            leftPictureBox2.Click += PictureBox_Click;
            // 
            // leftPictureBox4
            // 
            leftPictureBox4.BackgroundImage = Properties.Resources.Левая_лягушка;
            leftPictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            leftPictureBox4.Location = new Point(340, 10);
            leftPictureBox4.Name = "leftPictureBox4";
            leftPictureBox4.Size = new Size(110, 110);
            leftPictureBox4.TabIndex = 3;
            leftPictureBox4.TabStop = false;
            leftPictureBox4.Tag = "1";
            leftPictureBox4.Click += PictureBox_Click;
            // 
            // leftPictureBox3
            // 
            leftPictureBox3.BackgroundImage = Properties.Resources.Левая_лягушка;
            leftPictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            leftPictureBox3.Location = new Point(230, 10);
            leftPictureBox3.Name = "leftPictureBox3";
            leftPictureBox3.Size = new Size(110, 110);
            leftPictureBox3.TabIndex = 2;
            leftPictureBox3.TabStop = false;
            leftPictureBox3.Tag = "1";
            leftPictureBox3.Click += PictureBox_Click;
            // 
            // rightPictureBox3
            // 
            rightPictureBox3.BackgroundImage = Properties.Resources.Правая_лягушка;
            rightPictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            rightPictureBox3.Location = new Point(780, 10);
            rightPictureBox3.Name = "rightPictureBox3";
            rightPictureBox3.Size = new Size(110, 110);
            rightPictureBox3.TabIndex = 7;
            rightPictureBox3.TabStop = false;
            rightPictureBox3.Tag = "2";
            rightPictureBox3.Click += PictureBox_Click;
            // 
            // rightPictureBox2
            // 
            rightPictureBox2.BackgroundImage = Properties.Resources.Правая_лягушка;
            rightPictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            rightPictureBox2.Location = new Point(670, 10);
            rightPictureBox2.Name = "rightPictureBox2";
            rightPictureBox2.Size = new Size(110, 110);
            rightPictureBox2.TabIndex = 6;
            rightPictureBox2.TabStop = false;
            rightPictureBox2.Tag = "2";
            rightPictureBox2.Click += PictureBox_Click;
            // 
            // rightPictureBox1
            // 
            rightPictureBox1.BackgroundImage = Properties.Resources.Правая_лягушка;
            rightPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            rightPictureBox1.Location = new Point(560, 10);
            rightPictureBox1.Name = "rightPictureBox1";
            rightPictureBox1.Size = new Size(110, 110);
            rightPictureBox1.TabIndex = 5;
            rightPictureBox1.TabStop = false;
            rightPictureBox1.Tag = "2";
            rightPictureBox1.Click += PictureBox_Click;
            // 
            // centerPictureBox
            // 
            centerPictureBox.BackgroundImage = Properties.Resources.Кувшинка;
            centerPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            centerPictureBox.Location = new Point(450, 10);
            centerPictureBox.Name = "centerPictureBox";
            centerPictureBox.Size = new Size(110, 110);
            centerPictureBox.TabIndex = 4;
            centerPictureBox.TabStop = false;
            centerPictureBox.Tag = "3";
            centerPictureBox.Click += PictureBox_Click;
            // 
            // rightPictureBox4
            // 
            rightPictureBox4.BackgroundImage = Properties.Resources.Правая_лягушка;
            rightPictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            rightPictureBox4.Location = new Point(890, 10);
            rightPictureBox4.Name = "rightPictureBox4";
            rightPictureBox4.Size = new Size(110, 110);
            rightPictureBox4.TabIndex = 8;
            rightPictureBox4.TabStop = false;
            rightPictureBox4.Tag = "2";
            rightPictureBox4.Click += PictureBox_Click;
            // 
            // showLabel
            // 
            showLabel.AutoSize = true;
            showLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showLabel.ForeColor = Color.FromArgb(0, 64, 0);
            showLabel.Location = new Point(10, 138);
            showLabel.Name = "showLabel";
            showLabel.Size = new Size(71, 27);
            showLabel.TabIndex = 9;
            showLabel.Text = "Ходы:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            scoreLabel.ForeColor = Color.FromArgb(0, 64, 0);
            scoreLabel.Location = new Point(87, 138);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(24, 27);
            scoreLabel.TabIndex = 10;
            scoreLabel.Text = "0";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1004, 192);
            Controls.Add(scoreLabel);
            Controls.Add(showLabel);
            Controls.Add(rightPictureBox4);
            Controls.Add(rightPictureBox3);
            Controls.Add(rightPictureBox2);
            Controls.Add(rightPictureBox1);
            Controls.Add(centerPictureBox);
            Controls.Add(leftPictureBox4);
            Controls.Add(leftPictureBox3);
            Controls.Add(leftPictureBox2);
            Controls.Add(leftPictureBox1);
            Name = "GameForm";
            Text = "GameForm";
            ((System.ComponentModel.ISupportInitialize)leftPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)centerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox leftPictureBox1;
        private PictureBox leftPictureBox2;
        private PictureBox leftPictureBox4;
        private PictureBox leftPictureBox3;
        private PictureBox rightPictureBox3;
        private PictureBox rightPictureBox2;
        private PictureBox rightPictureBox1;
        private PictureBox centerPictureBox;
        private PictureBox rightPictureBox4;
        private Label showLabel;
        private Label scoreLabel;
        private PictureBox[] pictureBoxes;
    }
}