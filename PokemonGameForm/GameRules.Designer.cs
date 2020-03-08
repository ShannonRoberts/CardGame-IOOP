namespace PokemonGameForm
{
    partial class GameRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameRules));
            this.gameRulesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameRulesLabel
            // 
            this.gameRulesLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameRulesLabel.Location = new System.Drawing.Point(42, 15);
            this.gameRulesLabel.Name = "gameRulesLabel";
            this.gameRulesLabel.Size = new System.Drawing.Size(791, 714);
            this.gameRulesLabel.TabIndex = 0;
            this.gameRulesLabel.Text = resources.GetString("gameRulesLabel.Text");
            // 
            // GameRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(872, 738);
            this.Controls.Add(this.gameRulesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameRules";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gameRulesLabel;
    }
}