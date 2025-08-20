namespace FrogsWinFormsApp
{
    partial class ResultsForm
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
            showLabel = new Label();
            resultsLabel = new Label();
            exitButton = new Button();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // showLabel
            // 
            showLabel.AutoSize = true;
            showLabel.BackColor = Color.FromArgb(32, 32, 32);
            showLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showLabel.ForeColor = Color.FromArgb(128, 255, 128);
            showLabel.Location = new Point(12, 9);
            showLabel.Name = "showLabel";
            showLabel.Size = new Size(107, 23);
            showLabel.TabIndex = 0;
            showLabel.Text = "Результаты:";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.BackColor = Color.FromArgb(32, 32, 32);
            resultsLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultsLabel.ForeColor = Color.FromArgb(128, 255, 128);
            resultsLabel.Location = new Point(12, 39);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(0, 23);
            resultsLabel.TabIndex = 1;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(32, 32, 32);
            exitButton.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitButton.ForeColor = Color.SpringGreen;
            exitButton.Location = new Point(632, 378);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(156, 60);
            exitButton.TabIndex = 4;
            exitButton.Text = "Назад";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(32, 32, 32);
            deleteButton.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.ForeColor = Color.Brown;
            deleteButton.Location = new Point(276, 378);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(298, 60);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Удалить результаты";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._9dec81c3ff0d412ce22829d301b0dcf8;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteButton);
            Controls.Add(exitButton);
            Controls.Add(resultsLabel);
            Controls.Add(showLabel);
            Name = "ResultsForm";
            Text = "ResultsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label showLabel;
        private Label resultsLabel;
        private Button exitButton;
        private Button deleteButton;
    }
}