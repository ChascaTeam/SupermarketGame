﻿namespace Supermarket.Client.Forms
{
    partial class MenuStartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuStartForm));
            this.StartMenuImg = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.GameInfo = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartMenuImg)).BeginInit();
            this.SuspendLayout();
            // 
            // StartMenuImg
            // 
            this.StartMenuImg.Image = ((System.Drawing.Image)(resources.GetObject("StartMenuImg.Image")));
            this.StartMenuImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("StartMenuImg.InitialImage")));
            this.StartMenuImg.Location = new System.Drawing.Point(53, 29);
            this.StartMenuImg.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.StartMenuImg.MaximumSize = new System.Drawing.Size(893, 591);
            this.StartMenuImg.MinimumSize = new System.Drawing.Size(893, 591);
            this.StartMenuImg.Name = "StartMenuImg";
            this.StartMenuImg.Size = new System.Drawing.Size(893, 591);
            this.StartMenuImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartMenuImg.TabIndex = 4;
            this.StartMenuImg.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.StartButton.Location = new System.Drawing.Point(314, 634);
            this.StartButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(323, 67);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start Game";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // GameInfo
            // 
            this.GameInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameInfo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.GameInfo.Location = new System.Drawing.Point(314, 715);
            this.GameInfo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GameInfo.Name = "GameInfo";
            this.GameInfo.Size = new System.Drawing.Size(323, 67);
            this.GameInfo.TabIndex = 6;
            this.GameInfo.Text = "Game Info";
            this.GameInfo.UseVisualStyleBackColor = true;
            this.GameInfo.Click += new System.EventHandler(this.GameInfo_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.SystemColors.Control;
            this.QuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.QuitButton.Location = new System.Drawing.Point(314, 796);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(323, 67);
            this.QuitButton.TabIndex = 7;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // MenuStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 975);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.GameInfo);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StartMenuImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 975);
            this.MinimumSize = new System.Drawing.Size(1000, 975);
            this.Name = "MenuStartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supermarket Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.StartMenuImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StartMenuImg;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button GameInfo;
        private System.Windows.Forms.Button QuitButton;
    }
}