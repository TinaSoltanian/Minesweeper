namespace Minesweeper
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.GameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.GameNew = new System.Windows.Forms.ToolStripMenuItem();
            this.GameSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.GameBeginner = new System.Windows.Forms.ToolStripMenuItem();
            this.GameIntermediate = new System.Windows.Forms.ToolStripMenuItem();
            this.GameAdvanced = new System.Windows.Forms.ToolStripMenuItem();
            this.GameCustome = new System.Windows.Forms.ToolStripMenuItem();
            this.GameSeperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.GameExit = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Game = new Minesweeper.Components.Game();
            this.Smiley = new Minesweeper.Components.Smiley();
            this.BombCount = new Minesweeper.Components.Counter();
            this.GameTime = new Minesweeper.Components.Counter();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.GameBestTimes = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameMenu,
            this.HelpMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(426, 24);
            this.MainMenu.TabIndex = 5;
            this.MainMenu.Text = "menuStrip1";
            // 
            // GameMenu
            // 
            this.GameMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameNew,
            this.GameSeperator1,
            this.GameBeginner,
            this.GameIntermediate,
            this.GameAdvanced,
            this.GameCustome,
            this.GameSeperator2,
            this.GameBestTimes,
            this.toolStripMenuItem1,
            this.GameExit});
            this.GameMenu.Name = "GameMenu";
            this.GameMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.GameMenu.Size = new System.Drawing.Size(50, 20);
            this.GameMenu.Text = "&Game";
            // 
            // GameNew
            // 
            this.GameNew.Name = "GameNew";
            this.GameNew.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.GameNew.Size = new System.Drawing.Size(152, 22);
            this.GameNew.Text = "&New";
            this.GameNew.Click += new System.EventHandler(this.GameNew_Click);
            // 
            // GameSeperator1
            // 
            this.GameSeperator1.Name = "GameSeperator1";
            this.GameSeperator1.Size = new System.Drawing.Size(149, 6);
            // 
            // GameBeginner
            // 
            this.GameBeginner.Name = "GameBeginner";
            this.GameBeginner.Size = new System.Drawing.Size(152, 22);
            this.GameBeginner.Text = "&Beginner";
            this.GameBeginner.Click += new System.EventHandler(this.GameBeginner_Click);
            // 
            // GameIntermediate
            // 
            this.GameIntermediate.Name = "GameIntermediate";
            this.GameIntermediate.Size = new System.Drawing.Size(152, 22);
            this.GameIntermediate.Text = "&Intermediate";
            this.GameIntermediate.Click += new System.EventHandler(this.GameIntermediate_Click);
            // 
            // GameAdvanced
            // 
            this.GameAdvanced.Name = "GameAdvanced";
            this.GameAdvanced.Size = new System.Drawing.Size(152, 22);
            this.GameAdvanced.Text = "&Advanced";
            this.GameAdvanced.Click += new System.EventHandler(this.GameAdvanced_Click);
            // 
            // GameCustome
            // 
            this.GameCustome.Name = "GameCustome";
            this.GameCustome.Size = new System.Drawing.Size(152, 22);
            this.GameCustome.Text = "&Custome";
            this.GameCustome.Click += new System.EventHandler(this.GameCustome_Click);
            // 
            // GameSeperator2
            // 
            this.GameSeperator2.Name = "GameSeperator2";
            this.GameSeperator2.Size = new System.Drawing.Size(149, 6);
            // 
            // GameExit
            // 
            this.GameExit.Name = "GameExit";
            this.GameExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.GameExit.Size = new System.Drawing.Size(152, 22);
            this.GameExit.Text = "E&xit";
            this.GameExit.Click += new System.EventHandler(this.GameExit_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpAbout});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.HelpMenu.Size = new System.Drawing.Size(43, 20);
            this.HelpMenu.Text = "&Help";
            // 
            // HelpAbout
            // 
            this.HelpAbout.Name = "HelpAbout";
            this.HelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.HelpAbout.Size = new System.Drawing.Size(140, 22);
            this.HelpAbout.Text = "&About...";
            this.HelpAbout.Click += new System.EventHandler(this.HelpAbout_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Game
            // 
            this.Game.FirstClick = false;
            this.Game.Location = new System.Drawing.Point(10, 65);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(200, 100);
            this.Game.TabIndex = 4;
            // 
            // Smiley
            // 
            this.Smiley.IsAmazed = false;
            this.Smiley.IsGlassWeared = false;
            this.Smiley.IsHappy = true;
            this.Smiley.IsSad = false;
            this.Smiley.Location = new System.Drawing.Point(123, 23);
            this.Smiley.Name = "Smiley";
            this.Smiley.Size = new System.Drawing.Size(24, 24);
            this.Smiley.TabIndex = 3;
            this.Smiley.Text = "smiley1";
            this.Smiley.Click += new System.EventHandler(this.smiley1_Click);
            // 
            // BombCount
            // 
            this.BombCount.IsColored = false;
            this.BombCount.Length = 3;
            this.BombCount.Location = new System.Drawing.Point(207, 25);
            this.BombCount.Name = "BombCount";
            this.BombCount.Size = new System.Drawing.Size(39, 23);
            this.BombCount.TabIndex = 2;
            this.BombCount.Text = "counter1";
            this.BombCount.Value = 0;
            // 
            // GameTime
            // 
            this.GameTime.IsColored = false;
            this.GameTime.Length = 3;
            this.GameTime.Location = new System.Drawing.Point(8, 25);
            this.GameTime.Name = "GameTime";
            this.GameTime.Size = new System.Drawing.Size(39, 23);
            this.GameTime.TabIndex = 2;
            this.GameTime.Text = "counter1";
            this.GameTime.Value = 0;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // GameBestTimes
            // 
            this.GameBestTimes.Name = "GameBestTimes";
            this.GameBestTimes.Size = new System.Drawing.Size(152, 22);
            this.GameBestTimes.Text = "&Best Times";
            this.GameBestTimes.Click += new System.EventHandler(this.GameBestTimes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 362);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Game);
            this.Controls.Add(this.Smiley);
            this.Controls.Add(this.BombCount);
            this.Controls.Add(this.GameTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.Counter GameTime;
        private Components.Counter BombCount;
        private Components.Smiley Smiley;
        private Components.Game Game;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem GameMenu;
        private System.Windows.Forms.ToolStripMenuItem GameNew;
        private System.Windows.Forms.ToolStripSeparator GameSeperator1;
        private System.Windows.Forms.ToolStripMenuItem GameBeginner;
        private System.Windows.Forms.ToolStripMenuItem GameIntermediate;
        private System.Windows.Forms.ToolStripMenuItem GameAdvanced;
        private System.Windows.Forms.ToolStripMenuItem GameCustome;
        private System.Windows.Forms.ToolStripSeparator GameSeperator2;
        private System.Windows.Forms.ToolStripMenuItem GameExit;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpAbout;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripMenuItem GameBestTimes;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

