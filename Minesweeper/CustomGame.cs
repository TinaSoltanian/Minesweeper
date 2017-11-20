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
    public partial class CustomForm : Form
    {
        public CustomForm()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WidthLabel_Click(object sender, EventArgs e)
        {

        }

        private void Height_Validating(object sender, CancelEventArgs e)
        {
            if (Height.Text.Length > 0)
                if (int.Parse(Height.Text) > 24)
                    Height.Text = "24";

            if (Width.Text.Length > 0)
                if (int.Parse(Height.Text) <= 9)
                    Height.Text = "9";
        }


        private void Width_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(Width.Text) > 30)
                Width.Text = "30";

            if (int.Parse(Width.Text) <= 9)
                Width.Text = "9";

        }

        private void MinCount_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(MinCount.Text) > 99)
                MinCount.Text = "99";

            if (int.Parse(MinCount.Text) <= 9)
                MinCount.Text = "9";

        }
    }
}
