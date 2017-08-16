namespace Supermarket.Client.Forms
{
    partial class SummaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            this.ContinueButton = new System.Windows.Forms.Button();
            this.RevenuesLabel = new System.Windows.Forms.Label();
            this.CostsLabel = new System.Windows.Forms.Label();
            this.RevenueText = new System.Windows.Forms.TextBox();
            this.WagesText = new System.Windows.Forms.TextBox();
            this.RentText = new System.Windows.Forms.TextBox();
            this.WagesLabel = new System.Windows.Forms.Label();
            this.RentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SatisfiedClientsLabel = new System.Windows.Forms.Label();
            this.UnsatisfiedClientsLabel = new System.Windows.Forms.Label();
            this.UnsatisfiedClientsText = new System.Windows.Forms.TextBox();
            this.SatisfiedClientsText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ForLabel = new System.Windows.Forms.Label();
            this.DayText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContinueButton
            // 
            this.ContinueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContinueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContinueButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ContinueButton.Location = new System.Drawing.Point(285, 789);
            this.ContinueButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(323, 67);
            this.ContinueButton.TabIndex = 14;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // RevenuesLabel
            // 
            this.RevenuesLabel.AutoSize = true;
            this.RevenuesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RevenuesLabel.Location = new System.Drawing.Point(157, 310);
            this.RevenuesLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.RevenuesLabel.Name = "RevenuesLabel";
            this.RevenuesLabel.Size = new System.Drawing.Size(206, 46);
            this.RevenuesLabel.TabIndex = 17;
            this.RevenuesLabel.Text = "Revenues";
            // 
            // CostsLabel
            // 
            this.CostsLabel.AutoSize = true;
            this.CostsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostsLabel.Location = new System.Drawing.Point(248, 420);
            this.CostsLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.CostsLabel.Name = "CostsLabel";
            this.CostsLabel.Size = new System.Drawing.Size(128, 46);
            this.CostsLabel.TabIndex = 18;
            this.CostsLabel.Text = "Costs";
            // 
            // RevenueText
            // 
            this.RevenueText.BackColor = System.Drawing.SystemColors.Control;
            this.RevenueText.Enabled = false;
            this.RevenueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RevenueText.Location = new System.Drawing.Point(128, 365);
            this.RevenueText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RevenueText.Name = "RevenueText";
            this.RevenueText.ReadOnly = true;
            this.RevenueText.Size = new System.Drawing.Size(260, 38);
            this.RevenueText.TabIndex = 19;
            this.RevenueText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WagesText
            // 
            this.WagesText.BackColor = System.Drawing.SystemColors.Control;
            this.WagesText.Enabled = false;
            this.WagesText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WagesText.Location = new System.Drawing.Point(128, 475);
            this.WagesText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.WagesText.Name = "WagesText";
            this.WagesText.ReadOnly = true;
            this.WagesText.Size = new System.Drawing.Size(260, 38);
            this.WagesText.TabIndex = 20;
            this.WagesText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RentText
            // 
            this.RentText.Enabled = false;
            this.RentText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RentText.Location = new System.Drawing.Point(128, 537);
            this.RentText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RentText.Name = "RentText";
            this.RentText.ReadOnly = true;
            this.RentText.Size = new System.Drawing.Size(260, 38);
            this.RentText.TabIndex = 21;
            this.RentText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WagesLabel
            // 
            this.WagesLabel.AutoSize = true;
            this.WagesLabel.Location = new System.Drawing.Point(3, 465);
            this.WagesLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.WagesLabel.Name = "WagesLabel";
            this.WagesLabel.Size = new System.Drawing.Size(103, 32);
            this.WagesLabel.TabIndex = 22;
            this.WagesLabel.Text = "Wages";
            // 
            // RentLabel
            // 
            this.RentLabel.AutoSize = true;
            this.RentLabel.Location = new System.Drawing.Point(32, 527);
            this.RentLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.RentLabel.Name = "RentLabel";
            this.RentLabel.Size = new System.Drawing.Size(75, 32);
            this.RentLabel.TabIndex = 23;
            this.RentLabel.Text = "Rent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(264, 591);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 46);
            this.label1.TabIndex = 24;
            this.label1.Text = "Total";
            // 
            // TotalText
            // 
            this.TotalText.Enabled = false;
            this.TotalText.Location = new System.Drawing.Point(128, 646);
            this.TotalText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TotalText.Name = "TotalText";
            this.TotalText.ReadOnly = true;
            this.TotalText.Size = new System.Drawing.Size(260, 38);
            this.TotalText.TabIndex = 25;
            this.TotalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 653);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 32);
            this.label5.TabIndex = 29;
            this.label5.Text = "$";
            // 
            // SatisfiedClientsLabel
            // 
            this.SatisfiedClientsLabel.AutoSize = true;
            this.SatisfiedClientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SatisfiedClientsLabel.Location = new System.Drawing.Point(560, 420);
            this.SatisfiedClientsLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.SatisfiedClientsLabel.Name = "SatisfiedClientsLabel";
            this.SatisfiedClientsLabel.Size = new System.Drawing.Size(388, 46);
            this.SatisfiedClientsLabel.TabIndex = 30;
            this.SatisfiedClientsLabel.Text = "Satisfied customers";
            // 
            // UnsatisfiedClientsLabel
            // 
            this.UnsatisfiedClientsLabel.AutoSize = true;
            this.UnsatisfiedClientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnsatisfiedClientsLabel.Location = new System.Drawing.Point(507, 310);
            this.UnsatisfiedClientsLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.UnsatisfiedClientsLabel.Name = "UnsatisfiedClientsLabel";
            this.UnsatisfiedClientsLabel.Size = new System.Drawing.Size(434, 46);
            this.UnsatisfiedClientsLabel.TabIndex = 31;
            this.UnsatisfiedClientsLabel.Text = "Unsatisfied customers";
            // 
            // UnsatisfiedClientsText
            // 
            this.UnsatisfiedClientsText.Enabled = false;
            this.UnsatisfiedClientsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UnsatisfiedClientsText.Location = new System.Drawing.Point(832, 365);
            this.UnsatisfiedClientsText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.UnsatisfiedClientsText.Name = "UnsatisfiedClientsText";
            this.UnsatisfiedClientsText.ReadOnly = true;
            this.UnsatisfiedClientsText.Size = new System.Drawing.Size(87, 38);
            this.UnsatisfiedClientsText.TabIndex = 32;
            this.UnsatisfiedClientsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SatisfiedClientsText
            // 
            this.SatisfiedClientsText.Enabled = false;
            this.SatisfiedClientsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SatisfiedClientsText.Location = new System.Drawing.Point(832, 475);
            this.SatisfiedClientsText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.SatisfiedClientsText.Name = "SatisfiedClientsText";
            this.SatisfiedClientsText.ReadOnly = true;
            this.SatisfiedClientsText.Size = new System.Drawing.Size(87, 38);
            this.SatisfiedClientsText.TabIndex = 33;
            this.SatisfiedClientsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(371, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 46);
            this.label2.TabIndex = 34;
            this.label2.Text = "Summary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(517, 527);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // ForLabel
            // 
            this.ForLabel.AutoSize = true;
            this.ForLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForLabel.Location = new System.Drawing.Point(408, 105);
            this.ForLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ForLabel.Name = "ForLabel";
            this.ForLabel.Size = new System.Drawing.Size(149, 46);
            this.ForLabel.TabIndex = 37;
            this.ForLabel.Text = "for day";
            // 
            // DayText
            // 
            this.DayText.Enabled = false;
            this.DayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayText.Location = new System.Drawing.Point(443, 193);
            this.DayText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DayText.Name = "DayText";
            this.DayText.ReadOnly = true;
            this.DayText.Size = new System.Drawing.Size(87, 53);
            this.DayText.TabIndex = 38;
            this.DayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 975);
            this.Controls.Add(this.DayText);
            this.Controls.Add(this.ForLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SatisfiedClientsText);
            this.Controls.Add(this.UnsatisfiedClientsText);
            this.Controls.Add(this.UnsatisfiedClientsLabel);
            this.Controls.Add(this.SatisfiedClientsLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RentLabel);
            this.Controls.Add(this.WagesLabel);
            this.Controls.Add(this.RentText);
            this.Controls.Add(this.WagesText);
            this.Controls.Add(this.RevenueText);
            this.Controls.Add(this.CostsLabel);
            this.Controls.Add(this.RevenuesLabel);
            this.Controls.Add(this.ContinueButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 975);
            this.MinimumSize = new System.Drawing.Size(1000, 975);
            this.Name = "SummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SummaryForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Label RevenuesLabel;
        private System.Windows.Forms.Label CostsLabel;
        private System.Windows.Forms.TextBox RevenueText;
        private System.Windows.Forms.TextBox WagesText;
        private System.Windows.Forms.TextBox RentText;
        private System.Windows.Forms.Label WagesLabel;
        private System.Windows.Forms.Label RentLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SatisfiedClientsLabel;
        private System.Windows.Forms.Label UnsatisfiedClientsLabel;
        private System.Windows.Forms.TextBox UnsatisfiedClientsText;
        private System.Windows.Forms.TextBox SatisfiedClientsText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ForLabel;
        private System.Windows.Forms.TextBox DayText;
    }
}