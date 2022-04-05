namespace SifuTrainer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScoreTextBox = new System.Windows.Forms.TextBox();
            this.SetScoreButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GetScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScoreTextBox
            // 
            this.ScoreTextBox.Location = new System.Drawing.Point(15, 57);
            this.ScoreTextBox.Name = "ScoreTextBox";
            this.ScoreTextBox.Size = new System.Drawing.Size(145, 22);
            this.ScoreTextBox.TabIndex = 0;
            // 
            // SetScoreButton
            // 
            this.SetScoreButton.Location = new System.Drawing.Point(166, 56);
            this.SetScoreButton.Name = "SetScoreButton";
            this.SetScoreButton.Size = new System.Drawing.Size(196, 23);
            this.SetScoreButton.TabIndex = 1;
            this.SetScoreButton.Text = "Set score";
            this.SetScoreButton.UseVisualStyleBackColor = true;
            this.SetScoreButton.Click += new System.EventHandler(this.SetScoreButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(12, 38);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(83, 16);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Tag = "ScoreLabel: ";
            this.ScoreLabel.Text = "ScoreLabel: ";
            // 
            // GetScoreButton
            // 
            this.GetScoreButton.Location = new System.Drawing.Point(166, 31);
            this.GetScoreButton.Name = "GetScoreButton";
            this.GetScoreButton.Size = new System.Drawing.Size(196, 23);
            this.GetScoreButton.TabIndex = 3;
            this.GetScoreButton.Text = "Get score";
            this.GetScoreButton.UseVisualStyleBackColor = true;
            this.GetScoreButton.Click += new System.EventHandler(this.GetScoreButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 116);
            this.Controls.Add(this.GetScoreButton);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.SetScoreButton);
            this.Controls.Add(this.ScoreTextBox);
            this.Name = "Form1";
            this.Text = "SifuTrainer [v1.7]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ScoreTextBox;
        private System.Windows.Forms.Button SetScoreButton;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button GetScoreButton;
    }
}

