using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Settings : Form
    {
        private readonly MainForm mainform;
        public static bool isEnglish = true;
        public Settings(MainForm form1)
        {
            mainform = form1;
            InitializeComponent();
        }

        private void ExitPicture_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // English Button
        private void btn_English_Click(object sender, EventArgs e)
        {
            isEnglish = true;

            // <----- Edit Labels ----->

            // Settings Popup
            Title.Text = "Settings";
            lbl_Language.Text = "Language";
            lbl_Theme.Text = "Theme";

            // Left Panel
            mainform.title2_MusicPlayer.Text = "Music Player";
            mainform.title3_Library.Text = "Library";
            mainform.btn1_NowPlaying.Text = "  Now Playing";
            mainform.btn2_Songs.Text = "  Songs";
            mainform.btn3_Favourites.Text = "  Favourites";
            mainform.btn1_Settings.Text = "Settings";
            mainform.btn2_About.Text = "About";

            // Bottom Panel
            mainform.SongTitle2.Text = "Song Title";
            mainform.Artist2.Text = "Artist";

            // Now Playing Page
            mainform.Title.Text = "Now Playing";
            mainform.NoSongs1_1.Text = "No songs added!";
            mainform.SongTitle1_1.Text = "Song Title";
            mainform.Artist1_1.Text = "Artist";
            mainform.Genre1_1.Text = "Genre";

            // Now Playing Page Grey Labels
            if (mainform.SongsGrid == null || mainform.SongsGrid.Rows.Count == 0)
            {
                mainform.SongTitle1_2.Text = "Song Name";
                mainform.Artist1_2.Text = "Artist";
                mainform.Genre1_2.Text = "Genre";
            }

            // Songs Page
            mainform.ImportSongsButton.Text = "Import Songs";

            mainform.NoSongs2.Text = "No songs added"; // One Time

            mainform.SongsGrid.Columns[2].HeaderText = "Song";
            mainform.SongsGrid.Columns[3].HeaderText = "Artist";
            mainform.SongsGrid.Columns[4].HeaderText = "Genre";
            mainform.SongsGrid.Columns[5].HeaderText = "Duration";

            // Favourites Songs
            mainform.FavouritesGrid.Columns[2].HeaderText = "Song";
            mainform.FavouritesGrid.Columns[3].HeaderText = "Artist";
            mainform.FavouritesGrid.Columns[4].HeaderText = "Genre";
            mainform.FavouritesGrid.Columns[5].HeaderText = "Duration";
        }

        // Turkish Button
        private void btn_Turkish_Click(object sender, EventArgs e)
        {
            isEnglish = false;

            // <----- Edit Labels ----->

            // Settings Popup
            Title.Text = "Ayarlar";
            lbl_Language.Text = "Dil";
            lbl_Theme.Text = "Tema";

            // Left Panel
            mainform.title2_MusicPlayer.Text = "Müzik Çalar";
            mainform.title3_Library.Text = "Kütüphane";
            mainform.btn1_NowPlaying.Text = "  Şimdi Oynuyor";
            mainform.btn2_Songs.Text = "  Şarkılar";
            mainform.btn3_Favourites.Text = "  Favoriler";
            mainform.btn1_Settings.Text = "Ayarlar";
            mainform.btn2_About.Text = "Hakkında";

            // Bottom Panel
            mainform.SongTitle2.Text = "Şarkı Adı";
            mainform.Artist2.Text = "Sanatçı";

            // Now Playing Page
            mainform.Title.Text = "Şimdi Oynuyor";
            mainform.NoSongs1_1.Text = "Eklenen şarkı yok!";
            mainform.SongTitle1_1.Text = "Şarkı Adı";
            mainform.Artist1_1.Text = "Sanatçı";
            mainform.Genre1_1.Text = "Tür";

            // Now Playing Page Grey Labels
            if (mainform.SongsGrid == null || mainform.SongsGrid.Rows.Count == 0)
            {
                mainform.SongTitle1_2.Text = "Şarkı Adı";
                mainform.Artist1_2.Text = "Sanatçı";
                mainform.Genre1_2.Text = "Tür";
            }

            // Songs Page
            mainform.ImportSongsButton.Text = "Şarkı Ekle";

            mainform.NoSongs2.Text = "Eklenen şarkı yok"; // One Time

            mainform.SongsGrid.Columns[2].HeaderText = "Şarkı";
            mainform.SongsGrid.Columns[3].HeaderText = "Sanatçı";
            mainform.SongsGrid.Columns[4].HeaderText = "Tür";
            mainform.SongsGrid.Columns[5].HeaderText = "Süre";

            // Favourites Songs
            mainform.FavouritesGrid.Columns[2].HeaderText = "Şarkı";
            mainform.FavouritesGrid.Columns[3].HeaderText = "Sanatçı";
            mainform.FavouritesGrid.Columns[4].HeaderText = "Tür";
            mainform.FavouritesGrid.Columns[5].HeaderText = "Süre";
        }
    }
}
