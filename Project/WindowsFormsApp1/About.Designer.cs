﻿namespace WindowsFormsApp1
{
    partial class About
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ExitPicture = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Title = new System.Windows.Forms.Label();
            this.lbl_TheMethod = new System.Windows.Forms.Label();
            this.lbl_MusicPlayer = new System.Windows.Forms.Label();
            this.lbl_BETA = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.lbl_Copyrights = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ExitPicture
            // 
            this.ExitPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPicture.Image = global::WindowsFormsApp1.Properties.Resources.White_X;
            this.ExitPicture.Location = new System.Drawing.Point(421, 12);
            this.ExitPicture.Name = "ExitPicture";
            this.ExitPicture.Size = new System.Drawing.Size(17, 25);
            this.ExitPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitPicture.TabIndex = 1;
            this.ExitPicture.TabStop = false;
            this.ExitPicture.Click += new System.EventHandler(this.ExitPicture_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(171, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 35);
            this.Title.TabIndex = 5;
            this.Title.Text = "About";
            // 
            // lbl_TheMethod
            // 
            this.lbl_TheMethod.AutoSize = true;
            this.lbl_TheMethod.Font = new System.Drawing.Font("Bad Signal", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TheMethod.ForeColor = System.Drawing.Color.White;
            this.lbl_TheMethod.Location = new System.Drawing.Point(12, 122);
            this.lbl_TheMethod.Name = "lbl_TheMethod";
            this.lbl_TheMethod.Size = new System.Drawing.Size(410, 93);
            this.lbl_TheMethod.TabIndex = 6;
            this.lbl_TheMethod.Text = "The Method";
            // 
            // lbl_MusicPlayer
            // 
            this.lbl_MusicPlayer.AutoSize = true;
            this.lbl_MusicPlayer.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MusicPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.lbl_MusicPlayer.Location = new System.Drawing.Point(18, 203);
            this.lbl_MusicPlayer.Name = "lbl_MusicPlayer";
            this.lbl_MusicPlayer.Size = new System.Drawing.Size(319, 56);
            this.lbl_MusicPlayer.TabIndex = 7;
            this.lbl_MusicPlayer.Text = "Music Player";
            // 
            // lbl_BETA
            // 
            this.lbl_BETA.AutoSize = true;
            this.lbl_BETA.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BETA.ForeColor = System.Drawing.Color.White;
            this.lbl_BETA.Location = new System.Drawing.Point(370, 202);
            this.lbl_BETA.Name = "lbl_BETA";
            this.lbl_BETA.Size = new System.Drawing.Size(52, 19);
            this.lbl_BETA.TabIndex = 8;
            this.lbl_BETA.Text = "BETA";
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Version.ForeColor = System.Drawing.Color.White;
            this.lbl_Version.Location = new System.Drawing.Point(15, 324);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(105, 24);
            this.lbl_Version.TabIndex = 9;
            this.lbl_Version.Text = "Version 1.0";
            // 
            // lbl_Copyrights
            // 
            this.lbl_Copyrights.AutoSize = true;
            this.lbl_Copyrights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Copyrights.ForeColor = System.Drawing.Color.White;
            this.lbl_Copyrights.Location = new System.Drawing.Point(15, 349);
            this.lbl_Copyrights.Name = "lbl_Copyrights";
            this.lbl_Copyrights.Size = new System.Drawing.Size(297, 24);
            this.lbl_Copyrights.TabIndex = 10;
            this.lbl_Copyrights.Text = "© The Method. All rights reserved.";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.lbl_Copyrights);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.lbl_BETA);
            this.Controls.Add(this.lbl_MusicPlayer);
            this.Controls.Add(this.lbl_TheMethod);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ExitPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.ExitPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox ExitPicture;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lbl_BETA;
        private System.Windows.Forms.Label lbl_TheMethod;
        public System.Windows.Forms.Label Title;
        public System.Windows.Forms.Label lbl_MusicPlayer;
        public System.Windows.Forms.Label lbl_Version;
        public System.Windows.Forms.Label lbl_Copyrights;
    }
}