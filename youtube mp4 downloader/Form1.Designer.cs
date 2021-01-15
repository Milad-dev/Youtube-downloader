namespace youtube_mp4_downloader
{
    partial class Form1
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
            this.lbl_header = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.rdb_mp3 = new System.Windows.Forms.RadioButton();
            this.rdb_mp4 = new System.Windows.Forms.RadioButton();
            this.btn_download = new System.Windows.Forms.Button();
            this.lbl_stuts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.lbl_header.Location = new System.Drawing.Point(2, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(345, 44);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Youtube MP3/MP4 Downloader";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(37, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Video URL :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(53, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Format :";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(123, 63);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(180, 20);
            this.txt_url.TabIndex = 3;
            // 
            // rdb_mp3
            // 
            this.rdb_mp3.AutoSize = true;
            this.rdb_mp3.Checked = true;
            this.rdb_mp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_mp3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.rdb_mp3.Location = new System.Drawing.Point(123, 93);
            this.rdb_mp3.Name = "rdb_mp3";
            this.rdb_mp3.Size = new System.Drawing.Size(53, 20);
            this.rdb_mp3.TabIndex = 4;
            this.rdb_mp3.TabStop = true;
            this.rdb_mp3.Text = "MP3";
            this.rdb_mp3.UseVisualStyleBackColor = true;
            this.rdb_mp3.CheckedChanged += new System.EventHandler(this.rdb_mp3_CheckedChanged);
            // 
            // rdb_mp4
            // 
            this.rdb_mp4.AutoSize = true;
            this.rdb_mp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_mp4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.rdb_mp4.Location = new System.Drawing.Point(191, 93);
            this.rdb_mp4.Name = "rdb_mp4";
            this.rdb_mp4.Size = new System.Drawing.Size(53, 20);
            this.rdb_mp4.TabIndex = 5;
            this.rdb_mp4.Text = "MP4";
            this.rdb_mp4.UseVisualStyleBackColor = true;
            this.rdb_mp4.CheckedChanged += new System.EventHandler(this.rdb_mp4_CheckedChanged);
            // 
            // btn_download
            // 
            this.btn_download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btn_download.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_download.ForeColor = System.Drawing.Color.White;
            this.btn_download.Location = new System.Drawing.Point(56, 130);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(247, 36);
            this.btn_download.TabIndex = 6;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = false;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // lbl_stuts
            // 
            this.lbl_stuts.ForeColor = System.Drawing.Color.Lime;
            this.lbl_stuts.Location = new System.Drawing.Point(12, 185);
            this.lbl_stuts.Name = "lbl_stuts";
            this.lbl_stuts.Size = new System.Drawing.Size(325, 23);
            this.lbl_stuts.TabIndex = 7;
            this.lbl_stuts.Text = "-";
            this.lbl_stuts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(349, 217);
            this.Controls.Add(this.lbl_stuts);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.rdb_mp4);
            this.Controls.Add(this.rdb_mp3);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_header);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Youtube Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.RadioButton rdb_mp3;
        private System.Windows.Forms.RadioButton rdb_mp4;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Label lbl_stuts;
    }
}

