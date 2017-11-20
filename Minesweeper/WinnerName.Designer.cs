namespace Minesweeper
{
    partial class WinnerName
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
            this.OK = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.Label();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OK.Location = new System.Drawing.Point(165, 35);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "&Ok";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(12, 9);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(51, 23);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "&Name :";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserNameText
            // 
            this.UserNameText.Location = new System.Drawing.Point(55, 9);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(185, 20);
            this.UserNameText.TabIndex = 0;
            // 
            // WinnerName
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.OK;
            this.ClientSize = new System.Drawing.Size(258, 68);
            this.Controls.Add(this.UserNameText);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(264, 94);
            this.MinimizeBox = false;
            this.Name = "WinnerName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name . . .";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label UserName;
        public System.Windows.Forms.TextBox UserNameText;
    }
}