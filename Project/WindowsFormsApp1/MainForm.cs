using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        // BottomPanelPic Function
        public void BottomPanelPic()
        {
            var file = TagLib.File.Create(files[dataGridView1.SelectedRows[0].Index]);
            var mStream = new MemoryStream();
            var firstPicture = file.Tag.Pictures.FirstOrDefault();
            if (firstPicture != null)
            {
                byte[] pData = firstPicture.Data.Data;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                var bm = new Bitmap(mStream, false);
                mStream.Dispose();
                coverPictureBox.Image = bm;
            }
            else
            {
                coverPictureBox.Image = Image.FromFile(@"..\..\Resources\Default.png");
            }
        }

        // BottomPanel Song Name and Artist Function
        public void BottomPanelSongArtist ()
        {
            var file = TagLib.File.Create(files[dataGridView1.SelectedRows[0].Index]);
            if (file.Tag.Title == null)
            {
                SongName.Text = "Unknown";
            }
            else
            {
                SongName.Text = file.Tag.Title;
            }
            if (file.Tag.Title == null)
            {
                ArtistName.Text = "Unknown";
            }
            else
            {
                ArtistName.Text = file.Tag.FirstPerformer;
            }
        }

        // Resources
        Icon PlayIcon = new Icon(@"..\..\Resources\Playbutton_White.ico");
        Icon PauseIcon = new Icon(@"..\..\Resources\Pausebutton_WhiteBlack1.ico");
        
        public MainForm()
        {
            InitializeComponent();

            //Import Custom Font
            PrivateFontCollection BadSignal = new PrivateFontCollection();
            BadSignal.AddFontFile(@"..\..\Fonts\BadSignal.otf");
            foreach (Control A in this.Controls)
            {
                title1_TheMethod.Font = new Font(BadSignal.Families[0], 48, FontStyle.Regular);
            }

            //Import Only .mp3 and Allow Multiple Files
            openFileDialog.DefaultExt = "mp3";
            openFileDialog.Filter = "MP3 Files (*.mp3)|*.mp3";
            openFileDialog.Multiselect = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // Import Songs
        string[] path, files;
        private void ImportSongsButton_Click(object sender, EventArgs e)
        {
            // Add songs to playlist
            if (openFileDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                NoSongs.Visible = false;
                files = openFileDialog.FileNames;
                path = openFileDialog.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    var file = TagLib.File.Create(files[x]);
                    string title = file.Tag.Title;
                    string artist = file.Tag.FirstPerformer;
                    string genre = file.Tag.FirstGenre;
                    double secs = file.Properties.Duration.TotalSeconds;
                    TimeSpan conv = TimeSpan.FromSeconds(secs);
                    string duration = string.Format("{0:D2}:{1:D2}", conv.Minutes, conv.Seconds);
                    dataGridView1.Rows.Add(PlayIcon,title, artist, genre, duration);
                }

                // Link WindowMediaPlayer To first song
                Player.URL = path[0];
                Player.Ctlcontrols.stop();

                // BottomPanel Song Name And Artist Function Call
                BottomPanelSongArtist();

                // BottomPanelPic Function Call
                BottomPanelPic();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            btn1_NowPlaying.PerformClick();
            btn1_NowPlaying.Focus();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            btn1_NowPlaying.PerformClick();
            btn1_NowPlaying.Focus();
        }

        private void btn1_NowPlaying_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
            dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value = PlayIcon;
            // Connect it with bottom playbutton
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                PlayPic.Image = Image.FromFile(@"..\..\Resources\Pausebutton_WhiteBlack1.png");
            }
            else
            {
                PlayPic.Image = Image.FromFile(@"..\..\Resources\Playbutton_RedWhite1.png");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Player.Ctlcontrols.pause();
                dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value = PlayIcon;
                PlayPic.Image = Image.FromFile(@"..\..\Resources\Playbutton_RedWhite1.png");
            }
            else
            {
                Player.Ctlcontrols.play();
                dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value = PauseIcon;
                PlayPic.Image = Image.FromFile(@"..\..\Resources\Pausebutton_WhiteBlack1.png");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void btn2_Songs_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Playlists_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Favourites_Click(object sender, EventArgs e)
        {

        }

        private void SongListPanel_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        int current;
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // One Click Song Plays, Second Click Song Stops
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying && current == dataGridView1.SelectedRows[0].Index)
            {
                Player.Ctlcontrols.stop();
                dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value = PlayIcon;
                PlayPic.Image = Image.FromFile(@"..\..\Resources\Playbutton_RedWhite1.png");
            }
            else
            {
                Player.URL = path[dataGridView1.SelectedRows[0].Index];
                Player.Ctlcontrols.play(); 
                current = dataGridView1.SelectedRows[0].Index;
                for (int x = 0; x < files.Length; x++)
                {
                    dataGridView1[0, x].Value = PlayIcon;
                }
                dataGridView1[0, current].Value = PauseIcon;
                PlayPic.Image = Image.FromFile(@"..\..\Resources\Pausebutton_WhiteBlack1.png");
            }

            // BottomPanel Song Name And Artist Function Call
            BottomPanelSongArtist();

            // BottomPanelPic Function Call
            BottomPanelPic();
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            style2.BackColor = Color.Black;
            if (e.RowIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle = style2;
            }
        }

        private void PlayPic_MouseEnter(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                PlayPic.Image = Image.FromFile(@"..\..\Resources\Pausebutton_WhiteBlackHover.png");
            }
            else
            {
                PlayPic.Image = Image.FromFile(@"..\..\Resources\Playbutton_RedWhiteHover.png");
            }
        }

        private void PlayPic_MouseLeave(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                PlayPic.Image = Image.FromFile(@"..\..\Resources\Pausebutton_WhiteBlack1.png");
            }
            else
            {
                PlayPic.Image = Image.FromFile(@"..\..\Resources\Playbutton_RedWhite1.png");
            }
        }

        private void StopPic_MouseEnter(object sender, EventArgs e)
        {
            StopPic.Image = Image.FromFile(@"..\..\Resources\Stopbutton_WhiteBlackHover.png"); 
        }

        private void StopPic_MouseLeave(object sender, EventArgs e)
        {
            StopPic.Image = Image.FromFile(@"..\..\Resources\Stopbutton_WhiteBlack1.png");
        }

        private void PrevSongPic_MouseEnter(object sender, EventArgs e)
        {
            PrevSongPic.Image = Image.FromFile(@"..\..\Resources\previous-song-hover.png");
        }

        private void PrevSongPic_MouseLeave(object sender, EventArgs e)
        {
            PrevSongPic.Image = Image.FromFile(@"..\..\Resources\previous-song.png");
        }

        private void NextSongPic_MouseEnter(object sender, EventArgs e)
        {
            NextSongPic.Image = Image.FromFile(@"..\..\Resources\next-song-hover.png");
        }

        private void NextSongPic_MouseLeave(object sender, EventArgs e)
        {
            NextSongPic.Image = Image.FromFile(@"..\..\Resources\next-song.png");
        }

        private void SpeakerPic_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void SpeakerPic_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void PrevSongPic_Click(object sender, EventArgs e)
        {
            int x = dataGridView1.SelectedRows[0].Index;
            if (x==0)
            {
                Player.URL = path[x];
                Player.Ctlcontrols.play();
            }
            else
            {
                dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value = PlayIcon;
                --x;
                dataGridView1.Rows[x].Selected = true;
                dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value = PauseIcon;
                Player.URL = path[x];
                Player.Ctlcontrols.play();
            }
            PlayPic.Image = Image.FromFile(@"..\..\Resources\Pausebutton_WhiteBlack1.png");

            // BottomPanel Song Name And Artist Function Call
            BottomPanelSongArtist();

            // BottomPanelPic Function Call
            BottomPanelPic();
        }

        private void NextSongPic_Click(object sender, EventArgs e)
        {
            string [] FileNum = openFileDialog.FileNames;
            int x = dataGridView1.SelectedRows[0].Index;
            if (x == FileNum.Length-1)
            {
                Player.URL = path[x];
                Player.Ctlcontrols.play();
            }
            else
            {
                dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value = PlayIcon; 
                ++x;
                dataGridView1.Rows[x].Selected = true;
                dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value = PauseIcon;
                Player.URL = path[x];
                Player.Ctlcontrols.play();
            }

            PlayPic.Image = Image.FromFile(@"..\..\Resources\Pausebutton_WhiteBlack1.png");

            // BottomPanel Song Name And Artist Function Call
            BottomPanelSongArtist();

            // BottomPanelPic Function Call
            BottomPanelPic();
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            style1.BackColor = Color.FromArgb(240, 84, 84);
            if (e.RowIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle = style1;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                SongSlider.Maximum = (int)Player.Ctlcontrols.currentItem.duration;
                SongSlider.Value = (int)Player.Ctlcontrols.currentPosition;
                SongTimer.Text = Player.Ctlcontrols.currentPositionString;
            }
        }

        private void SongSlider_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {

        }

        private void SoundSlider_Scroll(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs e)
        {
            Player.settings.volume = SoundSlider.Value;
        }

        private void coverPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
