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
        // Resources
        Icon PlayIcon = new Icon(@"..\..\Resources\Playbutton_White.ico");
        Icon PauseIcon = new Icon(@"..\..\Resources\Pausebutton_WhiteBlack1.ico");
        Icon FavStar = new Icon(@"..\..\Resources\FavStar1.ico");
        Icon FavStarFilled = new Icon(@"..\..\Resources\FavStarFilled1.ico");
        string Default = (@"..\..\Resources\Default.png");
        string RedPlay = (@"..\..\Resources\Playbutton_RedWhite1.png");
        string RedPlayHover = (@"..\..\Resources\Playbutton_RedWhiteHover.png");
        string WhiteStop = (@"..\..\Resources\Stopbutton_WhiteBlack1.png");
        string WhiteStopHover = (@"..\..\Resources\Stopbutton_WhiteBlackHover.png");
        string WhitePause = (@"..\..\Resources\Pausebutton_WhiteBlack1.png");
        string WhitePauseHover = (@"..\..\Resources\Pausebutton_WhiteBlackHover.png");
        string PrevSong = (@"..\..\Resources\previous-song.png");
        string PrevSongHover = (@"..\..\Resources\previous-song-hover.png");
        string NextSong = (@"..\..\Resources\next-song.png");
        string NextSongHover = (@"..\..\Resources\next-song-hover.png");

        // Custom Font
        readonly PrivateFontCollection BadSignal = new PrivateFontCollection();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Import Custom Font
            BadSignal.AddFontFile(@"..\..\Fonts\BadSignal.otf");
            foreach (Control A in this.Controls)
            {
                title1_TheMethod.Font = new Font(BadSignal.Families[0], 48, FontStyle.Regular);
            }

            //Import Only .mp3 and Allow Multiple Select
            Songs_openFileDialog.DefaultExt = "mp3";
            Songs_openFileDialog.Filter = "MP3 Files (*.mp3)|*.mp3";
            Songs_openFileDialog.Multiselect = true;
        }

        // Add Song Picture Function
        public void AddSongPic(PictureBox x, int y)
        {
            var file = TagLib.File.Create(path[y]);
            var mStream = new MemoryStream();
            var firstPicture = file.Tag.Pictures.FirstOrDefault();
            if (firstPicture != null)
            {
                byte[] pData = firstPicture.Data.Data;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                var bm = new Bitmap(mStream, false);
                mStream.Dispose();
                x.Image = bm;
            }
            else
            {
                x.Image = Image.FromFile(Default);
            }
        }

        // Add Song and Artist Names Function
        public void SongAndArtist(Label SongTitle, Label Artist, int x)
        {
            var file = TagLib.File.Create(path[x]);
            if (file.Tag.Title == null)
            {
                SongTitle.Text = "Unknown";
            }
            else
            {
                SongTitle.Text = file.Tag.Title;
            }
            if (file.Tag.FirstPerformer == null)
            {
                Artist.Text = "Unknown";
            }
            else
            {
                Artist.Text = file.Tag.FirstPerformer;
            }
        }

        // Add Song, Artist and Genre Names Function
        public void SongArtistAndGenre(Label SongTitle, Label Artist, Label Genre, int x)
        {
            var file = TagLib.File.Create(path[x]);
            if (file.Tag.Title == null)
            {
                SongTitle.Text = "Unknown";
            }
            else
            {
                SongTitle.Text = file.Tag.Title;
            }
            if (file.Tag.FirstPerformer == null)
            {
                Artist.Text = "Unknown";
            }
            else
            {
                Artist.Text = file.Tag.FirstPerformer;
            }
            if (file.Tag.FirstGenre == null)
            {
                Genre.Text = "Unknown";
            }
            else
            {
                Genre.Text = file.Tag.FirstGenre;
            }
        }

        //Close Form Button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // <-------------------   Songs Page   ------------------->

        // Arrays to import songs
        string[] path;

        //Import Songs Button
        private void ImportSongsButton_Click(object sender, EventArgs e)
        {
            //Import Songs
            if (Songs_openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                NoSongs2.Visible = false;
                path = Songs_openFileDialog.FileNames;
                for (int x = 0; x < path.Length; x++)
                {
                    int z = 0;
                    var file = TagLib.File.Create(path[x]);
                    string title = file.Tag.Title;
                    string artist = file.Tag.FirstPerformer;
                    string genre = file.Tag.FirstGenre;
                    double secs = file.Properties.Duration.TotalSeconds;
                    TimeSpan conv = TimeSpan.FromSeconds(secs);
                    string duration = string.Format("{0:D2}:{1:D2}", conv.Minutes, conv.Seconds);
                    for (int y = 0; y < SongsGrid.RowCount; y++) // Prevent Adding Same Song Twice
                    {
                        if (SongsGrid.Rows[y].Cells[2].Value.ToString().Equals(file.Tag.Title))
                        {
                            z++;
                        }
                    }
                    if (z == 0)
                    {
                        SongsGrid.Rows.Add(x, PlayIcon, title, artist, genre, duration);
                        FavGrid1.Rows.Add(FavStar);
                    }
                }

                //Hide No Songs Label
                NoSongs1_1.Visible = false;

                //Clear Selection on FavGrid1 Grid
                FavGrid1.ClearSelection();

                //Show ScrollBar
                if (SongsGrid.RowCount >= 9)
                {
                    ScrollBarSongs.Visible = true;
                }

                //Scroll Bar Settings
                ScrollBarSongs.Maximum = SongsGrid.RowCount;
                ScrollBarSongs.LargeChange = SongsGrid.DisplayedRowCount(true);
                ScrollBarSongs.SmallChange = 1;

                //Link WindowMediaPlayer To first song
                Player.URL = path[0];
                Player.Ctlcontrols.stop();

                //Add Song and Artist to Bottom Panel
                SongAndArtist(SongTitle2, Artist2, SongsGrid.SelectedRows[0].Index);

                //Add Song Cover to Bottom Panel
                AddSongPic(BottomPanelPicBox, SongsGrid.SelectedRows[0].Index);

                // Add Song, Artist and Genre Names to Now Playing
                SongArtistAndGenre(SongTitle1_2, Artist1_2, Genre1_2, SongsGrid.SelectedRows[0].Index);

                //Add Song Cover to Now Playing
                AddSongPic(SongCoverPicBox, SongsGrid.SelectedRows[0].Index);
            }
        }

        //Syncing Scroll Bar with Songs DataViewGrid
        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                ScrollBarSongs.Value = e.NewValue;
            }
        }
        private void ScrollBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            if (e.Value < SongsGrid.RowCount)
            {
                SongsGrid.FirstDisplayedScrollingRowIndex = e.Value;
                FavGrid1.FirstDisplayedScrollingRowIndex = e.Value;
            }
        }

        //Songs DataGridView Functionality
        int current1, current2;
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // One Click On Row Song Plays, Second Click Song Stops
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying && current1 == SongsGrid.SelectedRows[0].Index)
            {
                Player.Ctlcontrols.stop();
                // Syncing Icons to the current player status
                SongsGrid[1, SongsGrid.SelectedRows[0].Index].Value = PlayIcon;
                for (int x = 0; x < FavouritesGrid.RowCount; x++)
                {
                    if (FavouritesGrid.Rows[x].Cells[0].Value == SongsGrid.Rows[e.RowIndex].Cells[0].Value)
                    {
                        FavouritesGrid[1, x].Value = PlayIcon;
                    }
                }
                PlayPic.Image = Image.FromFile(RedPlay); // Turn BottomPanel PlayButton To Red Play
            }
            else
            {
                Player.URL = path[SongsGrid.SelectedRows[0].Index];
                Player.Ctlcontrols.play();
                current1 = SongsGrid.SelectedRows[0].Index;
                for (int x = 0; x < path.Length; x++) //Reset icons on the left of the songs to PlayIcon
                {
                    SongsGrid[1, x].Value = PlayIcon;
                }
                SongsGrid[1, e.RowIndex].Value = PauseIcon;
                for (int x = 0; x < FavouritesGrid.RowCount; x++)
                {
                    if (FavouritesGrid.Rows[x].Cells[0].Value == SongsGrid.Rows[e.RowIndex].Cells[0].Value)
                    {
                        for (int y = 0; y < FavouritesGrid.RowCount; y++)
                        {
                            FavouritesGrid[1, y].Value = PlayIcon; // Reset All to PlayIcon
                        }
                        FavouritesGrid[1, x].Value = PauseIcon;
                        FavouritesGrid[1, x].Selected = true;
                    }
                    else
                    {
                        FavouritesGrid[1, x].Value = PlayIcon;
                    }
                }
                PlayPic.Image = Image.FromFile(WhitePause); // Turn BottomPanel PlayButton To Pause White
            }

            //Add Song and Artist to Bottom Panel
            SongAndArtist(SongTitle2, Artist2, SongsGrid.SelectedRows[0].Index);

            // Add Song Cover to Bottom Panel
            AddSongPic(BottomPanelPicBox, SongsGrid.SelectedRows[0].Index);

            // Add Song, Artist and Genre Names to Now Playing
            SongArtistAndGenre(SongTitle1_2, Artist1_2, Genre1_2, SongsGrid.SelectedRows[0].Index);

            //Add Song Cover to Now Playing
            AddSongPic(SongCoverPicBox, SongsGrid.SelectedRows[0].Index);
        }

        //FavGrid1 DataGridView Functionality
        private void FavAndDelButtons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Toggle Fav Button On and Off
            if (FavGrid1.Rows[e.RowIndex].Cells[0].Value == FavStar)
            {
                FavGrid1.Rows[e.RowIndex].Cells[0].Value = FavStarFilled;
            }
            else
            {
                FavGrid1.Rows[e.RowIndex].Cells[0].Value = FavStar;
            }

            //Add Song Path to Favourites Variable
            string favourite = path[FavGrid1.SelectedRows[0].Index];

            //Add Song to Favourites DataViewGrid
            if (FavGrid1.Rows[e.RowIndex].Cells[0].Value == FavStarFilled)
            {
                var file = TagLib.File.Create(favourite);
                string title = file.Tag.Title;
                string artist = file.Tag.FirstPerformer;
                string genre = file.Tag.FirstGenre;
                double secs = file.Properties.Duration.TotalSeconds;
                TimeSpan conv = TimeSpan.FromSeconds(secs);
                string duration = string.Format("{0:D2}:{1:D2}", conv.Minutes, conv.Seconds);
                FavouritesGrid.Rows.Add(SongsGrid.Rows[e.RowIndex].Cells[0].Value, PlayIcon, title, artist, genre, duration);
                if ((Player.URL == path[(int)SongsGrid.Rows[e.RowIndex].Cells[0].Value] && Player.playState == WMPLib.WMPPlayState.wmppsPlaying))
                {
                    FavouritesGrid.Rows[FavouritesGrid.RowCount - 1].Cells[1].Value = PauseIcon;
                    FavouritesGrid.Rows[FavouritesGrid.RowCount - 1].Selected = true;
                }
                FavGrid2.Rows.Add(FavStarFilled);
            }
            else //Delete Song From Favourites DataViewGrid
            {
                for (int x = 0; x < FavouritesGrid.RowCount; x++)
                {
                    if (FavouritesGrid.Rows[x].Cells[0].Value == SongsGrid.Rows[e.RowIndex].Cells[0].Value)
                    {
                        FavouritesGrid.Rows.RemoveAt(x);
                        FavGrid2.Rows.RemoveAt(x);
                    }
                }
            }
            FavGrid1.ClearSelection();
        }

        //Songs DataGridView Row Hover Effect
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            style1.BackColor = Color.FromArgb(240, 84, 84);
            if (e.RowIndex > -1)
            {
                SongsGrid.Rows[e.RowIndex].DefaultCellStyle = style1;
            }
        }
        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            style2.BackColor = Color.Black;
            if (e.RowIndex > -1)
            {
                SongsGrid.Rows[e.RowIndex].DefaultCellStyle = style2;

            }
        }

        //FavGrid1 DataGridView Row Hover Effect
        private void FavAndDelButtons_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            style1.BackColor = Color.FromArgb(240, 84, 84);
            if (e.RowIndex > -1)
            {
                FavGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = style1;
            }
        }
        private void FavAndDelButtons_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            style2.BackColor = Color.Black;
            if (e.RowIndex > -1)
            {
                FavGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = style2;
            }
        }

        //Hover Effect on BottomPanel PlayButton
        private void PlayPic_MouseEnter(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                PlayPic.Image = Image.FromFile(WhitePauseHover);
            }
            else
            {
                PlayPic.Image = Image.FromFile(RedPlayHover);
            }
        }
        private void PlayPic_MouseLeave(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                PlayPic.Image = Image.FromFile(WhitePause);
            }
            else
            {
                PlayPic.Image = Image.FromFile(RedPlay);
            }
        }

        //Hover Effect on BottomPanel StopButton
        private void StopPic_MouseEnter(object sender, EventArgs e)
        {
            StopPic.Image = Image.FromFile(WhiteStopHover);
        }
        private void StopPic_MouseLeave(object sender, EventArgs e)
        {
            StopPic.Image = Image.FromFile(WhiteStop);
        }

        //Hover Effect on BottomPanel PrevButton
        private void PrevSongPic_MouseEnter(object sender, EventArgs e)
        {
            PrevSongPic.Image = Image.FromFile(PrevSongHover);
        }
        private void PrevSongPic_MouseLeave(object sender, EventArgs e)
        {
            PrevSongPic.Image = Image.FromFile(PrevSong);
        }

        //Hover Effect on BottomPanel NextButton
        private void NextSongPic_MouseEnter(object sender, EventArgs e)
        {
            NextSongPic.Image = Image.FromFile(NextSongHover);
        }
        private void NextSongPic_MouseLeave(object sender, EventArgs e)
        {
            NextSongPic.Image = Image.FromFile(NextSong);
        }

        //BottomPanel StopButton Functionality
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (SongsGrid.RowCount > 0)
            {
                Player.Ctlcontrols.stop();
                SongsGrid[1, SongsGrid.SelectedRows[0].Index].Value = PlayIcon;
                if (FavouritesGrid.RowCount > 0)
                {
                    FavouritesGrid[1, FavouritesGrid.SelectedRows[0].Index].Value = PlayIcon;
                }
                // Connect it with BottomPanel PlayButton
                if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    PlayPic.Image = Image.FromFile(WhitePause);
                }
                else
                {
                    PlayPic.Image = Image.FromFile(RedPlay);
                }
            }
        }

        //BottomPanel PlayButton Functionality
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (SongsGrid.RowCount > 0)
            {
                if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    Player.Ctlcontrols.pause();
                    SongsGrid[1, SongsGrid.SelectedRows[0].Index].Value = PlayIcon;
                    if (FavouritesGrid.RowCount > 0)
                    {
                        FavouritesGrid[1, FavouritesGrid.SelectedRows[0].Index].Value = PlayIcon;
                    }
                    PlayPic.Image = Image.FromFile(RedPlay);
                }
                else
                {
                    Player.Ctlcontrols.play();
                    SongsGrid[1, SongsGrid.SelectedRows[0].Index].Value = PauseIcon;
                    if (FavouritesGrid.RowCount > 0)
                    {
                        FavouritesGrid[1, FavouritesGrid.SelectedRows[0].Index].Value = PauseIcon;
                    }
                    PlayPic.Image = Image.FromFile(WhitePause);
                }
            }
        }

        //BottomPanel PrevButton Functionality
        private void PrevSongPic_Click(object sender, EventArgs e)
        {
            if (SongsGrid.RowCount > 0)
            {
                int x = 0;
                if (Title.Text == "Favourites" && FavouritesGrid.RowCount > 0)
                {
                    x = (int)FavouritesGrid.Rows[FavouritesGrid.SelectedRows[0].Index].Cells[0].Value;
                    SongsGrid.Rows[SongsGrid.SelectedRows[0].Index].Cells[1].Value = PlayIcon;
                    if (FavouritesGrid.SelectedRows[0].Index == 0)
                    {
                        Player.URL = path[x];
                        Player.Ctlcontrols.play();
                    }
                    else
                    {
                        FavouritesGrid[1, FavouritesGrid.SelectedRows[0].Index].Value = PlayIcon;
                        FavouritesGrid.Rows[FavouritesGrid.SelectedRows[0].Index - 1].Selected = true;
                        x = (int)FavouritesGrid.Rows[FavouritesGrid.SelectedRows[0].Index].Cells[0].Value;
                        FavouritesGrid[1, FavouritesGrid.SelectedRows[0].Index].Value = PauseIcon;
                        Player.URL = path[x];
                        Player.Ctlcontrols.play();
                    }
                    //Add Song and Artist to Bottom Panel
                    SongAndArtist(SongTitle2, Artist2, (int)FavouritesGrid.Rows[FavouritesGrid.SelectedRows[0].Index].Cells[0].Value);
                    // Add Song Cover to Bottom Panel
                    AddSongPic(BottomPanelPicBox, (int)FavouritesGrid.Rows[FavouritesGrid.SelectedRows[0].Index].Cells[0].Value);
                    // Add Song, Artist and Genre Names to Now Playing
                    SongArtistAndGenre(SongTitle1_2, Artist1_2, Genre1_2, (int)FavouritesGrid.Rows[FavouritesGrid.SelectedRows[0].Index].Cells[0].Value);
                    // Add Song Cover to Now Playing
                    AddSongPic(SongCoverPicBox, (int)FavouritesGrid.Rows[FavouritesGrid.SelectedRows[0].Index].Cells[0].Value);
                }
                else
                {
                    x = SongsGrid.SelectedRows[0].Index;
                    if (FavouritesGrid.RowCount > 0)
                    {
                        FavouritesGrid.Rows[FavouritesGrid.SelectedRows[0].Index].Cells[1].Value = PlayIcon;
                    }
                    if (x == 0)
                    {
                        Player.URL = path[x];
                        Player.Ctlcontrols.play();
                    }
                    else
                    {
                        SongsGrid[1, SongsGrid.SelectedRows[0].Index].Value = PlayIcon;
                        --x;
                        SongsGrid.Rows[x].Selected = true;
                        SongsGrid[1, SongsGrid.SelectedRows[0].Index].Value = PauseIcon;
                        Player.URL = path[x];
                        Player.Ctlcontrols.play();
                    }
                    //Add Song and Artist to Bottom Panel
                    SongAndArtist(SongTitle2, Artist2, SongsGrid.SelectedRows[0].Index);
                    // Add Song Cover to Bottom Panel
                    AddSongPic(BottomPanelPicBox, SongsGrid.SelectedRows[0].Index);
                    // Add Song, Artist and Genre Names to Now Playing
                    SongArtistAndGenre(SongTitle1_2, Artist1_2, Genre1_2, SongsGrid.SelectedRows[0].Index);
                    // Add Song Cover to Now Playing
                    AddSongPic(SongCoverPicBox, SongsGrid.SelectedRows[0].Index);
                }
                PlayPic.Image = Image.FromFile(WhitePause);
            }
        }

        //BottomPanel NextButton Functionality
        private void NextSongPic_Click(object sender, EventArgs e)
        {
            if (SongsGrid.RowCount > 0)
            {
                int x = 0;
                if (Title.Text == "Favourites" && FavouritesGrid.RowCount > 0)
                {
                    x = (int)FavouritesGrid.Rows[FavouritesGrid.SelectedRows[0].Index].Cells[0].Value;
                    SongsGrid.Rows[SongsGrid.SelectedRows[0].Index].Cells[1].Value = PlayIcon;
                    if (FavouritesGrid.SelectedRows[0].Index == FavouritesGrid.RowCount - 1)
                    {
                        Player.URL = path[x];
                        Player.Ctlcontrols.play();
                    }
                    else
                    {
                        FavouritesGrid[1, FavouritesGrid.SelectedRows[0].Index].Value = PlayIcon;
                        FavouritesGrid.Rows[FavouritesGrid.SelectedRows[0].Index + 1].Selected = true;
                        x = (int)FavouritesGrid.Rows[FavouritesGrid.SelectedRows[0].Index].Cells[0].Value;
                        FavouritesGrid[1, FavouritesGrid.SelectedRows[0].Index].Value = PauseIcon;
                        Player.URL = path[x];
                        Player.Ctlcontrols.play();
                    }
                    //Add Song and Artist to Bottom Panel
                    SongAndArtist(SongTitle2, Artist2, (int)FavouritesGrid.Rows[FavouritesGrid.SelectedRows[0].Index].Cells[0].Value);
                    // Add Song Cover to Bottom Panel
                    AddSongPic(BottomPanelPicBox, (int)FavouritesGrid.Rows[FavouritesGrid.SelectedRows[0].Index].Cells[0].Value);
                    // Add Song, Artist and Genre Names to Now Playing
                    SongArtistAndGenre(SongTitle1_2, Artist1_2, Genre1_2, (int)FavouritesGrid.Rows[FavouritesGrid.SelectedRows[0].Index].Cells[0].Value);
                    // Add Song Cover to Now Playing
                    AddSongPic(SongCoverPicBox, (int)FavouritesGrid.Rows[FavouritesGrid.SelectedRows[0].Index].Cells[0].Value);
                }
                else
                {
                    x = SongsGrid.SelectedRows[0].Index;
                    if (FavouritesGrid.RowCount > 0)
                    {
                        FavouritesGrid.Rows[FavouritesGrid.SelectedRows[0].Index].Cells[1].Value = PlayIcon;
                    }
                    if (x == SongsGrid.RowCount - 1)
                    {
                        Player.URL = path[x];
                        Player.Ctlcontrols.play();
                    }
                    else
                    {
                        SongsGrid[1, SongsGrid.SelectedRows[0].Index].Value = PlayIcon;
                        ++x;
                        SongsGrid.Rows[x].Selected = true;
                        SongsGrid[1, SongsGrid.SelectedRows[0].Index].Value = PauseIcon;
                        Player.URL = path[x];
                        Player.Ctlcontrols.play();
                    }
                    //Add Song and Artist to Bottom Panel
                    SongAndArtist(SongTitle2, Artist2, SongsGrid.SelectedRows[0].Index);
                    // Add Song Cover to Bottom Panel
                    AddSongPic(BottomPanelPicBox, SongsGrid.SelectedRows[0].Index);
                    // Add Song, Artist and Genre Names to Now Playing
                    SongArtistAndGenre(SongTitle1_2, Artist1_2, Genre1_2, SongsGrid.SelectedRows[0].Index);
                    // Add Song Cover to Now Playing
                    AddSongPic(SongCoverPicBox, SongsGrid.SelectedRows[0].Index);
                }
                PlayPic.Image = Image.FromFile(WhitePause);
            }
        }

        //BottomPanel Song Timer Label
        private void timer_Tick(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                SongSlider.Maximum = (int)Player.Ctlcontrols.currentItem.duration;
                SongSlider.Value = (int)Player.Ctlcontrols.currentPosition;
                SongTimer.Text = Player.Ctlcontrols.currentPositionString;
            }
        }

        // Bottom Panel Song Slider
        private void SongSlider_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            Player.Ctlcontrols.currentPosition = SongSlider.Value;
        }

        //Bottom Panel SoundBar Functionality
        private void SoundSlider_Scroll(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs e)
        {
            Player.settings.volume = SoundSlider.Value;
        }


        // <-------------------   Favourites Page   ------------------->


        // Favourites DataGridView Functionality
        private void FavouritesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int FavSongId = (int)FavouritesGrid.Rows[e.RowIndex].Cells[0].Value;
            SongsGrid.Rows[FavSongId].Selected = true;
            // One Click On Row Song Plays, Second Click Song Stops
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying && current2 == FavouritesGrid.SelectedRows[0].Index)
            {
                Player.Ctlcontrols.stop();
                FavouritesGrid[1, FavouritesGrid.SelectedRows[0].Index].Value = PlayIcon;
                SongsGrid[1, SongsGrid.SelectedRows[0].Index].Value = PlayIcon;
                PlayPic.Image = Image.FromFile(RedPlay);
            }
            else
            {
                Player.URL = path[(int)FavouritesGrid.Rows[e.RowIndex].Cells[0].Value];
                Player.Ctlcontrols.play();
                current1 = SongsGrid.SelectedRows[0].Index;
                current2 = FavouritesGrid.SelectedRows[0].Index;
                //Reset first column pictures to PlayIcon
                for (int x = 0; x < FavouritesGrid.RowCount; x++)
                {
                    FavouritesGrid[1, x].Value = PlayIcon;
                }
                for (int x = 0; x < SongsGrid.RowCount; x++)
                {
                    SongsGrid[1, x].Value = PlayIcon;
                }

                FavouritesGrid[1, current2].Value = PauseIcon;
                SongsGrid[1, current1].Value = PauseIcon;
                PlayPic.Image = Image.FromFile(WhitePause);
            }

            // Add Song and Artist to Bottom Panel
            SongAndArtist(SongTitle2, Artist2, (int)FavouritesGrid.Rows[e.RowIndex].Cells[0].Value);

            // Add Song Cover to Bottom Panel
            AddSongPic(BottomPanelPicBox, (int)FavouritesGrid.Rows[e.RowIndex].Cells[0].Value);

            // Add Song, Artist and Genre Names to Now Playing
            SongArtistAndGenre(SongTitle1_2, Artist1_2, Genre1_2, (int)FavouritesGrid.Rows[e.RowIndex].Cells[0].Value);

            // Add Song Cover to Now Playing
            AddSongPic(SongCoverPicBox, (int)FavouritesGrid.Rows[e.RowIndex].Cells[0].Value);
        }

        //Favourite Buttons Delete Function
        private void FavGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FavGrid1.Rows[(int)FavouritesGrid.Rows[e.RowIndex].Cells[0].Value].Cells[0].Value = FavStar;
            FavouritesGrid.Rows.RemoveAt(FavGrid2.SelectedRows[0].Index);
            FavGrid2.Rows.RemoveAt(FavGrid2.SelectedRows[0].Index);
            FavGrid2.ClearSelection();
            if (FavouritesGrid.RowCount == 0)
            {
                NoSongs2.Visible = true;
            }
        }

        // Favourites DataGridView Row Hover Effect
        private void FavouritesGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            style1.BackColor = Color.FromArgb(240, 84, 84);
            if (e.RowIndex > -1)
            {
                FavouritesGrid.Rows[e.RowIndex].DefaultCellStyle = style1;
            }
        }
        private void FavouritesGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            style2.BackColor = Color.Black;
            if (e.RowIndex > -1)
            {
                FavouritesGrid.Rows[e.RowIndex].DefaultCellStyle = style2;

            }
        }

        // FavGrid2 DataGridView Row Hover Effect
        private void FavGrid2_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            style1.BackColor = Color.FromArgb(240, 84, 84);
            if (e.RowIndex > -1)
            {
                FavGrid2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = style1;
            }
        }
        private void FavGrid2_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            style2.BackColor = Color.Black;
            if (e.RowIndex > -1)
            {
                FavGrid2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = style2;
            }
        }

        //Syncing Scroll Bar with Favourites DataViewGrid
        private void FavouritesGrid_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                ScrollBarFavourites.Value = e.NewValue;
            }
        }
        private void ScrollBarFavourites_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            if (e.Value < FavouritesGrid.RowCount)
            {
                FavouritesGrid.FirstDisplayedScrollingRowIndex = e.Value;
                FavGrid2.FirstDisplayedScrollingRowIndex = e.Value;
            }
        }

        // <-------------------   LeftPanel Page Navigation Buttons   ------------------->

        //Now Playing Button
        private void btn1_NowPlaying_Click(object sender, EventArgs e)
        {
            //Title
            if (Settings.isEnglish == true)
            {
                Title.Text = "Now Playing";
            }
            else
            {
                Title.Text = "Şimdi Oynuyor";
            }

            //Visibility Control
            NowPlayingPanel.Visible = true;
            SongListPanel.Visible = false;
        }

        // Songs Button
        private void btn2_Songs_Click(object sender, EventArgs e)
        {
            //Title
            if (Settings.isEnglish == true)
            {
                Title.Text = "Songs";
            }
            else
            {
                Title.Text = "Şarkılar";
            }

            //Visibiliy Control
            SongListPanel.Visible = true;
            ImportSongsButton.Visible = true;
            SongsGrid.Visible = true;
            FavGrid1.Visible = true;

            NowPlayingPanel.Visible = false;
            FavouritesGrid.Visible = false;
            FavGrid2.Visible = false;
            ScrollBarFavourites.Visible = false;

            //No Songs Label Visibilty
            if (SongsGrid.RowCount > 0 && SongsGrid.Visible == true)
            {
                NoSongs2.Visible = false;
            }
            else
            {
                NoSongs2.Visible = true;
            }

            //Scroll Bar Visibility
            if (SongsGrid.RowCount >= 9)
            {
                ScrollBarSongs.Visible = true;
            }
            else
            {
                ScrollBarSongs.Visible = false;
            }
        }

        // Favourites Button
        private void btn4_Favourites_Click(object sender, EventArgs e)
        {
            //Title
            if (Settings.isEnglish == true)
            {
                Title.Text = "Favourites";
            }
            else
            {
                Title.Text = "Favoriler";
            }

            //Visibility Control 
            FavouritesGrid.Visible = true;
            FavGrid2.Visible = true;
            SongListPanel.Visible = true;

            NowPlayingPanel.Visible = false;
            ImportSongsButton.Visible = false;
            SongsGrid.Visible = false;
            FavGrid1.Visible = false;
            ScrollBarSongs.Visible = false;

            //No Songs Label Visibility
            if (FavouritesGrid.RowCount > 0 && FavouritesGrid.Visible == true)
            {
                NoSongs2.Visible = false;
            }
            else
            {
                NoSongs2.Visible = true;
            }

            //Scroll Bar Visibility
            if (FavouritesGrid.RowCount >= 9)
            {
                ScrollBarFavourites.Visible = true;
            }
            else
            {
                ScrollBarFavourites.Visible = false;
            }

            //Link WindowMediaPlayer To first song In Favourites
            if (FavouritesGrid.RowCount > 0 && Player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                Player.URL = path[(int)FavouritesGrid.Rows[FavouritesGrid.SelectedRows[0].Index].Cells[0].Value];
                Player.Ctlcontrols.stop();
            }

            //Clear Selection on FavGrid2 Grid
            FavGrid2.ClearSelection();

            //Scroll Bar Settings
            if (FavouritesGrid.RowCount > 0)
            {
                ScrollBarFavourites.Maximum = FavouritesGrid.RowCount;
                ScrollBarFavourites.LargeChange = FavouritesGrid.DisplayedRowCount(true);
                ScrollBarFavourites.SmallChange = 1;
            }
        }

        // Settings and About Buttons
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            btn1_NowPlaying.PerformClick();
            btn1_NowPlaying.Focus();
            Program.settings.ShowDialog();
        }
        public void bunifuButton2_Click(object sender, EventArgs e)
        {
            btn1_NowPlaying.PerformClick();
            btn1_NowPlaying.Focus();
            Program.about.ShowDialog();
        }
    }
}