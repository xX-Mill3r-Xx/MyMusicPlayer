using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            track_Volume.Value = 50;
            lb_Volume.Text = "50%";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string[] paths, files;

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player.URL = paths[track_list.SelectedIndex];
            Player.Ctlcontrols.play();
            try
            {
                var file = TagLib.File.Create(paths[track_list.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pic_Art.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch
            {

            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
            p_Bar.Value = 0;
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count-1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                p_Bar.Maximum = (int)Player.Ctlcontrols.currentItem.duration;
                p_Bar.Value = (int)Player.Ctlcontrols.currentPosition;
            }
            try
            {
                lb_track_start.Text = Player.Ctlcontrols.currentPositionString;
                //lb_track_end.Text = Player.Ctlcontrols.currentItem.durationString.ToString();
            }
            catch
            {

            }
        }

        private void track_Volume_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = track_Volume.Value;
            lb_Volume.Text = track_Volume.Value.ToString() + "%";
        }

        private void p_Bar_MouseDown(object sender, MouseEventArgs e)
        {
            Player.Ctlcontrols.currentPosition = Player.currentMedia.duration * e.X / p_Bar.Width;
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    track_list.Items.Add(files[i]);
                }
            }
        }
    }
}
