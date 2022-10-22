﻿using System;
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
        readonly PrivateFontCollection BadSignal = new PrivateFontCollection();
        public MainForm()
        {
            InitializeComponent();
  
            //Import Custom Font
            BadSignal.AddFontFile(@"..\..\Fonts\BadSignal.otf");
            foreach (Control A in this.Controls)
            {
                title1_TheMethod.Font = new Font(BadSignal.Families[0], 48, FontStyle.Regular);
            }

            //Import Only .mp3 and Allow Multiple Select
            openFileDialog.DefaultExt = "mp3";
            openFileDialog.Filter = "MP3 Files (*.mp3)|*.mp3";
            openFileDialog.Multiselect = true;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        // Add Song Picture Function
        public void AddSongPic(PictureBox x, int y)
        {
            var file = TagLib.File.Create(files[y]);
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
                x.Image = Image.FromFile(@"..\..\Resources\Default.png");
            }
        }

        // Add Song and Artist Names Function
        public void SongAndArtist(Label SongTitle, Label Artist, int x)
        {
            var file = TagLib.File.Create(files[x]);
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
            var file = TagLib.File.Create(files[x]);
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

        //Clicking Settings and About Returns to Now Playing Page
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

        

        // <-------------------   Songs Page   ------------------->

        // Arrays to import songs
        string[] path, files;

        // Resources
        Icon PlayIcon = new Icon(@"..\..\Resources\Playbutton_White.ico");
        Icon PauseIcon = new Icon(@"..\..\Resources\Pausebutton_WhiteBlack1.ico");
        Icon FavStar = new Icon(@"..\..\Resources\FavStar1.ico");
        Icon FavStarFilled = new Icon(@"..\..\Resources\FavStarFilled1.ico");
        Icon TrashCan = new Icon(@"..\..\Resources\Del1.ico");

        //Import Songs Button
        private void ImportSongsButton_Click(object sender, EventArgs e)
        {
            //Import Songs
            if (openFileDialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                NoSongs2.Visible = false;
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
                    SongsGrid.Rows.Add(x, PlayIcon, title, artist, genre, duration);
                    FavGrid1.Rows.Add(FavStar);
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
                SongAndArtist(SongTitle2, Artist2 ,SongsGrid.SelectedRows[0].Index);

                //Add Song Cover to Bottom Panel
                AddSongPic(BottomPanelPicBox ,SongsGrid.SelectedRows[0].Index);

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
                PlayPic.Image = Image.FromFile(@"..\..\Resources\Playbutton_RedWhite1.png"); // Turn BottomPanel PlayButton To Red Play
            }
            else
            {
                Player.URL = path[SongsGrid.SelectedRows[0].Index];
                Player.Ctlcontrols.play();
                current1 = SongsGrid.SelectedRows[0].Index;
                for (int x = 0; x < files.Length; x++) //Reset icons on the left of the songs to PlayIcon
                {
                    SongsGrid[1, x].Value = PlayIcon;
                }
                SongsGrid[1, e.RowIndex].Value = PauseIcon;
                for (int x = 0; x < FavouritesGrid.RowCount; x++)
                {
                    if (FavouritesGrid.Rows[x].Cells[0].Value == SongsGrid.Rows[e.RowIndex].Cells[0].Value)
                    {
                        for(int y=0; y < FavouritesGrid.RowCount; y++)
                        {
                            FavouritesGrid[1, y].Value =PlayIcon; // Reset All to PlayIcon
                        }
                        FavouritesGrid[1, x].Value = PauseIcon;
                        FavouritesGrid[1, x].Selected = true;
                    }
                    else
                    {
                        FavouritesGrid[1, x].Value = PlayIcon;
                    }
                }
                PlayPic.Image = Image.FromFile(@"..\..\Resources\Pausebutton_WhiteBlack1.png"); // Turn BottomPanel PlayButton To Pause White
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

        //Hover Effect on BottomPanel StopButton
        private void StopPic_MouseEnter(object sender, EventArgs e)
        {
            StopPic.Image = Image.FromFile(@"..\..\Resources\Stopbutton_WhiteBlackHover.png"); 
        }
        private void StopPic_MouseLeave(object sender, EventArgs e)
        {
            StopPic.Image = Image.FromFile(@"..\..\Resources\Stopbutton_WhiteBlack1.png");
        }

        //Hover Effect on BottomPanel PrevButton
        private void PrevSongPic_MouseEnter(object sender, EventArgs e)
        {
            PrevSongPic.Image = Image.FromFile(@"..\..\Resources\previous-song-hover.png");
        }
        private void PrevSongPic_MouseLeave(object sender, EventArgs e)
        {
            PrevSongPic.Image = Image.FromFile(@"..\..\Resources\previous-song.png");
        }

        //Hover Effect on BottomPanel NextButton
        private void NextSongPic_MouseEnter(object sender, EventArgs e)
        {
            NextSongPic.Image = Image.FromFile(@"..\..\Resources\next-song-hover.png");
        }
        private void NextSongPic_MouseLeave(object sender, EventArgs e)
        {
            NextSongPic.Image = Image.FromFile(@"..\..\Resources\next-song.png");
        }

        //BottomPanel StopButton Functionality
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
            SongsGrid[1, SongsGrid.SelectedRows[0].Index].Value = PlayIcon;
            if(FavouritesGrid.RowCount > 0)
            {
                FavouritesGrid[1, FavouritesGrid.SelectedRows[0].Index].Value = PlayIcon;
            }
            // Connect it with BottomPanel PlayButton
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                PlayPic.Image = Image.FromFile(@"..\..\Resources\Pausebutton_WhiteBlack1.png");
            }
            else
            {
                PlayPic.Image = Image.FromFile(@"..\..\Resources\Playbutton_RedWhite1.png");
            }
        }

        //BottomPanel PlayButton Functionality
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Player.Ctlcontrols.pause();
                SongsGrid[1, SongsGrid.SelectedRows[0].Index].Value = PlayIcon;
                if (FavouritesGrid.RowCount > 0)
                {
                    FavouritesGrid[1, FavouritesGrid.SelectedRows[0].Index].Value = PlayIcon;
                }
                PlayPic.Image = Image.FromFile(@"..\..\Resources\Playbutton_RedWhite1.png");
            }
            else
            {
                Player.Ctlcontrols.play();
                SongsGrid[1, SongsGrid.SelectedRows[0].Index].Value = PauseIcon;
                if (FavouritesGrid.RowCount > 0)
                {
                    FavouritesGrid[1, FavouritesGrid.SelectedRows[0].Index].Value = PauseIcon;
                }
                PlayPic.Image = Image.FromFile(@"..\..\Resources\Pausebutton_WhiteBlack1.png");
            }
        }

        //BottomPanel PrevButton Functionality
        private void PrevSongPic_Click(object sender, EventArgs e)
        {
            int x = SongsGrid.SelectedRows[0].Index;
            if (x==0)
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
            PlayPic.Image = Image.FromFile(@"..\..\Resources\Pausebutton_WhiteBlack1.png");

            //Add Song and Artist to Bottom Panel
            SongAndArtist(SongTitle2, Artist2, SongsGrid.SelectedRows[0].Index);

            // Add Song Cover to Bottom Panel
            AddSongPic(BottomPanelPicBox, SongsGrid.SelectedRows[0].Index);

            // Add Song, Artist and Genre Names to Now Playing
            SongArtistAndGenre(SongTitle1_2, Artist1_2, Genre1_2, SongsGrid.SelectedRows[0].Index);

            // Add Song Cover to Now Playing
            AddSongPic(SongCoverPicBox, SongsGrid.SelectedRows[0].Index);
        }

        //BottomPanel NextButton Functionality
        private void NextSongPic_Click(object sender, EventArgs e)
        {
            string [] FileNum = openFileDialog.FileNames;
            int x = SongsGrid.SelectedRows[0].Index;
            if (x == FileNum.Length-1)
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

            PlayPic.Image = Image.FromFile(@"..\..\Resources\Pausebutton_WhiteBlack1.png");

            // Add Song and Artist to Bottom Panel
            SongAndArtist(SongTitle2, Artist2, SongsGrid.SelectedRows[0].Index);

            // Add Song Cover to Bottom Panel
            AddSongPic(BottomPanelPicBox, SongsGrid.SelectedRows[0].Index);

            // Add Song, Artist and Genre Names to Now Playing
            SongArtistAndGenre(SongTitle1_2, Artist1_2, Genre1_2, SongsGrid.SelectedRows[0].Index);
             
            // Add Song Cover to Now Playing
            AddSongPic(SongCoverPicBox, SongsGrid.SelectedRows[0].Index);
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
                PlayPic.Image = Image.FromFile(@"..\..\Resources\Playbutton_RedWhite1.png");
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
                PlayPic.Image = Image.FromFile(@"..\..\Resources\Pausebutton_WhiteBlack1.png");
            }

            // Add Song and Artist to Bottom Panel
            SongAndArtist(SongTitle2, Artist2, (int)FavouritesGrid.Rows[e.RowIndex].Cells[0].Value);

            // Add Song Cover to Bottom Panel
            AddSongPic(BottomPanelPicBox, (int)FavouritesGrid.Rows[e.RowIndex].Cells[0].Value);

            // Add Song, Artist and Genre Names to Now Playing
            SongArtistAndGenre(SongTitle1_2, Artist1_2, Genre1_2, SongsGrid.SelectedRows[0].Index);

            // Add Song Cover to Now Playing
            AddSongPic(SongCoverPicBox, SongsGrid.SelectedRows[0].Index);
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
            Title.Text = "Now Playing";

            //Visibility Control
            NowPlayingPanel.Visible = true;
            SongListPanel.Visible = false;
        }

        // Songs Button
        private void btn2_Songs_Click(object sender, EventArgs e)
        {
            //Title
            Title.Text = "Songs";

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
            Title.Text = "Favourites";

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
            if (FavouritesGrid.RowCount>0 && Player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                Player.URL = path[(int)FavouritesGrid.Rows[FavouritesGrid.SelectedRows[0].Index].Cells[0].Value];
                Player.Ctlcontrols.stop();
            }

            //Clear Selection on FavGrid2 Grid
            FavGrid2.ClearSelection();

            //Scroll Bar Settings
            if(FavouritesGrid.RowCount > 0)
            {
                ScrollBarFavourites.Maximum = FavouritesGrid.RowCount;
                ScrollBarFavourites.LargeChange = FavouritesGrid.DisplayedRowCount(true);
                ScrollBarFavourites.SmallChange = 1;
            }
        }
    }
}


