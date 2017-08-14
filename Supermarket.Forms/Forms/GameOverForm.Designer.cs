namespace Supermarket.Forms.Forms
{
    partial class GameOverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TryAgainButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // TryAgainButton
            // 
            this.TryAgainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TryAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TryAgainButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TryAgainButton.Location = new System.Drawing.Point(108, 256);
            this.TryAgainButton.Name = "TryAgainButton";
            this.TryAgainButton.Size = new System.Drawing.Size(121, 28);
            this.TryAgainButton.TabIndex = 29;
            this.TryAgainButton.Text = "Try Again";
            this.TryAgainButton.UseVisualStyleBackColor = true;
            // 
            // QuitButton
            // 
            this.QuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuitButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.QuitButton.Location = new System.Drawing.Point(108, 301);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(121, 28);
            this.QuitButton.TabIndex = 30;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 371);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.TryAgainButton);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 409);
            this.MinimumSize = new System.Drawing.Size(375, 409);
            this.Name = "GameOverForm";
            this.Text = "Supermarket Simulator";
            this.Load += new System.EventHandler(this.GameOverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button TryAgainButton;
        private System.Windows.Forms.Button QuitButton;
    }
}