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

        //Import Songs

        string[] path, files;
        Icon ic = new Icon(@"..\..\Resources\Playbutton_White.ico");
        private void ImportSongsButton_Click(object sender, EventArgs e)
        {
            //Save Songs
            if(openFileDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
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
                    string duration = string.Format("{0:D1}:{1:D2}", conv.Minutes, conv.Seconds);
                    dataGridView1.Rows.Add(ic,title, artist, genre, duration);
                }
            }
            //Toggle Songs Button
            /*btn2_Songs.PerformClick();
            btn2_Songs.Focus();*/
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

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(SoundSlider.Visible == false)
            {
                SoundSlider.Visible = true;
            }
            else
            {
                SoundSlider.Visible = false;
            }
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            style1.BackColor = Color.FromArgb(240, 84, 84);
            if (e.RowIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle = style1;
            }
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

        private void coverPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
