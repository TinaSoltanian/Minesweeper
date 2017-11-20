namespace Minesweeper
{
    partial class CustomForm
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
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.MinCountLabel = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.MaskedTextBox();
            this.Width = new System.Windows.Forms.MaskedTextBox();
            this.MinCount = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok.Location = new System.Drawing.Point(62, 119);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 6;
            this.Ok.Text = "&Ok";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(147, 119);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // HeightLabel
            // 
            this.HeightLabel.Location = new System.Drawing.Point(12, 14);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(76, 23);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "&Height :";
            // 
            // WidthLabel
            // 
            this.WidthLabel.Location = new System.Drawing.Point(12, 47);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(76, 23);
            this.WidthLabel.TabIndex = 2;
            this.WidthLabel.Text = "&Width :";
            this.WidthLabel.Click += new System.EventHandler(this.WidthLabel_Click);
            // 
            // MinCountLabel
            // 
            this.MinCountLabel.Location = new System.Drawing.Point(12, 83);
            this.MinCountLabel.Name = "MinCountLabel";
            this.MinCountLabel.Size = new System.Drawing.Size(76, 23);
            this.MinCountLabel.TabIndex = 4;
            this.MinCountLabel.Text = "&Mines :";
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(67, 12);
            this.Height.Mask = "000";
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(100, 21);
            this.Height.TabIndex = 1;
            this.Height.Validating += new System.ComponentModel.CancelEventHandler(this.Height_Validating);
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(67, 44);
            this.Width.Mask = "000";
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(100, 21);
            this.Width.TabIndex = 3;
            this.Width.Validating += new System.ComponentModel.CancelEventHandler(this.Width_Validating);
            // 
            // MinCount
            // 
            this.MinCount.Location = new System.Drawing.Point(67, 79);
            this.MinCount.Mask = "000";
            this.MinCount.Name = "MinCount";
            this.MinCount.Size = new System.Drawing.Size(100, 21);
            this.MinCount.TabIndex = 5;
            this.MinCount.Validating += new System.ComponentModel.CancelEventHandler(this.MinCount_Validating);
            // 
            // CustomForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(234, 154);
            this.Controls.Add(this.MinCount);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.MinCountLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(240, 180);
            this.Name = "CustomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custome...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label MinCountLabel;
        public System.Windows.Forms.MaskedTextBox Height;
        public System.Windows.Forms.MaskedTextBox Width;
        public System.Windows.Forms.MaskedTextBox MinCount;
    }
}