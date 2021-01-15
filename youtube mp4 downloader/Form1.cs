using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaToolkit;
using VideoLibrary;

namespace youtube_mp4_downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool formatchecket = true;
        // if true= mp3 download
        //if false = mp4 download

        private async void btn_download_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog()
            {
                Description = "select download folder! :)"
            })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    lbl_stuts.Text = "Video download started";
                    lbl_stuts.ForeColor=Color.Red;
                    var youtube = YouTube.Default;
                    var video = await youtube.GetVideoAsync(txt_url.Text);
                    File.WriteAllBytes(fdb.SelectedPath + @"\" + video.FullName,await video.GetBytesAsync());


                    var input = new MediaToolkit.Model.MediaFile() { Filename = fdb.SelectedPath + @"\" + video.FullName};
                    var output = new MediaToolkit.Model.MediaFile() { Filename = $" {fdb.SelectedPath + @"\" + video.FullName}.mp3 "  };

                    using (var enging = new Engine())
                    {
                        enging.GetMetadata(input);
                        enging.Convert(input,output);
                    }

                    if (formatchecket == true)
                    {
                        File.Delete(fdb.SelectedPath + @"\" + video.FullName);
                    }
                    else
                    {
                        File.Delete($" {fdb.SelectedPath + @"\" + video.FullName}.mp3 ");
                    }

                    lbl_stuts.Text = "Video Downloaded";
                    lbl_stuts.ForeColor = Color.LawnGreen;
                }
                else
                {
                    MessageBox.Show("not selected download folder !!", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            } ;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdb_mp4_CheckedChanged(object sender, EventArgs e)
        {
            formatchecket = false;
        }

        private void rdb_mp3_CheckedChanged(object sender, EventArgs e)
        {
            formatchecket = true;
        }
    }
}
