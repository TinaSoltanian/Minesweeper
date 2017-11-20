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
    public partial class BestTimesForm : Form
    {
        public BestTimesForm()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            return;
        }

        private void BestTimesForm_Load(object sender, EventArgs e)
        {
            BestTimeList.Statisticts.LoadFromFile( "BestTime" );
            BeginnerTime.Text = BestTimeList.Statisticts.BestTimesList[Configuration.GameLevel.Beginner].BestTime.ToString();
            BeginnerName.Text = BestTimeList.Statisticts.BestTimesList[Configuration.GameLevel.Beginner].WinnerName;
            BeginnerDateTime.Text = BestTimeList.Statisticts.BestTimesList[Configuration.GameLevel.Beginner].WinDateTime.ToString();

            IntermediateTime.Text = BestTimeList.Statisticts.BestTimesList[Configuration.GameLevel.Intermediate].BestTime.ToString();
            IntermediateName.Text = BestTimeList.Statisticts.BestTimesList[Configuration.GameLevel.Intermediate].WinnerName.ToString();
            InterMediateDateTime.Text = BestTimeList.Statisticts.BestTimesList[Configuration.GameLevel.Intermediate].WinDateTime.ToString();

            AdvancedTime.Text = BestTimeList.Statisticts.BestTimesList[Configuration.GameLevel.Advanced].BestTime.ToString();
            AdvancedName.Text = BestTimeList.Statisticts.BestTimesList[Configuration.GameLevel.Advanced].WinnerName.ToString();
            AdvancedDateTime.Text = BestTimeList.Statisticts.BestTimesList[Configuration.GameLevel.Advanced].WinDateTime.ToString();
            
         }
                  
    }
}
