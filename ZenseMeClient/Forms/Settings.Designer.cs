﻿namespace ZenseMe.Client.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_LastFMUsername = new System.Windows.Forms.TextBox();
            this.lbl_lastfmusername = new System.Windows.Forms.Label();
            this.txt_LastFMPassword = new System.Windows.Forms.TextBox();
            this.lbl_lastfmpassword = new System.Windows.Forms.Label();
            this.lbl_Scrobble_BetweenTime = new System.Windows.Forms.Label();
            this.txt_Scrobble_BetweenTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_FetchAlbumArtist = new System.Windows.Forms.Label();
            this.cb_FetchAlbumArtist = new System.Windows.Forms.CheckBox();
            this.lbl_version = new System.Windows.Forms.Label();
            this.lbl_SettingsTitle = new System.Windows.Forms.Label();
            this.cb_FixUtcNowTime = new System.Windows.Forms.CheckBox();
            this.lbl_FixUtcNowTime = new System.Windows.Forms.Label();
            this.cb_HttpsConnection = new System.Windows.Forms.CheckBox();
            this.lbl_HttpsConnection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(223, 203);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(62, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_LastFMUsername
            // 
            this.txt_LastFMUsername.Location = new System.Drawing.Point(119, 55);
            this.txt_LastFMUsername.Name = "txt_LastFMUsername";
            this.txt_LastFMUsername.Size = new System.Drawing.Size(144, 22);
            this.txt_LastFMUsername.TabIndex = 7;
            // 
            // lbl_lastfmusername
            // 
            this.lbl_lastfmusername.AutoSize = true;
            this.lbl_lastfmusername.Location = new System.Drawing.Point(16, 58);
            this.lbl_lastfmusername.Name = "lbl_lastfmusername";
            this.lbl_lastfmusername.Size = new System.Drawing.Size(96, 13);
            this.lbl_lastfmusername.TabIndex = 6;
            this.lbl_lastfmusername.Text = "Last.fm username";
            // 
            // txt_LastFMPassword
            // 
            this.txt_LastFMPassword.Location = new System.Drawing.Point(119, 80);
            this.txt_LastFMPassword.Name = "txt_LastFMPassword";
            this.txt_LastFMPassword.Size = new System.Drawing.Size(144, 22);
            this.txt_LastFMPassword.TabIndex = 9;
            this.txt_LastFMPassword.UseSystemPasswordChar = true;
            // 
            // lbl_lastfmpassword
            // 
            this.lbl_lastfmpassword.AutoSize = true;
            this.lbl_lastfmpassword.Location = new System.Drawing.Point(16, 83);
            this.lbl_lastfmpassword.Name = "lbl_lastfmpassword";
            this.lbl_lastfmpassword.Size = new System.Drawing.Size(96, 13);
            this.lbl_lastfmpassword.TabIndex = 8;
            this.lbl_lastfmpassword.Text = "Last.fm password";
            // 
            // lbl_Scrobble_BetweenTime
            // 
            this.lbl_Scrobble_BetweenTime.AutoSize = true;
            this.lbl_Scrobble_BetweenTime.Location = new System.Drawing.Point(16, 109);
            this.lbl_Scrobble_BetweenTime.Name = "lbl_Scrobble_BetweenTime";
            this.lbl_Scrobble_BetweenTime.Size = new System.Drawing.Size(198, 13);
            this.lbl_Scrobble_BetweenTime.TabIndex = 11;
            this.lbl_Scrobble_BetweenTime.Text = "Time between double scrobble tracks";
            // 
            // txt_Scrobble_BetweenTime
            // 
            this.txt_Scrobble_BetweenTime.Location = new System.Drawing.Point(227, 105);
            this.txt_Scrobble_BetweenTime.Name = "txt_Scrobble_BetweenTime";
            this.txt_Scrobble_BetweenTime.Size = new System.Drawing.Size(36, 22);
            this.txt_Scrobble_BetweenTime.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sec";
            // 
            // lbl_FetchAlbumArtist
            // 
            this.lbl_FetchAlbumArtist.AutoSize = true;
            this.lbl_FetchAlbumArtist.Location = new System.Drawing.Point(16, 133);
            this.lbl_FetchAlbumArtist.Name = "lbl_FetchAlbumArtist";
            this.lbl_FetchAlbumArtist.Size = new System.Drawing.Size(150, 13);
            this.lbl_FetchAlbumArtist.TabIndex = 14;
            this.lbl_FetchAlbumArtist.Text = "Fetch the album artist name";
            // 
            // cb_FetchAlbumArtist
            // 
            this.cb_FetchAlbumArtist.AutoSize = true;
            this.cb_FetchAlbumArtist.Location = new System.Drawing.Point(250, 133);
            this.cb_FetchAlbumArtist.Name = "cb_FetchAlbumArtist";
            this.cb_FetchAlbumArtist.Size = new System.Drawing.Size(15, 14);
            this.cb_FetchAlbumArtist.TabIndex = 15;
            this.cb_FetchAlbumArtist.UseVisualStyleBackColor = true;
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(16, 201);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(45, 13);
            this.lbl_version.TabIndex = 16;
            this.lbl_version.Text = "Version";
            // 
            // lbl_SettingsTitle
            // 
            this.lbl_SettingsTitle.AutoSize = true;
            this.lbl_SettingsTitle.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.lbl_SettingsTitle.Location = new System.Drawing.Point(12, 9);
            this.lbl_SettingsTitle.Name = "lbl_SettingsTitle";
            this.lbl_SettingsTitle.Size = new System.Drawing.Size(105, 37);
            this.lbl_SettingsTitle.TabIndex = 17;
            this.lbl_SettingsTitle.Text = "Settings";
            // 
            // cb_FixUtcNowTime
            // 
            this.cb_FixUtcNowTime.AutoSize = true;
            this.cb_FixUtcNowTime.Location = new System.Drawing.Point(250, 154);
            this.cb_FixUtcNowTime.Name = "cb_FixUtcNowTime";
            this.cb_FixUtcNowTime.Size = new System.Drawing.Size(15, 14);
            this.cb_FixUtcNowTime.TabIndex = 19;
            this.cb_FixUtcNowTime.UseVisualStyleBackColor = true;
            // 
            // lbl_FixUtcNowTime
            // 
            this.lbl_FixUtcNowTime.AutoSize = true;
            this.lbl_FixUtcNowTime.Location = new System.Drawing.Point(16, 154);
            this.lbl_FixUtcNowTime.Name = "lbl_FixUtcNowTime";
            this.lbl_FixUtcNowTime.Size = new System.Drawing.Size(149, 13);
            this.lbl_FixUtcNowTime.TabIndex = 18;
            this.lbl_FixUtcNowTime.Text = "Fix UTC scrobble time stamp";
            // 
            // cb_HttpsConnection
            // 
            this.cb_HttpsConnection.AutoSize = true;
            this.cb_HttpsConnection.Location = new System.Drawing.Point(250, 175);
            this.cb_HttpsConnection.Name = "cb_HttpsConnection";
            this.cb_HttpsConnection.Size = new System.Drawing.Size(15, 14);
            this.cb_HttpsConnection.TabIndex = 21;
            this.cb_HttpsConnection.UseVisualStyleBackColor = true;
            // 
            // lbl_HttpsConnection
            // 
            this.lbl_HttpsConnection.AutoSize = true;
            this.lbl_HttpsConnection.Location = new System.Drawing.Point(16, 175);
            this.lbl_HttpsConnection.Name = "lbl_HttpsConnection";
            this.lbl_HttpsConnection.Size = new System.Drawing.Size(139, 13);
            this.lbl_HttpsConnection.TabIndex = 20;
            this.lbl_HttpsConnection.Text = "Use HTTPS api connection";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(299, 236);
            this.Controls.Add(this.cb_HttpsConnection);
            this.Controls.Add(this.lbl_HttpsConnection);
            this.Controls.Add(this.cb_FixUtcNowTime);
            this.Controls.Add(this.lbl_FixUtcNowTime);
            this.Controls.Add(this.lbl_SettingsTitle);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.cb_FetchAlbumArtist);
            this.Controls.Add(this.lbl_FetchAlbumArtist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Scrobble_BetweenTime);
            this.Controls.Add(this.lbl_Scrobble_BetweenTime);
            this.Controls.Add(this.txt_LastFMPassword);
            this.Controls.Add(this.lbl_lastfmpassword);
            this.Controls.Add(this.txt_LastFMUsername);
            this.Controls.Add(this.lbl_lastfmusername);
            this.Controls.Add(this.btn_Save);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(315, 275);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(315, 275);
            this.Name = "Settings";
            this.Text = "ZenseMe - Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_LastFMUsername;
        private System.Windows.Forms.Label lbl_lastfmusername;
        private System.Windows.Forms.TextBox txt_LastFMPassword;
        private System.Windows.Forms.Label lbl_lastfmpassword;
        private System.Windows.Forms.Label lbl_Scrobble_BetweenTime;
        private System.Windows.Forms.TextBox txt_Scrobble_BetweenTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_FetchAlbumArtist;
        private System.Windows.Forms.CheckBox cb_FetchAlbumArtist;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label lbl_SettingsTitle;
        private System.Windows.Forms.CheckBox cb_FixUtcNowTime;
        private System.Windows.Forms.Label lbl_FixUtcNowTime;
        private System.Windows.Forms.CheckBox cb_HttpsConnection;
        private System.Windows.Forms.Label lbl_HttpsConnection;
    }
}