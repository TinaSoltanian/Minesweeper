using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BombDetec(object sender, EventArgs e)
        {
            BombCount.Value = Game.DetectedBombsCount;
        }

        WinnerName dialogWin;
        private void Win(object sender, EventArgs e)
        {
            Smiley.IsHappy = false;
            Smiley.IsGlassWeared = true;
            Smiley.IsSad = false;

            if (dialogWin == null)
                dialogWin = new WinnerName();
            else
            {
                dialogWin = null;
                return;
            }

            dialogWin.ShowDialog();
            BestTimes newTime = new BestTimes();
            newTime.BestTime = GameTime.Value;

            if (dialogWin.UserNameText.Text.Length == 0)
                newTime.WinnerName = "Anonymouse";
            else
                newTime.WinnerName = dialogWin.UserNameText.Text;
            newTime.WinDateTime = DateTime.Now;

            BestTimeList.Statisticts.SaveToFile(newTime);
            GameBestTimes.PerformClick();
            GameNew.PerformClick();
        }

        private void GameOver(object sender, EventArgs e)
        {
            Smiley.IsHappy = false;
            Smiley.IsSad = true;
            Smiley.IsGlassWeared = false;
        }

        private void ItemClicked(object sender, EventArgs e)
        {
            Smiley.IsAmazed = true;
            Smiley.IsHappy = false;
            Smiley.IsGlassWeared = false;
            Smiley.IsSad = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Configuration.Configuration.GameConfiguration.Level = Configuration.GameLevel.Intermediate;
            Game.Initialize();
            this.InitializeForm();
 
        }

        private void InitializeForm()
        {
            MaximumSize = new Size(0, 0);
            this.Size = new Size(Game.Size.Width + 40, Game.Size.Height + 150);
            MaximumSize = this.Size;
            GameTime.Top =  30;
            BombCount.Top =  30;
            Smiley.Top = 30;
            Smiley.IsHappy = true;

            Game.Top = BombCount.Bottom + 5;
            Game.Left = (this.Width / 2) - (Game.Width / 2) -6;
            GameTime.Left = this.Game.Left;
            BombCount.Left = Game.Right - BombCount.Width;
            Smiley.Left = ((this.Width / 2) - (Smiley.Width / 2)) - 2 ;

            this.Size = new Size(this.Size.Width, this.Game.Bottom + 50);
            Timer.Enabled = true;
            BombCount.Value = Configuration.Configuration.GameConfiguration.MineCount;
            Game.WinTheGame += (Win);
            Game.TheGameOver += (GameOver);
            Game.MouseDown += (ItemClicked);
            Game.ItemMouseUP += (onMouseUp);
            Game.ItemDBLCLicked += (onDoubleClick);
            Game.MineDetected += (BombDetec);
        }

        private void onMouseUp(object sender, EventArgs e)
        {
            Smiley.IsAmazed = false;
            Smiley.IsHappy = true;

        }

        private void onDoubleClick(object sender, EventArgs e)
        {
            Smiley.IsAmazed = false;
            Smiley.IsHappy = true;
        }

        private void smiley1_Click(object sender, EventArgs e)
        {
            GameNew.PerformClick();
        }

        private void GameNew_Click(object sender, EventArgs e)
        {
            if (Configuration.Configuration.GameConfiguration.Level == Configuration.GameLevel.Advanced)
                GameAdvanced.PerformClick();
            else if (Configuration.Configuration.GameConfiguration.Level == Configuration.GameLevel.Beginner)
                GameBeginner.PerformClick();
            else if (Configuration.Configuration.GameConfiguration.Level == Configuration.GameLevel.Intermediate)
                GameIntermediate.PerformClick();
        }

        private void GameBeginner_Click(object sender, EventArgs e)
        {
            Configuration.Configuration.GameConfiguration.Level = Configuration.GameLevel.Beginner;
            Game.Initialize();
            this.InitializeForm();
        }

        private void GameIntermediate_Click(object sender, EventArgs e)
        {
            Configuration.Configuration.GameConfiguration.Level = Configuration.GameLevel.Intermediate;
            Game.Initialize();
            this.InitializeForm();
        }

        private void GameAdvanced_Click(object sender, EventArgs e)
        {
            Configuration.Configuration.GameConfiguration.Level = Configuration.GameLevel.Advanced;
            Game.Initialize();
            this.InitializeForm();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GameTime.Value = Game.GameTime;
        }

        private void HelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm dialog = new AboutForm();

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;
        }

        private void GameCustome_Click(object sender, EventArgs e)
        {
            CustomForm dialog = new CustomForm();

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            Configuration.Configuration.GameConfiguration.MineCount = int.Parse(dialog.MinCount.Text);
            Configuration.Configuration.GameConfiguration.Column = int.Parse(dialog.Width.Text);
            Configuration.Configuration.GameConfiguration.Row = int.Parse(dialog.Height.Text);

            Game.Initialize();
            this.InitializeForm();            
        }

        private void GameExit_Click(object sender, EventArgs e)
        {            
            return;
        }

        private void GameBestTimes_Click(object sender, EventArgs e)
        {
            BestTimesForm dialog = new BestTimesForm();

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;
        }
    }
}
