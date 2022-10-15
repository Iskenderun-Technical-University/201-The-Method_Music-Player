namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControl_LeftPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LeftPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn4_Favourites = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn3_Playlists = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn2_Songs = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BottomLeftPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn1_Settings = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn2_About = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn1_NowPlaying = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.title3_Library = new System.Windows.Forms.Label();
            this.title2_MusicPlayer = new System.Windows.Forms.Label();
            this.title1_TheMethod = new System.Windows.Forms.Label();
            this.DragControl_TheMethod = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControl_MusicPlayer = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControl_Library = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BottomRightPanel = new System.Windows.Forms.Panel();
            this.BottomShadowPanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.SoundSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.SongTimer = new System.Windows.Forms.Label();
            this.SpeakerPic = new System.Windows.Forms.PictureBox();
            this.SongSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.ForwardPic = new System.Windows.Forms.PictureBox();
            this.StopPic = new System.Windows.Forms.PictureBox();
            this.PlayPic = new System.Windows.Forms.PictureBox();
            this.BackwardPic = new System.Windows.Forms.PictureBox();
            this.ArtistName = new System.Windows.Forms.Label();
            this.SongName = new System.Windows.Forms.Label();
            this.ExitPicture = new System.Windows.Forms.PictureBox();
            this.LeftPanel.SuspendLayout();
            this.BottomLeftPanel.SuspendLayout();
            this.BottomRightPanel.SuspendLayout();
            this.BottomShadowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeakerPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackwardPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // DragControl_LeftPanel
            // 
            this.DragControl_LeftPanel.Fixed = true;
            this.DragControl_LeftPanel.Horizontal = true;
            this.DragControl_LeftPanel.TargetControl = this.LeftPanel;
            this.DragControl_LeftPanel.Vertical = true;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.LeftPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftPanel.BackgroundImage")));
            this.LeftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftPanel.BorderColor = System.Drawing.Color.Transparent;
            this.LeftPanel.BorderRadius = 3;
            this.LeftPanel.BorderThickness = 1;
            this.LeftPanel.Controls.Add(this.btn4_Favourites);
            this.LeftPanel.Controls.Add(this.btn3_Playlists);
            this.LeftPanel.Controls.Add(this.btn2_Songs);
            this.LeftPanel.Controls.Add(this.BottomLeftPanel);
            this.LeftPanel.Controls.Add(this.btn1_NowPlaying);
            this.LeftPanel.Controls.Add(this.title3_Library);
            this.LeftPanel.Controls.Add(this.title2_MusicPlayer);
            this.LeftPanel.Controls.Add(this.title1_TheMethod);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.ShowBorders = true;
            this.LeftPanel.Size = new System.Drawing.Size(464, 800);
            this.LeftPanel.TabIndex = 1;
            // 
            // btn4_Favourites
            // 
            this.btn4_Favourites.AllowAnimations = true;
            this.btn4_Favourites.AllowMouseEffects = true;
            this.btn4_Favourites.AllowToggling = true;
            this.btn4_Favourites.AnimationSpeed = 200;
            this.btn4_Favourites.AutoGenerateColors = false;
            this.btn4_Favourites.AutoRoundBorders = true;
            this.btn4_Favourites.AutoSizeLeftIcon = true;
            this.btn4_Favourites.AutoSizeRightIcon = true;
            this.btn4_Favourites.BackColor = System.Drawing.Color.Transparent;
            this.btn4_Favourites.BackColor1 = System.Drawing.Color.White;
            this.btn4_Favourites.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn4_Favourites.BackgroundImage")));
            this.btn4_Favourites.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn4_Favourites.ButtonText = "  Favourites";
            this.btn4_Favourites.ButtonTextMarginLeft = 0;
            this.btn4_Favourites.ColorContrastOnClick = 45;
            this.btn4_Favourites.ColorContrastOnHover = 45;
            this.btn4_Favourites.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btn4_Favourites.CustomizableEdges = borderEdges7;
            this.btn4_Favourites.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn4_Favourites.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn4_Favourites.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn4_Favourites.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn4_Favourites.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn4_Favourites.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4_Favourites.ForeColor = System.Drawing.Color.Black;
            this.btn4_Favourites.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4_Favourites.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn4_Favourites.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn4_Favourites.IconMarginLeft = 11;
            this.btn4_Favourites.IconPadding = 10;
            this.btn4_Favourites.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn4_Favourites.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn4_Favourites.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn4_Favourites.IconSize = 25;
            this.btn4_Favourites.IdleBorderColor = System.Drawing.Color.White;
            this.btn4_Favourites.IdleBorderRadius = 55;
            this.btn4_Favourites.IdleBorderThickness = 1;
            this.btn4_Favourites.IdleFillColor = System.Drawing.Color.White;
            this.btn4_Favourites.IdleIconLeftImage = null;
            this.btn4_Favourites.IdleIconRightImage = global::WindowsFormsApp1.Properties.Resources.arrow_right_navigation;
            this.btn4_Favourites.IndicateFocus = true;
            this.btn4_Favourites.Location = new System.Drawing.Point(32, 479);
            this.btn4_Favourites.Name = "btn4_Favourites";
            this.btn4_Favourites.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn4_Favourites.OnDisabledState.BorderRadius = 1;
            this.btn4_Favourites.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn4_Favourites.OnDisabledState.BorderThickness = 1;
            this.btn4_Favourites.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn4_Favourites.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn4_Favourites.OnDisabledState.IconLeftImage = null;
            this.btn4_Favourites.OnDisabledState.IconRightImage = null;
            this.btn4_Favourites.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn4_Favourites.onHoverState.BorderRadius = 1;
            this.btn4_Favourites.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn4_Favourites.onHoverState.BorderThickness = 1;
            this.btn4_Favourites.onHoverState.FillColor = System.Drawing.Color.White;
            this.btn4_Favourites.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btn4_Favourites.onHoverState.IconLeftImage = null;
            this.btn4_Favourites.onHoverState.IconRightImage = global::WindowsFormsApp1.Properties.Resources.arrow_right_navigation_red1;
            this.btn4_Favourites.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn4_Favourites.OnIdleState.BorderRadius = 1;
            this.btn4_Favourites.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn4_Favourites.OnIdleState.BorderThickness = 1;
            this.btn4_Favourites.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btn4_Favourites.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn4_Favourites.OnIdleState.IconLeftImage = null;
            this.btn4_Favourites.OnIdleState.IconRightImage = global::WindowsFormsApp1.Properties.Resources.arrow_right_navigation;
            this.btn4_Favourites.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btn4_Favourites.OnPressedState.BorderRadius = 1;
            this.btn4_Favourites.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn4_Favourites.OnPressedState.BorderThickness = 1;
            this.btn4_Favourites.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btn4_Favourites.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn4_Favourites.OnPressedState.IconLeftImage = null;
            this.btn4_Favourites.OnPressedState.IconRightImage = global::WindowsFormsApp1.Properties.Resources.arrow_right_navigation;
            this.btn4_Favourites.Size = new System.Drawing.Size(284, 57);
            this.btn4_Favourites.TabIndex = 7;
            this.btn4_Favourites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4_Favourites.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn4_Favourites.TextMarginLeft = 0;
            this.btn4_Favourites.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn4_Favourites.UseDefaultRadiusAndThickness = true;
            this.btn4_Favourites.Click += new System.EventHandler(this.btn4_Favourites_Click);
            // 
            // btn3_Playlists
            // 
            this.btn3_Playlists.AllowAnimations = true;
            this.btn3_Playlists.AllowMouseEffects = true;
            this.btn3_Playlists.AllowToggling = true;
            this.btn3_Playlists.AnimationSpeed = 200;
            this.btn3_Playlists.AutoGenerateColors = false;
            this.btn3_Playlists.AutoRoundBorders = true;
            this.btn3_Playlists.AutoSizeLeftIcon = true;
            this.btn3_Playlists.AutoSizeRightIcon = true;
            this.btn3_Playlists.BackColor = System.Drawing.Color.Transparent;
            this.btn3_Playlists.BackColor1 = System.Drawing.Color.White;
            this.btn3_Playlists.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn3_Playlists.BackgroundImage")));
            this.btn3_Playlists.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn3_Playlists.ButtonText = "  Playlists";
            this.btn3_Playlists.ButtonTextMarginLeft = 0;
            this.btn3_Playlists.ColorContrastOnClick = 45;
            this.btn3_Playlists.ColorContrastOnHover = 45;
            this.btn3_Playlists.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btn3_Playlists.CustomizableEdges = borderEdges8;
            this.btn3_Playlists.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn3_Playlists.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn3_Playlists.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn3_Playlists.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn3_Playlists.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn3_Playlists.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3_Playlists.ForeColor = System.Drawing.Color.Black;
            this.btn3_Playlists.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3_Playlists.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn3_Playlists.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn3_Playlists.IconMarginLeft = 11;
            this.btn3_Playlists.IconPadding = 10;
            this.btn3_Playlists.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn3_Playlists.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn3_Playlists.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn3_Playlists.IconSize = 25;
            this.btn3_Playlists.IdleBorderColor = System.Drawing.Color.White;
            this.btn3_Playlists.IdleBorderRadius = 55;
            this.btn3_Playlists.IdleBorderThickness = 1;
            this.btn3_Playlists.IdleFillColor = System.Drawing.Color.White;
            this.btn3_Playlists.IdleIconLeftImage = null;
            this.btn3_Playlists.IdleIconRightImage = global::WindowsFormsApp1.Properties.Resources.arrow_right_navigation;
            this.btn3_Playlists.IndicateFocus = true;
            this.btn3_Playlists.Location = new System.Drawing.Point(32, 416);
            this.btn3_Playlists.Name = "btn3_Playlists";
            this.btn3_Playlists.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn3_Playlists.OnDisabledState.BorderRadius = 1;
            this.btn3_Playlists.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn3_Playlists.OnDisabledState.BorderThickness = 1;
            this.btn3_Playlists.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn3_Playlists.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn3_Playlists.OnDisabledState.IconLeftImage = null;
            this.btn3_Playlists.OnDisabledState.IconRightImage = null;
            this.btn3_Playlists.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn3_Playlists.onHoverState.BorderRadius = 1;
            this.btn3_Playlists.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn3_Playlists.onHoverState.BorderThickness = 1;
            this.btn3_Playlists.onHoverState.FillColor = System.Drawing.Color.White;
            this.btn3_Playlists.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btn3_Playlists.onHoverState.IconLeftImage = null;
            this.btn3_Playlists.onHoverState.IconRightImage = global::WindowsFormsApp1.Properties.Resources.arrow_right_navigation_red1;
            this.btn3_Playlists.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn3_Playlists.OnIdleState.BorderRadius = 1;
            this.btn3_Playlists.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn3_Playlists.OnIdleState.BorderThickness = 1;
            this.btn3_Playlists.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btn3_Playlists.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn3_Playlists.OnIdleState.IconLeftImage = null;
            this.btn3_Playlists.OnIdleState.IconRightImage = global::WindowsFormsApp1.Properties.Resources.arrow_right_navigation;
            this.btn3_Playlists.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btn3_Playlists.OnPressedState.BorderRadius = 1;
            this.btn3_Playlists.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn3_Playlists.OnPressedState.BorderThickness = 1;
            this.btn3_Playlists.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btn3_Playlists.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn3_Playlists.OnPressedState.IconLeftImage = null;
            this.btn3_Playlists.OnPressedState.IconRightImage = global::WindowsFormsApp1.Properties.Resources.arrow_right_navigation;
            this.btn3_Playlists.Size = new System.Drawing.Size(284, 57);
            this.btn3_Playlists.TabIndex = 6;
            this.btn3_Playlists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3_Playlists.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn3_Playlists.TextMarginLeft = 0;
            this.btn3_Playlists.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn3_Playlists.UseDefaultRadiusAndThickness = true;
            this.btn3_Playlists.Click += new System.EventHandler(this.btn3_Playlists_Click);
            // 
            // btn2_Songs
            // 
            this.btn2_Songs.AllowAnimations = true;
            this.btn2_Songs.AllowMouseEffects = true;
            this.btn2_Songs.AllowToggling = true;
            this.btn2_Songs.AnimationSpeed = 200;
            this.btn2_Songs.AutoGenerateColors = false;
            this.btn2_Songs.AutoRoundBorders = true;
            this.btn2_Songs.AutoSizeLeftIcon = true;
            this.btn2_Songs.AutoSizeRightIcon = true;
            this.btn2_Songs.BackColor = System.Drawing.Color.Transparent;
            this.btn2_Songs.BackColor1 = System.Drawing.Color.White;
            this.btn2_Songs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2_Songs.BackgroundImage")));
            this.btn2_Songs.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn2_Songs.ButtonText = "  Songs";
            this.btn2_Songs.ButtonTextMarginLeft = 0;
            this.btn2_Songs.ColorContrastOnClick = 45;
            this.btn2_Songs.ColorContrastOnHover = 45;
            this.btn2_Songs.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.btn2_Songs.CustomizableEdges = borderEdges9;
            this.btn2_Songs.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn2_Songs.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn2_Songs.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn2_Songs.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn2_Songs.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn2_Songs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2_Songs.ForeColor = System.Drawing.Color.Black;
            this.btn2_Songs.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2_Songs.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn2_Songs.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn2_Songs.IconMarginLeft = 11;
            this.btn2_Songs.IconPadding = 10;
            this.btn2_Songs.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn2_Songs.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn2_Songs.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn2_Songs.IconSize = 25;
            this.btn2_Songs.IdleBorderColor = System.Drawing.Color.White;
            this.btn2_Songs.IdleBorderRadius = 55;
            this.btn2_Songs.IdleBorderThickness = 1;
            this.btn2_Songs.IdleFillColor = System.Drawing.Color.White;
            this.btn2_Songs.IdleIconLeftImage = null;
            this.btn2_Songs.IdleIconRightImage = global::WindowsFormsApp1.Properties.Resources.arrow_right_navigation;
            this.btn2_Songs.IndicateFocus = true;
            this.btn2_Songs.Location = new System.Drawing.Point(32, 353);
            this.btn2_Songs.Name = "btn2_Songs";
            this.btn2_Songs.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn2_Songs.OnDisabledState.BorderRadius = 1;
            this.btn2_Songs.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn2_Songs.OnDisabledState.BorderThickness = 1;
            this.btn2_Songs.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn2_Songs.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn2_Songs.OnDisabledState.IconLeftImage = null;
            this.btn2_Songs.OnDisabledState.IconRightImage = null;
            this.btn2_Songs.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn2_Songs.onHoverState.BorderRadius = 1;
            this.btn2_Songs.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn2_Songs.onHoverState.BorderThickness = 1;
            this.btn2_Songs.onHoverState.FillColor = System.Drawing.Color.White;
            this.btn2_Songs.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btn2_Songs.onHoverState.IconLeftImage = null;
            this.btn2_Songs.onHoverState.IconRightImage = global::WindowsFormsApp1.Properties.Resources.arrow_right_navigation_red1;
            this.btn2_Songs.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn2_Songs.OnIdleState.BorderRadius = 1;
            this.btn2_Songs.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn2_Songs.OnIdleState.BorderThickness = 1;
            this.btn2_Songs.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btn2_Songs.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn2_Songs.OnIdleState.IconLeftImage = null;
            this.btn2_Songs.OnIdleState.IconRightImage = global::WindowsFormsApp1.Properties.Resources.arrow_right_navigation;
            this.btn2_Songs.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btn2_Songs.OnPressedState.BorderRadius = 1;
            this.btn2_Songs.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn2_Songs.OnPressedState.BorderThickness = 1;
            this.btn2_Songs.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btn2_Songs.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn2_Songs.OnPressedState.IconLeftImage = null;
            this.btn2_Songs.OnPressedState.IconRightImage = global::WindowsFormsApp1.Properties.Resources.arrow_right_navigation;
            this.btn2_Songs.Size = new System.Drawing.Size(284, 57);
            this.btn2_Songs.TabIndex = 5;
            this.btn2_Songs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2_Songs.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn2_Songs.TextMarginLeft = 0;
            this.btn2_Songs.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn2_Songs.UseDefaultRadiusAndThickness = true;
            this.btn2_Songs.Click += new System.EventHandler(this.btn2_Songs_Click);
            // 
            // BottomLeftPanel
            // 
            this.BottomLeftPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.BottomLeftPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BottomLeftPanel.BackgroundImage")));
            this.BottomLeftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BottomLeftPanel.BorderColor = System.Drawing.Color.Transparent;
            this.BottomLeftPanel.BorderRadius = 3;
            this.BottomLeftPanel.BorderThickness = 1;
            this.BottomLeftPanel.Controls.Add(this.btn1_Settings);
            this.BottomLeftPanel.Controls.Add(this.btn2_About);
            this.BottomLeftPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomLeftPanel.Location = new System.Drawing.Point(0, 618);
            this.BottomLeftPanel.Name = "BottomLeftPanel";
            this.BottomLeftPanel.ShowBorders = true;
            this.BottomLeftPanel.Size = new System.Drawing.Size(464, 182);
            this.BottomLeftPanel.TabIndex = 4;
            // 
            // btn1_Settings
            // 
            this.btn1_Settings.AllowAnimations = true;
            this.btn1_Settings.AllowMouseEffects = true;
            this.btn1_Settings.AllowToggling = false;
            this.btn1_Settings.AnimationSpeed = 200;
            this.btn1_Settings.AutoGenerateColors = false;
            this.btn1_Settings.AutoRoundBorders = true;
            this.btn1_Settings.AutoSizeLeftIcon = true;
            this.btn1_Settings.AutoSizeRightIcon = true;
            this.btn1_Settings.BackColor = System.Drawing.Color.Transparent;
            this.btn1_Settings.BackColor1 = System.Drawing.Color.White;
            this.btn1_Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1_Settings.BackgroundImage")));
            this.btn1_Settings.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn1_Settings.ButtonText = "Settings";
            this.btn1_Settings.ButtonTextMarginLeft = 0;
            this.btn1_Settings.ColorContrastOnClick = 45;
            this.btn1_Settings.ColorContrastOnHover = 45;
            this.btn1_Settings.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges11.BottomLeft = true;
            borderEdges11.BottomRight = true;
            borderEdges11.TopLeft = true;
            borderEdges11.TopRight = true;
            this.btn1_Settings.CustomizableEdges = borderEdges11;
            this.btn1_Settings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn1_Settings.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn1_Settings.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn1_Settings.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn1_Settings.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn1_Settings.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_Settings.ForeColor = System.Drawing.Color.Black;
            this.btn1_Settings.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1_Settings.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn1_Settings.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn1_Settings.IconMarginLeft = 11;
            this.btn1_Settings.IconPadding = 10;
            this.btn1_Settings.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn1_Settings.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn1_Settings.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn1_Settings.IconSize = 25;
            this.btn1_Settings.IdleBorderColor = System.Drawing.Color.White;
            this.btn1_Settings.IdleBorderRadius = 24;
            this.btn1_Settings.IdleBorderThickness = 1;
            this.btn1_Settings.IdleFillColor = System.Drawing.Color.White;
            this.btn1_Settings.IdleIconLeftImage = null;
            this.btn1_Settings.IdleIconRightImage = null;
            this.btn1_Settings.IndicateFocus = false;
            this.btn1_Settings.Location = new System.Drawing.Point(37, 97);
            this.btn1_Settings.Name = "btn1_Settings";
            this.btn1_Settings.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn1_Settings.OnDisabledState.BorderRadius = 1;
            this.btn1_Settings.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn1_Settings.OnDisabledState.BorderThickness = 1;
            this.btn1_Settings.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn1_Settings.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn1_Settings.OnDisabledState.IconLeftImage = null;
            this.btn1_Settings.OnDisabledState.IconRightImage = null;
            this.btn1_Settings.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn1_Settings.onHoverState.BorderRadius = 1;
            this.btn1_Settings.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn1_Settings.onHoverState.BorderThickness = 1;
            this.btn1_Settings.onHoverState.FillColor = System.Drawing.Color.White;
            this.btn1_Settings.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btn1_Settings.onHoverState.IconLeftImage = null;
            this.btn1_Settings.onHoverState.IconRightImage = null;
            this.btn1_Settings.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn1_Settings.OnIdleState.BorderRadius = 1;
            this.btn1_Settings.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn1_Settings.OnIdleState.BorderThickness = 1;
            this.btn1_Settings.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btn1_Settings.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn1_Settings.OnIdleState.IconLeftImage = null;
            this.btn1_Settings.OnIdleState.IconRightImage = null;
            this.btn1_Settings.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btn1_Settings.OnPressedState.BorderRadius = 1;
            this.btn1_Settings.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn1_Settings.OnPressedState.BorderThickness = 1;
            this.btn1_Settings.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btn1_Settings.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btn1_Settings.OnPressedState.IconLeftImage = null;
            this.btn1_Settings.OnPressedState.IconRightImage = null;
            this.btn1_Settings.Size = new System.Drawing.Size(100, 26);
            this.btn1_Settings.TabIndex = 2;
            this.btn1_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn1_Settings.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn1_Settings.TextMarginLeft = 0;
            this.btn1_Settings.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn1_Settings.UseDefaultRadiusAndThickness = true;
            this.btn1_Settings.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // btn2_About
            // 
            this.btn2_About.AllowAnimations = true;
            this.btn2_About.AllowMouseEffects = true;
            this.btn2_About.AllowToggling = false;
            this.btn2_About.AnimationSpeed = 200;
            this.btn2_About.AutoGenerateColors = false;
            this.btn2_About.AutoRoundBorders = true;
            this.btn2_About.AutoSizeLeftIcon = true;
            this.btn2_About.AutoSizeRightIcon = true;
            this.btn2_About.BackColor = System.Drawing.Color.Transparent;
            this.btn2_About.BackColor1 = System.Drawing.Color.White;
            this.btn2_About.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2_About.BackgroundImage")));
            this.btn2_About.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn2_About.ButtonText = "About";
            this.btn2_About.ButtonTextMarginLeft = 0;
            this.btn2_About.ColorContrastOnClick = 45;
            this.btn2_About.ColorContrastOnHover = 45;
            this.btn2_About.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges12.BottomLeft = true;
            borderEdges12.BottomRight = true;
            borderEdges12.TopLeft = true;
            borderEdges12.TopRight = true;
            this.btn2_About.CustomizableEdges = borderEdges12;
            this.btn2_About.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn2_About.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn2_About.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn2_About.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn2_About.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn2_About.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2_About.ForeColor = System.Drawing.Color.Black;
            this.btn2_About.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2_About.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn2_About.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn2_About.IconMarginLeft = 11;
            this.btn2_About.IconPadding = 10;
            this.btn2_About.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn2_About.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn2_About.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn2_About.IconSize = 25;
            this.btn2_About.IdleBorderColor = System.Drawing.Color.White;
            this.btn2_About.IdleBorderRadius = 24;
            this.btn2_About.IdleBorderThickness = 1;
            this.btn2_About.IdleFillColor = System.Drawing.Color.White;
            this.btn2_About.IdleIconLeftImage = null;
            this.btn2_About.IdleIconRightImage = null;
            this.btn2_About.IndicateFocus = false;
            this.btn2_About.Location = new System.Drawing.Point(41, 129);
            this.btn2_About.Name = "btn2_About";
            this.btn2_About.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn2_About.OnDisabledState.BorderRadius = 1;
            this.btn2_About.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn2_About.OnDisabledState.BorderThickness = 1;
            this.btn2_About.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn2_About.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn2_About.OnDisabledState.IconLeftImage = null;
            this.btn2_About.OnDisabledState.IconRightImage = null;
            this.btn2_About.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn2_About.onHoverState.BorderRadius = 1;
            this.btn2_About.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn2_About.onHoverState.BorderThickness = 1;
            this.btn2_About.onHoverState.FillColor = System.Drawing.Color.White;
            this.btn2_About.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btn2_About.onHoverState.IconLeftImage = null;
            this.btn2_About.onHoverState.IconRightImage = null;
            this.btn2_About.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn2_About.OnIdleState.BorderRadius = 1;
            this.btn2_About.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn2_About.OnIdleState.BorderThickness = 1;
            this.btn2_About.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btn2_About.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn2_About.OnIdleState.IconLeftImage = null;
            this.btn2_About.OnIdleState.IconRightImage = null;
            this.btn2_About.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btn2_About.OnPressedState.BorderRadius = 1;
            this.btn2_About.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn2_About.OnPressedState.BorderThickness = 1;
            this.btn2_About.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btn2_About.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btn2_About.OnPressedState.IconLeftImage = null;
            this.btn2_About.OnPressedState.IconRightImage = null;
            this.btn2_About.Size = new System.Drawing.Size(89, 26);
            this.btn2_About.TabIndex = 1;
            this.btn2_About.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn2_About.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn2_About.TextMarginLeft = 0;
            this.btn2_About.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn2_About.UseDefaultRadiusAndThickness = true;
            this.btn2_About.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // btn1_NowPlaying
            // 
            this.btn1_NowPlaying.AllowAnimations = true;
            this.btn1_NowPlaying.AllowMouseEffects = true;
            this.btn1_NowPlaying.AllowToggling = true;
            this.btn1_NowPlaying.AnimationSpeed = 200;
            this.btn1_NowPlaying.AutoGenerateColors = false;
            this.btn1_NowPlaying.AutoRoundBorders = true;
            this.btn1_NowPlaying.AutoSizeLeftIcon = true;
            this.btn1_NowPlaying.AutoSizeRightIcon = true;
            this.btn1_NowPlaying.BackColor = System.Drawing.Color.Transparent;
            this.btn1_NowPlaying.BackColor1 = System.Drawing.Color.White;
            this.btn1_NowPlaying.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1_NowPlaying.BackgroundImage")));
            this.btn1_NowPlaying.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn1_NowPlaying.ButtonText = "  Now Playing";
            this.btn1_NowPlaying.ButtonTextMarginLeft = 0;
            this.btn1_NowPlaying.ColorContrastOnClick = 45;
            this.btn1_NowPlaying.ColorContrastOnHover = 45;
            this.btn1_NowPlaying.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.btn1_NowPlaying.CustomizableEdges = borderEdges10;
            this.btn1_NowPlaying.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn1_NowPlaying.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn1_NowPlaying.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn1_NowPlaying.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn1_NowPlaying.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn1_NowPlaying.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_NowPlaying.ForeColor = System.Drawing.Color.Black;
            this.btn1_NowPlaying.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1_NowPlaying.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn1_NowPlaying.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn1_NowPlaying.IconMarginLeft = 11;
            this.btn1_NowPlaying.IconPadding = 10;
            this.btn1_NowPlaying.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn1_NowPlaying.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn1_NowPlaying.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn1_NowPlaying.IconSize = 25;
            this.btn1_NowPlaying.IdleBorderColor = System.Drawing.Color.White;
            this.btn1_NowPlaying.IdleBorderRadius = 55;
            this.btn1_NowPlaying.IdleBorderThickness = 1;
            this.btn1_NowPlaying.IdleFillColor = System.Drawing.Color.White;
            this.btn1_NowPlaying.IdleIconLeftImage = null;
            this.btn1_NowPlaying.IdleIconRightImage = global::WindowsFormsApp1.Properties.Resources.arrow_right_navigation;
            this.btn1_NowPlaying.IndicateFocus = true;
            this.btn1_NowPlaying.Location = new System.Drawing.Point(32, 290);
            this.btn1_NowPlaying.Name = "btn1_NowPlaying";
            this.btn1_NowPlaying.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn1_NowPlaying.OnDisabledState.BorderRadius = 1;
            this.btn1_NowPlaying.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn1_NowPlaying.OnDisabledState.BorderThickness = 1;
            this.btn1_NowPlaying.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn1_NowPlaying.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn1_NowPlaying.OnDisabledState.IconLeftImage = null;
            this.btn1_NowPlaying.OnDisabledState.IconRightImage = null;
            this.btn1_NowPlaying.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn1_NowPlaying.onHoverState.BorderRadius = 1;
            this.btn1_NowPlaying.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn1_NowPlaying.onHoverState.BorderThickness = 1;
            this.btn1_NowPlaying.onHoverState.FillColor = System.Drawing.Color.White;
            this.btn1_NowPlaying.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btn1_NowPlaying.onHoverState.IconLeftImage = null;
            this.btn1_NowPlaying.onHoverState.IconRightImage = global::WindowsFormsApp1.Properties.Resources.arrow_right_navigation_red1;
            this.btn1_NowPlaying.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn1_NowPlaying.OnIdleState.BorderRadius = 1;
            this.btn1_NowPlaying.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn1_NowPlaying.OnIdleState.BorderThickness = 1;
            this.btn1_NowPlaying.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btn1_NowPlaying.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn1_NowPlaying.OnIdleState.IconLeftImage = null;
            this.btn1_NowPlaying.OnIdleState.IconRightImage = global::WindowsFormsApp1.Properties.Resources.arrow_right_navigation;
            this.btn1_NowPlaying.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btn1_NowPlaying.OnPressedState.BorderRadius = 1;
            this.btn1_NowPlaying.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn1_NowPlaying.OnPressedState.BorderThickness = 1;
            this.btn1_NowPlaying.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btn1_NowPlaying.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn1_NowPlaying.OnPressedState.IconLeftImage = null;
            this.btn1_NowPlaying.OnPressedState.IconRightImage = global::WindowsFormsApp1.Properties.Resources.arrow_right_navigation;
            this.btn1_NowPlaying.Size = new System.Drawing.Size(284, 57);
            this.btn1_NowPlaying.TabIndex = 0;
            this.btn1_NowPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1_NowPlaying.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn1_NowPlaying.TextMarginLeft = 0;
            this.btn1_NowPlaying.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn1_NowPlaying.UseDefaultRadiusAndThickness = true;
            this.btn1_NowPlaying.Click += new System.EventHandler(this.btn1_NowPlaying_Click);
            // 
            // title3_Library
            // 
            this.title3_Library.AutoSize = true;
            this.title3_Library.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title3_Library.Location = new System.Drawing.Point(40, 215);
            this.title3_Library.Name = "title3_Library";
            this.title3_Library.Size = new System.Drawing.Size(116, 35);
            this.title3_Library.TabIndex = 2;
            this.title3_Library.Text = "Library";
            // 
            // title2_MusicPlayer
            // 
            this.title2_MusicPlayer.AutoSize = true;
            this.title2_MusicPlayer.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2_MusicPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.title2_MusicPlayer.Location = new System.Drawing.Point(38, 109);
            this.title2_MusicPlayer.Name = "title2_MusicPlayer";
            this.title2_MusicPlayer.Size = new System.Drawing.Size(262, 46);
            this.title2_MusicPlayer.TabIndex = 1;
            this.title2_MusicPlayer.Text = "Music Player";
            // 
            // title1_TheMethod
            // 
            this.title1_TheMethod.AutoSize = true;
            this.title1_TheMethod.Font = new System.Drawing.Font("Bad Signal", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1_TheMethod.Location = new System.Drawing.Point(32, 35);
            this.title1_TheMethod.Name = "title1_TheMethod";
            this.title1_TheMethod.Size = new System.Drawing.Size(364, 83);
            this.title1_TheMethod.TabIndex = 0;
            this.title1_TheMethod.Text = "The Method";
            // 
            // DragControl_TheMethod
            // 
            this.DragControl_TheMethod.Fixed = true;
            this.DragControl_TheMethod.Horizontal = true;
            this.DragControl_TheMethod.TargetControl = this.title1_TheMethod;
            this.DragControl_TheMethod.Vertical = true;
            // 
            // DragControl_MusicPlayer
            // 
            this.DragControl_MusicPlayer.Fixed = true;
            this.DragControl_MusicPlayer.Horizontal = true;
            this.DragControl_MusicPlayer.TargetControl = this.title2_MusicPlayer;
            this.DragControl_MusicPlayer.Vertical = true;
            // 
            // DragControl_Library
            // 
            this.DragControl_Library.Fixed = true;
            this.DragControl_Library.Horizontal = true;
            this.DragControl_Library.TargetControl = this.title3_Library;
            this.DragControl_Library.Vertical = true;
            // 
            // BottomRightPanel
            // 
            this.BottomRightPanel.BackColor = System.Drawing.Color.Transparent;
            this.BottomRightPanel.Controls.Add(this.BottomShadowPanel);
            this.BottomRightPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomRightPanel.Location = new System.Drawing.Point(464, 618);
            this.BottomRightPanel.Name = "BottomRightPanel";
            this.BottomRightPanel.Size = new System.Drawing.Size(936, 182);
            this.BottomRightPanel.TabIndex = 2;
            // 
            // BottomShadowPanel
            // 
            this.BottomShadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.BottomShadowPanel.BorderColor = System.Drawing.Color.Transparent;
            this.BottomShadowPanel.BorderRadius = 30;
            this.BottomShadowPanel.BorderThickness = 1;
            this.BottomShadowPanel.Controls.Add(this.SoundSlider);
            this.BottomShadowPanel.Controls.Add(this.SongTimer);
            this.BottomShadowPanel.Controls.Add(this.SpeakerPic);
            this.BottomShadowPanel.Controls.Add(this.SongSlider);
            this.BottomShadowPanel.Controls.Add(this.ForwardPic);
            this.BottomShadowPanel.Controls.Add(this.StopPic);
            this.BottomShadowPanel.Controls.Add(this.PlayPic);
            this.BottomShadowPanel.Controls.Add(this.BackwardPic);
            this.BottomShadowPanel.Controls.Add(this.ArtistName);
            this.BottomShadowPanel.Controls.Add(this.SongName);
            this.BottomShadowPanel.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.BottomShadowPanel.ForeColor = System.Drawing.Color.White;
            this.BottomShadowPanel.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.BottomShadowPanel.Location = new System.Drawing.Point(61, 45);
            this.BottomShadowPanel.Name = "BottomShadowPanel";
            this.BottomShadowPanel.PanelColor = System.Drawing.Color.Black;
            this.BottomShadowPanel.PanelColor2 = System.Drawing.Color.Black;
            this.BottomShadowPanel.ShadowColor = System.Drawing.Color.White;
            this.BottomShadowPanel.ShadowDept = 2;
            this.BottomShadowPanel.ShadowDepth = 5;
            this.BottomShadowPanel.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.BottomShadowPanel.ShadowTopLeftVisible = false;
            this.BottomShadowPanel.Size = new System.Drawing.Size(912, 177);
            this.BottomShadowPanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.BottomShadowPanel.TabIndex = 0;
            // 
            // SoundSlider
            // 
            this.SoundSlider.AllowCursorChanges = true;
            this.SoundSlider.AllowHomeEndKeysDetection = false;
            this.SoundSlider.AllowIncrementalClickMoves = true;
            this.SoundSlider.AllowMouseDownEffects = false;
            this.SoundSlider.AllowMouseHoverEffects = false;
            this.SoundSlider.AllowScrollingAnimations = true;
            this.SoundSlider.AllowScrollKeysDetection = true;
            this.SoundSlider.AllowScrollOptionsMenu = true;
            this.SoundSlider.AllowShrinkingOnFocusLost = false;
            this.SoundSlider.BackColor = System.Drawing.Color.Transparent;
            this.SoundSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SoundSlider.BackgroundImage")));
            this.SoundSlider.BindingContainer = null;
            this.SoundSlider.BorderRadius = 2;
            this.SoundSlider.BorderThickness = 1;
            this.SoundSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SoundSlider.DrawThickBorder = false;
            this.SoundSlider.DurationBeforeShrink = 2000;
            this.SoundSlider.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.SoundSlider.LargeChange = 10;
            this.SoundSlider.Location = new System.Drawing.Point(769, 27);
            this.SoundSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SoundSlider.Maximum = 100;
            this.SoundSlider.Minimum = 0;
            this.SoundSlider.MinimumSize = new System.Drawing.Size(0, 31);
            this.SoundSlider.MinimumThumbLength = 18;
            this.SoundSlider.Name = "SoundSlider";
            this.SoundSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.SoundSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.SoundSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.SoundSlider.ScrollBarBorderColor = System.Drawing.Color.White;
            this.SoundSlider.ScrollBarColor = System.Drawing.Color.White;
            this.SoundSlider.ShrinkSizeLimit = 3;
            this.SoundSlider.Size = new System.Drawing.Size(96, 31);
            this.SoundSlider.SliderColor = System.Drawing.Color.White;
            this.SoundSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.SoundSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.SoundSlider.SmallChange = 1;
            this.SoundSlider.TabIndex = 9;
            this.SoundSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.SoundSlider.ThumbFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.SoundSlider.ThumbLength = 18;
            this.SoundSlider.ThumbMargin = 1;
            this.SoundSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Small;
            this.SoundSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.SoundSlider.Value = 50;
            // 
            // SongTimer
            // 
            this.SongTimer.AutoSize = true;
            this.SongTimer.Location = new System.Drawing.Point(766, 70);
            this.SongTimer.Name = "SongTimer";
            this.SongTimer.Size = new System.Drawing.Size(36, 17);
            this.SongTimer.TabIndex = 8;
            this.SongTimer.Text = "2:55";
            // 
            // SpeakerPic
            // 
            this.SpeakerPic.Image = global::WindowsFormsApp1.Properties.Resources.speaker_32;
            this.SpeakerPic.Location = new System.Drawing.Point(814, 65);
            this.SpeakerPic.Name = "SpeakerPic";
            this.SpeakerPic.Size = new System.Drawing.Size(51, 29);
            this.SpeakerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpeakerPic.TabIndex = 7;
            this.SpeakerPic.TabStop = false;
            this.SpeakerPic.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // SongSlider
            // 
            this.SongSlider.AllowCursorChanges = true;
            this.SongSlider.AllowHomeEndKeysDetection = false;
            this.SongSlider.AllowIncrementalClickMoves = true;
            this.SongSlider.AllowMouseDownEffects = false;
            this.SongSlider.AllowMouseHoverEffects = false;
            this.SongSlider.AllowScrollingAnimations = true;
            this.SongSlider.AllowScrollKeysDetection = true;
            this.SongSlider.AllowScrollOptionsMenu = true;
            this.SongSlider.AllowShrinkingOnFocusLost = false;
            this.SongSlider.BackColor = System.Drawing.Color.Transparent;
            this.SongSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SongSlider.BackgroundImage")));
            this.SongSlider.BindingContainer = null;
            this.SongSlider.BorderRadius = 2;
            this.SongSlider.BorderThickness = 1;
            this.SongSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SongSlider.DrawThickBorder = false;
            this.SongSlider.DurationBeforeShrink = 2000;
            this.SongSlider.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.SongSlider.LargeChange = 10;
            this.SongSlider.Location = new System.Drawing.Point(431, 63);
            this.SongSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SongSlider.Maximum = 100;
            this.SongSlider.Minimum = 0;
            this.SongSlider.MinimumSize = new System.Drawing.Size(0, 31);
            this.SongSlider.MinimumThumbLength = 18;
            this.SongSlider.Name = "SongSlider";
            this.SongSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.SongSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.SongSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.SongSlider.ScrollBarBorderColor = System.Drawing.Color.White;
            this.SongSlider.ScrollBarColor = System.Drawing.Color.White;
            this.SongSlider.ShrinkSizeLimit = 3;
            this.SongSlider.Size = new System.Drawing.Size(328, 31);
            this.SongSlider.SliderColor = System.Drawing.Color.White;
            this.SongSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.SongSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.SongSlider.SmallChange = 1;
            this.SongSlider.TabIndex = 6;
            this.SongSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.SongSlider.ThumbFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.SongSlider.ThumbLength = 32;
            this.SongSlider.ThumbMargin = 1;
            this.SongSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.SongSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.SongSlider.Value = 50;
            // 
            // ForwardPic
            // 
            this.ForwardPic.Image = global::WindowsFormsApp1.Properties.Resources.Forwardbutton_WhiteBlack1;
            this.ForwardPic.Location = new System.Drawing.Point(353, 57);
            this.ForwardPic.Name = "ForwardPic";
            this.ForwardPic.Size = new System.Drawing.Size(57, 41);
            this.ForwardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ForwardPic.TabIndex = 5;
            this.ForwardPic.TabStop = false;
            // 
            // StopPic
            // 
            this.StopPic.Image = global::WindowsFormsApp1.Properties.Resources.Stopbutton_WhiteBlack1;
            this.StopPic.Location = new System.Drawing.Point(295, 57);
            this.StopPic.Name = "StopPic";
            this.StopPic.Size = new System.Drawing.Size(53, 41);
            this.StopPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StopPic.TabIndex = 4;
            this.StopPic.TabStop = false;
            this.StopPic.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // PlayPic
            // 
            this.PlayPic.Image = global::WindowsFormsApp1.Properties.Resources.Playbutton_RedWhite1;
            this.PlayPic.Location = new System.Drawing.Point(237, 57);
            this.PlayPic.Name = "PlayPic";
            this.PlayPic.Size = new System.Drawing.Size(53, 41);
            this.PlayPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayPic.TabIndex = 3;
            this.PlayPic.TabStop = false;
            this.PlayPic.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BackwardPic
            // 
            this.BackwardPic.Image = global::WindowsFormsApp1.Properties.Resources.Backwardbutton_WhiteBlack1;
            this.BackwardPic.Location = new System.Drawing.Point(178, 57);
            this.BackwardPic.Name = "BackwardPic";
            this.BackwardPic.Size = new System.Drawing.Size(53, 41);
            this.BackwardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackwardPic.TabIndex = 2;
            this.BackwardPic.TabStop = false;
            // 
            // ArtistName
            // 
            this.ArtistName.AutoSize = true;
            this.ArtistName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistName.Location = new System.Drawing.Point(21, 80);
            this.ArtistName.Name = "ArtistName";
            this.ArtistName.Size = new System.Drawing.Size(116, 22);
            this.ArtistName.TabIndex = 1;
            this.ArtistName.Text = "Artist Name";
            // 
            // SongName
            // 
            this.SongName.AutoSize = true;
            this.SongName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongName.Location = new System.Drawing.Point(20, 44);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(145, 29);
            this.SongName.TabIndex = 0;
            this.SongName.Text = "Song Name";
            // 
            // ExitPicture
            // 
            this.ExitPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPicture.Image = global::WindowsFormsApp1.Properties.Resources.Black_X;
            this.ExitPicture.Location = new System.Drawing.Point(1370, 9);
            this.ExitPicture.Name = "ExitPicture";
            this.ExitPicture.Size = new System.Drawing.Size(17, 25);
            this.ExitPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitPicture.TabIndex = 0;
            this.ExitPicture.TabStop = false;
            this.ExitPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.ExitPicture);
            this.Controls.Add(this.BottomRightPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.BottomLeftPanel.ResumeLayout(false);
            this.BottomRightPanel.ResumeLayout(false);
            this.BottomShadowPanel.ResumeLayout(false);
            this.BottomShadowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeakerPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackwardPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox ExitPicture;
        private Bunifu.UI.WinForms.BunifuPanel LeftPanel;
        private System.Windows.Forms.Label title2_MusicPlayer;
        private System.Windows.Forms.Label title1_TheMethod;
        private System.Windows.Forms.Label title3_Library;
        private Bunifu.Framework.UI.BunifuDragControl DragControl_LeftPanel;
        private Bunifu.Framework.UI.BunifuDragControl DragControl_TheMethod;
        private Bunifu.Framework.UI.BunifuDragControl DragControl_MusicPlayer;
        private Bunifu.Framework.UI.BunifuDragControl DragControl_Library;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn1_NowPlaying;
        private Bunifu.UI.WinForms.BunifuPanel BottomLeftPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn2_About;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn1_Settings;
        private System.Windows.Forms.Panel BottomRightPanel;
        private Bunifu.UI.WinForms.BunifuShadowPanel BottomShadowPanel;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.Label ArtistName;
        private System.Windows.Forms.PictureBox BackwardPic;
        private System.Windows.Forms.PictureBox ForwardPic;
        private System.Windows.Forms.PictureBox StopPic;
        private System.Windows.Forms.PictureBox PlayPic;
        private System.Windows.Forms.PictureBox SpeakerPic;
        private Bunifu.UI.WinForms.BunifuHSlider SongSlider;
        private System.Windows.Forms.Label SongTimer;
        private Bunifu.UI.WinForms.BunifuHSlider SoundSlider;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn4_Favourites;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn3_Playlists;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn2_Songs;
    }
}

