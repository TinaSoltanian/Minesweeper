namespace Minesweeper
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.Exit = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Location = new System.Drawing.Point(330, 127);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(53, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "OK";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Label
            // 
            this.Label.Location = new System.Drawing.Point(187, 115);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(137, 25);
            this.Label.TabIndex = 1;
            this.Label.Text = "MineSweeper ver 1.0";
            // 
            // PictureBox
            // 
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(169, 128);
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            // 
            // AboutForm
            // 
            this.AcceptButton = this.Exit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(395, 152);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Exit);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(401, 178);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(401, 178);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About...";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}