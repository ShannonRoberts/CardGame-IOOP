namespace PokemonGameForm
{
    partial class HighScore
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
            this.scoresLabel = new System.Windows.Forms.Label();
            this.highScoresLabel = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scoresLabel
            // 
            this.scoresLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresLabel.Location = new System.Drawing.Point(81, 39);
            this.scoresLabel.Name = "scoresLabel";
            this.scoresLabel.Size = new System.Drawing.Size(169, 325);
            this.scoresLabel.TabIndex = 0;
            // 
            // highScoresLabel
            // 
            this.highScoresLabel.AutoSize = true;
            this.highScoresLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoresLabel.Location = new System.Drawing.Point(80, 9);
            this.highScoresLabel.Name = "highScoresLabel";
            this.highScoresLabel.Size = new System.Drawing.Size(122, 21);
            this.highScoresLabel.TabIndex = 1;
            this.highScoresLabel.Text = "High Scores:";
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showButton.Location = new System.Drawing.Point(103, 391);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 30);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(283, 433);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.highScoresLabel);
            this.Controls.Add(this.scoresLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HighScore";
            this.ShowIcon = false;
            this.Text = "HighScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoresLabel;
        private System.Windows.Forms.Label highScoresLabel;
        private System.Windows.Forms.Button showButton;
    }
}