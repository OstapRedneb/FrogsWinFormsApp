namespace FrogsWinFormsApp
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            startButton = new Button();
            resultsButton = new Button();
            rulesButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(128, 255, 128);
            startButton.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startButton.ForeColor = Color.FromArgb(0, 64, 64);
            startButton.Location = new Point(323, 98);
            startButton.Name = "startButton";
            startButton.Size = new Size(156, 60);
            startButton.TabIndex = 0;
            startButton.Text = "Начать";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // resultsButton
            // 
            resultsButton.BackColor = Color.FromArgb(128, 255, 128);
            resultsButton.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultsButton.ForeColor = Color.FromArgb(0, 64, 64);
            resultsButton.Location = new Point(323, 230);
            resultsButton.Name = "resultsButton";
            resultsButton.Size = new Size(156, 60);
            resultsButton.TabIndex = 1;
            resultsButton.Text = "Результаты";
            resultsButton.UseVisualStyleBackColor = false;
            resultsButton.Click += resultsButton_Click;
            // 
            // rulesButton
            // 
            rulesButton.BackColor = Color.FromArgb(128, 255, 128);
            rulesButton.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rulesButton.ForeColor = Color.FromArgb(0, 64, 64);
            rulesButton.Location = new Point(323, 164);
            rulesButton.Name = "rulesButton";
            rulesButton.Size = new Size(156, 60);
            rulesButton.TabIndex = 2;
            rulesButton.Text = "Правила";
            rulesButton.UseVisualStyleBackColor = false;
            rulesButton.Click += rulesButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(128, 255, 128);
            exitButton.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitButton.ForeColor = Color.FromArgb(0, 64, 64);
            exitButton.Location = new Point(323, 298);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(156, 60);
            exitButton.TabIndex = 3;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(rulesButton);
            Controls.Add(resultsButton);
            Controls.Add(startButton);
            Name = "MenuForm";
            Text = "Попрыгушки!";
            ResumeLayout(false);
        }

        #endregion

        private Button startButton;
        private Button resultsButton;
        private Button rulesButton;
        private Button exitButton;
    }
}
