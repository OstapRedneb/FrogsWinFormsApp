namespace FrogsWinFormsApp
{
    partial class RulesForm
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
            ruleLabel = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // ruleLabel
            // 
            ruleLabel.AutoSize = true;
            ruleLabel.BackColor = Color.DarkSeaGreen;
            ruleLabel.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ruleLabel.Location = new Point(12, 9);
            ruleLabel.Name = "ruleLabel";
            ruleLabel.Size = new Size(156, 40);
            ruleLabel.TabIndex = 0;
            ruleLabel.Text = "Правила:";
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.DarkGreen;
            exitButton.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitButton.ForeColor = Color.FromArgb(192, 255, 255);
            exitButton.Location = new Point(469, 378);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(156, 60);
            exitButton.TabIndex = 4;
            exitButton.Text = "Назад";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // RulesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.f55952455020a6e25a013984aa7a7329;
            ClientSize = new Size(998, 450);
            Controls.Add(exitButton);
            Controls.Add(ruleLabel);
            Name = "RulesForm";
            Text = "RulesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ruleLabel;
        private Button exitButton;
    }
}