namespace PokemonGameForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.baseAttackButton = new System.Windows.Forms.Button();
            this.specialAttackButton = new System.Windows.Forms.Button();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.computerHealthLabel = new System.Windows.Forms.Label();
            this.playerUsesLabel = new System.Windows.Forms.Label();
            this.computerUsesLabel = new System.Windows.Forms.Label();
            this.computerPokemonLabel = new System.Windows.Forms.Label();
            this.playerPokemonLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.remainingLabel = new System.Windows.Forms.Label();
            this.battlefieldPictureBox = new System.Windows.Forms.PictureBox();
            this.newMatchButton = new System.Windows.Forms.Button();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.defeatLabel = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.viewHSButton = new System.Windows.Forms.Button();
            this.usePotionButton = new System.Windows.Forms.Button();
            this.potionLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.gameRulesButton = new System.Windows.Forms.ToolStripButton();
            this.stopGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.battlefieldPictureBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(1086, 25);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 33);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // baseAttackButton
            // 
            this.baseAttackButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.baseAttackButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseAttackButton.Location = new System.Drawing.Point(1086, 62);
            this.baseAttackButton.Name = "baseAttackButton";
            this.baseAttackButton.Size = new System.Drawing.Size(108, 33);
            this.baseAttackButton.TabIndex = 2;
            this.baseAttackButton.Text = "Base Attack";
            this.baseAttackButton.UseVisualStyleBackColor = false;
            this.baseAttackButton.Visible = false;
            this.baseAttackButton.Click += new System.EventHandler(this.baseAttackButton_Click);
            // 
            // specialAttackButton
            // 
            this.specialAttackButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.specialAttackButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialAttackButton.Location = new System.Drawing.Point(1086, 102);
            this.specialAttackButton.Name = "specialAttackButton";
            this.specialAttackButton.Size = new System.Drawing.Size(123, 33);
            this.specialAttackButton.TabIndex = 3;
            this.specialAttackButton.Text = "Special Attack";
            this.specialAttackButton.UseVisualStyleBackColor = false;
            this.specialAttackButton.Visible = false;
            this.specialAttackButton.Click += new System.EventHandler(this.specialAttackButton_Click);
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.AutoSize = true;
            this.playerHealthLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.playerHealthLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHealthLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playerHealthLabel.Location = new System.Drawing.Point(86, 66);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(88, 23);
            this.playerHealthLabel.TabIndex = 4;
            this.playerHealthLabel.Text = "Health : ";
            // 
            // computerHealthLabel
            // 
            this.computerHealthLabel.AutoSize = true;
            this.computerHealthLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.computerHealthLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerHealthLabel.Location = new System.Drawing.Point(787, 66);
            this.computerHealthLabel.Name = "computerHealthLabel";
            this.computerHealthLabel.Size = new System.Drawing.Size(88, 23);
            this.computerHealthLabel.TabIndex = 5;
            this.computerHealthLabel.Text = "Health : ";
            // 
            // playerUsesLabel
            // 
            this.playerUsesLabel.AutoSize = true;
            this.playerUsesLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.playerUsesLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerUsesLabel.Location = new System.Drawing.Point(86, 89);
            this.playerUsesLabel.Name = "playerUsesLabel";
            this.playerUsesLabel.Size = new System.Drawing.Size(187, 23);
            this.playerUsesLabel.TabIndex = 6;
            this.playerUsesLabel.Text = "Special Uses Left : ";
            // 
            // computerUsesLabel
            // 
            this.computerUsesLabel.AutoSize = true;
            this.computerUsesLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.computerUsesLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerUsesLabel.Location = new System.Drawing.Point(787, 89);
            this.computerUsesLabel.Name = "computerUsesLabel";
            this.computerUsesLabel.Size = new System.Drawing.Size(182, 23);
            this.computerUsesLabel.TabIndex = 7;
            this.computerUsesLabel.Text = "Special Uses Left :";
            // 
            // computerPokemonLabel
            // 
            this.computerPokemonLabel.AutoSize = true;
            this.computerPokemonLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.computerPokemonLabel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerPokemonLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.computerPokemonLabel.Location = new System.Drawing.Point(786, 39);
            this.computerPokemonLabel.Name = "computerPokemonLabel";
            this.computerPokemonLabel.Size = new System.Drawing.Size(236, 27);
            this.computerPokemonLabel.TabIndex = 8;
            this.computerPokemonLabel.Text = "Computer Pokemon";
            // 
            // playerPokemonLabel
            // 
            this.playerPokemonLabel.AutoSize = true;
            this.playerPokemonLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.playerPokemonLabel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerPokemonLabel.ForeColor = System.Drawing.Color.Green;
            this.playerPokemonLabel.Location = new System.Drawing.Point(85, 39);
            this.playerPokemonLabel.Name = "playerPokemonLabel";
            this.playerPokemonLabel.Size = new System.Drawing.Size(195, 27);
            this.playerPokemonLabel.TabIndex = 9;
            this.playerPokemonLabel.Text = "Player Pokemon";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.scoreLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(86, 112);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(76, 23);
            this.scoreLabel.TabIndex = 10;
            this.scoreLabel.Text = "Score: ";
            // 
            // remainingLabel
            // 
            this.remainingLabel.AutoSize = true;
            this.remainingLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.remainingLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingLabel.Location = new System.Drawing.Point(787, 112);
            this.remainingLabel.Name = "remainingLabel";
            this.remainingLabel.Size = new System.Drawing.Size(219, 23);
            this.remainingLabel.TabIndex = 11;
            this.remainingLabel.Text = "Pokemon Remaining :";
            // 
            // battlefieldPictureBox
            // 
            this.battlefieldPictureBox.BackColor = System.Drawing.Color.SkyBlue;
            this.battlefieldPictureBox.Location = new System.Drawing.Point(51, 25);
            this.battlefieldPictureBox.Name = "battlefieldPictureBox";
            this.battlefieldPictureBox.Size = new System.Drawing.Size(1021, 767);
            this.battlefieldPictureBox.TabIndex = 0;
            this.battlefieldPictureBox.TabStop = false;
            this.battlefieldPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.battlefieldPictureBox_MouseClick);
            // 
            // newMatchButton
            // 
            this.newMatchButton.BackColor = System.Drawing.Color.Snow;
            this.newMatchButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMatchButton.Location = new System.Drawing.Point(307, 800);
            this.newMatchButton.Name = "newMatchButton";
            this.newMatchButton.Size = new System.Drawing.Size(107, 33);
            this.newMatchButton.TabIndex = 12;
            this.newMatchButton.Text = "New Match";
            this.newMatchButton.UseVisualStyleBackColor = false;
            this.newMatchButton.Visible = false;
            this.newMatchButton.Click += new System.EventHandler(this.newMatchButton_Click);
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.BackColor = System.Drawing.Color.Transparent;
            this.winnerLabel.Font = new System.Drawing.Font("Rockwell", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.winnerLabel.Location = new System.Drawing.Point(306, 186);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(517, 148);
            this.winnerLabel.TabIndex = 13;
            this.winnerLabel.Text = "Winner";
            this.winnerLabel.Visible = false;
            // 
            // defeatLabel
            // 
            this.defeatLabel.AutoSize = true;
            this.defeatLabel.BackColor = System.Drawing.Color.Transparent;
            this.defeatLabel.Font = new System.Drawing.Font("Rockwell", 100F);
            this.defeatLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.defeatLabel.Location = new System.Drawing.Point(331, 334);
            this.defeatLabel.Name = "defeatLabel";
            this.defeatLabel.Size = new System.Drawing.Size(465, 149);
            this.defeatLabel.TabIndex = 14;
            this.defeatLabel.Text = "Defeat";
            this.defeatLabel.Visible = false;
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.Snow;
            this.pauseButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.Location = new System.Drawing.Point(173, 800);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(123, 33);
            this.pauseButton.TabIndex = 15;
            this.pauseButton.Text = "Pause Game";
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Visible = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // viewHSButton
            // 
            this.viewHSButton.BackColor = System.Drawing.Color.Snow;
            this.viewHSButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewHSButton.Location = new System.Drawing.Point(425, 800);
            this.viewHSButton.Name = "viewHSButton";
            this.viewHSButton.Size = new System.Drawing.Size(123, 33);
            this.viewHSButton.TabIndex = 16;
            this.viewHSButton.Text = "High Scores";
            this.viewHSButton.UseVisualStyleBackColor = false;
            this.viewHSButton.Visible = false;
            this.viewHSButton.Click += new System.EventHandler(this.viewHSButton_Click);
            // 
            // usePotionButton
            // 
            this.usePotionButton.BackColor = System.Drawing.Color.GreenYellow;
            this.usePotionButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usePotionButton.Location = new System.Drawing.Point(1086, 141);
            this.usePotionButton.Name = "usePotionButton";
            this.usePotionButton.Size = new System.Drawing.Size(96, 33);
            this.usePotionButton.TabIndex = 17;
            this.usePotionButton.Text = "Use Potion";
            this.usePotionButton.UseVisualStyleBackColor = false;
            this.usePotionButton.Visible = false;
            this.usePotionButton.Click += new System.EventHandler(this.usePotionButton_Click);
            // 
            // potionLabel
            // 
            this.potionLabel.AutoSize = true;
            this.potionLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.potionLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potionLabel.Location = new System.Drawing.Point(86, 135);
            this.potionLabel.Name = "potionLabel";
            this.potionLabel.Size = new System.Drawing.Size(126, 23);
            this.potionLabel.TabIndex = 18;
            this.potionLabel.Text = "Potions left: ";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.timerLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(85, 158);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(78, 23);
            this.timerLabel.TabIndex = 19;
            this.timerLabel.Text = "Timer: ";
            this.timerLabel.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameRulesButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 848);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1250, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // gameRulesButton
            // 
            this.gameRulesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.gameRulesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gameRulesButton.Name = "gameRulesButton";
            this.gameRulesButton.Size = new System.Drawing.Size(73, 22);
            this.gameRulesButton.Text = "Game Rules";
            this.gameRulesButton.Click += new System.EventHandler(this.gameRulesButton_Click);
            // 
            // stopGameButton
            // 
            this.stopGameButton.BackColor = System.Drawing.Color.Snow;
            this.stopGameButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopGameButton.Location = new System.Drawing.Point(51, 800);
            this.stopGameButton.Name = "stopGameButton";
            this.stopGameButton.Size = new System.Drawing.Size(112, 33);
            this.stopGameButton.TabIndex = 21;
            this.stopGameButton.Text = "Stop Game";
            this.stopGameButton.UseVisualStyleBackColor = false;
            this.stopGameButton.Visible = false;
            this.stopGameButton.Click += new System.EventHandler(this.stopGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::PokemonGameForm.Properties.Resources.background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1250, 873);
            this.Controls.Add(this.stopGameButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.potionLabel);
            this.Controls.Add(this.usePotionButton);
            this.Controls.Add(this.viewHSButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.defeatLabel);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.newMatchButton);
            this.Controls.Add(this.remainingLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.playerPokemonLabel);
            this.Controls.Add(this.computerPokemonLabel);
            this.Controls.Add(this.computerUsesLabel);
            this.Controls.Add(this.playerUsesLabel);
            this.Controls.Add(this.computerHealthLabel);
            this.Controls.Add(this.playerHealthLabel);
            this.Controls.Add(this.specialAttackButton);
            this.Controls.Add(this.baseAttackButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.battlefieldPictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pokemon Card Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.battlefieldPictureBox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox battlefieldPictureBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button baseAttackButton;
        private System.Windows.Forms.Button specialAttackButton;
        private System.Windows.Forms.Label playerHealthLabel;
        private System.Windows.Forms.Label computerHealthLabel;
        private System.Windows.Forms.Label playerUsesLabel;
        private System.Windows.Forms.Label computerUsesLabel;
        private System.Windows.Forms.Label computerPokemonLabel;
        private System.Windows.Forms.Label playerPokemonLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label remainingLabel;
        private System.Windows.Forms.Button newMatchButton;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Label defeatLabel;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button viewHSButton;
        private System.Windows.Forms.Button usePotionButton;
        private System.Windows.Forms.Label potionLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton gameRulesButton;
        private System.Windows.Forms.Button stopGameButton;
    }
}

