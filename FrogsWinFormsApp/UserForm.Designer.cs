namespace FrogsWinFormsApp
{
    partial class UserForm
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
            startButton = new Button();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(32, 32, 32);
            startButton.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startButton.ForeColor = Color.FromArgb(128, 255, 128);
            startButton.Location = new Point(326, 315);
            startButton.Name = "startButton";
            startButton.Size = new Size(172, 60);
            startButton.TabIndex = 5;
            startButton.Text = "Продолжить";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // textBox
            // 
            textBox.BackColor = Color.FromArgb(128, 255, 128);
            textBox.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox.ForeColor = Color.FromArgb(32, 32, 32);
            textBox.Location = new Point(233, 180);
            textBox.Name = "textBox";
            textBox.Size = new Size(341, 56);
            textBox.TabIndex = 6;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._7ab31714bdbbe438c31b8eb110ca771f;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox);
            Controls.Add(startButton);
            Name = "UserForm";
            Text = "UserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private TextBox textBox;
    }
}