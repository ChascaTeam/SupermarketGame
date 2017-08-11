namespace Supermarket.Client.Forms
{
    partial class InfoMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoMenuForm));
            this.GameInfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentMoneyText = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameInfoLabel
            // 
            this.GameInfoLabel.AutoSize = true;
            this.GameInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameInfoLabel.Location = new System.Drawing.Point(127, 9);
            this.GameInfoLabel.Name = "GameInfoLabel";
            this.GameInfoLabel.Size = new System.Drawing.Size(94, 20);
            this.GameInfoLabel.TabIndex = 8;
            this.GameInfoLabel.Text = "Game Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(127, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "How to play";
            // 
            // CurrentMoneyText
            // 
            this.CurrentMoneyText.Location = new System.Drawing.Point(12, 92);
            this.CurrentMoneyText.Multiline = true;
            this.CurrentMoneyText.Name = "CurrentMoneyText";
            this.CurrentMoneyText.ReadOnly = true;
            this.CurrentMoneyText.Size = new System.Drawing.Size(335, 232);
            this.CurrentMoneyText.TabIndex = 12;
            this.CurrentMoneyText.Text = resources.GetString("CurrentMoneyText.Text");
            // 
            // BackButton
            // 
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.BackButton.Location = new System.Drawing.Point(108, 330);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(121, 28);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // InfoMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 370);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CurrentMoneyText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameInfoLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 409);
            this.MinimumSize = new System.Drawing.Size(375, 409);
            this.Name = "InfoMenuForm";
            this.Text = "Supermarket Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameInfoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CurrentMoneyText;
        private System.Windows.Forms.Button BackButton;
    }
}