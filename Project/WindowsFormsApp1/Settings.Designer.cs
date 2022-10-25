namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState1 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState2 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState3 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ExitPicture = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btn_English = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Turkish = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.toggle_Theme = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            this.lbl_Light = new System.Windows.Forms.Label();
            this.lbl_Dark = new System.Windows.Forms.Label();
            this.lbl_Language = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.lbl_Theme = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ExitPicture
            // 
            this.ExitPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPicture.Image = global::WindowsFormsApp1.Properties.Resources.White_X;
            this.ExitPicture.Location = new System.Drawing.Point(421, 12);
            this.ExitPicture.Name = "ExitPicture";
            this.ExitPicture.Size = new System.Drawing.Size(17, 25);
            this.ExitPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitPicture.TabIndex = 2;
            this.ExitPicture.TabStop = false;
            this.ExitPicture.Click += new System.EventHandler(this.ExitPicture_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btn_English
            // 
            this.btn_English.AllowAnimations = true;
            this.btn_English.AllowMouseEffects = true;
            this.btn_English.AllowToggling = true;
            this.btn_English.AnimationSpeed = 200;
            this.btn_English.AutoGenerateColors = false;
            this.btn_English.AutoRoundBorders = true;
            this.btn_English.AutoSizeLeftIcon = true;
            this.btn_English.AutoSizeRightIcon = true;
            this.btn_English.BackColor = System.Drawing.Color.Transparent;
            this.btn_English.BackColor1 = System.Drawing.Color.White;
            this.btn_English.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_English.BackgroundImage")));
            this.btn_English.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_English.ButtonText = "English";
            this.btn_English.ButtonTextMarginLeft = 0;
            this.btn_English.ColorContrastOnClick = 45;
            this.btn_English.ColorContrastOnHover = 45;
            this.btn_English.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_English.CustomizableEdges = borderEdges2;
            this.btn_English.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_English.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_English.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_English.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_English.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_English.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_English.ForeColor = System.Drawing.Color.Black;
            this.btn_English.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_English.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_English.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_English.IconMarginLeft = 11;
            this.btn_English.IconPadding = 10;
            this.btn_English.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_English.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_English.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_English.IconSize = 25;
            this.btn_English.IdleBorderColor = System.Drawing.Color.White;
            this.btn_English.IdleBorderRadius = 41;
            this.btn_English.IdleBorderThickness = 1;
            this.btn_English.IdleFillColor = System.Drawing.Color.White;
            this.btn_English.IdleIconLeftImage = null;
            this.btn_English.IdleIconRightImage = null;
            this.btn_English.IndicateFocus = true;
            this.btn_English.Location = new System.Drawing.Point(15, 150);
            this.btn_English.Name = "btn_English";
            this.btn_English.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_English.OnDisabledState.BorderRadius = 1;
            this.btn_English.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_English.OnDisabledState.BorderThickness = 1;
            this.btn_English.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_English.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_English.OnDisabledState.IconLeftImage = null;
            this.btn_English.OnDisabledState.IconRightImage = null;
            this.btn_English.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_English.onHoverState.BorderRadius = 1;
            this.btn_English.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_English.onHoverState.BorderThickness = 1;
            this.btn_English.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_English.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_English.onHoverState.IconLeftImage = null;
            this.btn_English.onHoverState.IconRightImage = null;
            this.btn_English.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_English.OnIdleState.BorderRadius = 1;
            this.btn_English.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_English.OnIdleState.BorderThickness = 1;
            this.btn_English.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btn_English.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_English.OnIdleState.IconLeftImage = null;
            this.btn_English.OnIdleState.IconRightImage = null;
            this.btn_English.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_English.OnPressedState.BorderRadius = 1;
            this.btn_English.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_English.OnPressedState.BorderThickness = 1;
            this.btn_English.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_English.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_English.OnPressedState.IconLeftImage = null;
            this.btn_English.OnPressedState.IconRightImage = null;
            this.btn_English.Size = new System.Drawing.Size(198, 43);
            this.btn_English.TabIndex = 8;
            this.btn_English.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_English.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_English.TextMarginLeft = 0;
            this.btn_English.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_English.UseDefaultRadiusAndThickness = true;
            this.btn_English.Click += new System.EventHandler(this.btn_English_Click);
            // 
            // btn_Turkish
            // 
            this.btn_Turkish.AllowAnimations = true;
            this.btn_Turkish.AllowMouseEffects = true;
            this.btn_Turkish.AllowToggling = true;
            this.btn_Turkish.AnimationSpeed = 200;
            this.btn_Turkish.AutoGenerateColors = false;
            this.btn_Turkish.AutoRoundBorders = true;
            this.btn_Turkish.AutoSizeLeftIcon = true;
            this.btn_Turkish.AutoSizeRightIcon = true;
            this.btn_Turkish.BackColor = System.Drawing.Color.Transparent;
            this.btn_Turkish.BackColor1 = System.Drawing.Color.White;
            this.btn_Turkish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Turkish.BackgroundImage")));
            this.btn_Turkish.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Turkish.ButtonText = "Türkçe";
            this.btn_Turkish.ButtonTextMarginLeft = 0;
            this.btn_Turkish.ColorContrastOnClick = 45;
            this.btn_Turkish.ColorContrastOnHover = 45;
            this.btn_Turkish.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_Turkish.CustomizableEdges = borderEdges1;
            this.btn_Turkish.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Turkish.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Turkish.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Turkish.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Turkish.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Turkish.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Turkish.ForeColor = System.Drawing.Color.Black;
            this.btn_Turkish.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Turkish.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Turkish.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Turkish.IconMarginLeft = 11;
            this.btn_Turkish.IconPadding = 10;
            this.btn_Turkish.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Turkish.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Turkish.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Turkish.IconSize = 25;
            this.btn_Turkish.IdleBorderColor = System.Drawing.Color.White;
            this.btn_Turkish.IdleBorderRadius = 41;
            this.btn_Turkish.IdleBorderThickness = 1;
            this.btn_Turkish.IdleFillColor = System.Drawing.Color.White;
            this.btn_Turkish.IdleIconLeftImage = null;
            this.btn_Turkish.IdleIconRightImage = null;
            this.btn_Turkish.IndicateFocus = true;
            this.btn_Turkish.Location = new System.Drawing.Point(237, 150);
            this.btn_Turkish.Name = "btn_Turkish";
            this.btn_Turkish.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Turkish.OnDisabledState.BorderRadius = 1;
            this.btn_Turkish.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Turkish.OnDisabledState.BorderThickness = 1;
            this.btn_Turkish.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Turkish.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Turkish.OnDisabledState.IconLeftImage = null;
            this.btn_Turkish.OnDisabledState.IconRightImage = null;
            this.btn_Turkish.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_Turkish.onHoverState.BorderRadius = 1;
            this.btn_Turkish.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Turkish.onHoverState.BorderThickness = 1;
            this.btn_Turkish.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_Turkish.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Turkish.onHoverState.IconLeftImage = null;
            this.btn_Turkish.onHoverState.IconRightImage = null;
            this.btn_Turkish.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btn_Turkish.OnIdleState.BorderRadius = 1;
            this.btn_Turkish.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Turkish.OnIdleState.BorderThickness = 1;
            this.btn_Turkish.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btn_Turkish.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_Turkish.OnIdleState.IconLeftImage = null;
            this.btn_Turkish.OnIdleState.IconRightImage = null;
            this.btn_Turkish.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_Turkish.OnPressedState.BorderRadius = 1;
            this.btn_Turkish.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Turkish.OnPressedState.BorderThickness = 1;
            this.btn_Turkish.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btn_Turkish.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Turkish.OnPressedState.IconLeftImage = null;
            this.btn_Turkish.OnPressedState.IconRightImage = null;
            this.btn_Turkish.Size = new System.Drawing.Size(198, 43);
            this.btn_Turkish.TabIndex = 9;
            this.btn_Turkish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Turkish.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Turkish.TextMarginLeft = 0;
            this.btn_Turkish.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Turkish.UseDefaultRadiusAndThickness = true;
            this.btn_Turkish.Click += new System.EventHandler(this.btn_Turkish_Click);
            // 
            // toggle_Theme
            // 
            this.toggle_Theme.Animation = 5;
            this.toggle_Theme.BackColor = System.Drawing.Color.Transparent;
            this.toggle_Theme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggle_Theme.BackgroundImage")));
            this.toggle_Theme.Checked = false;
            this.toggle_Theme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggle_Theme.InnerCirclePadding = 3;
            this.toggle_Theme.Location = new System.Drawing.Point(186, 266);
            this.toggle_Theme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toggle_Theme.Name = "toggle_Theme";
            this.toggle_Theme.Size = new System.Drawing.Size(68, 23);
            this.toggle_Theme.TabIndex = 11;
            this.toggle_Theme.ThumbMargin = 3;
            toggleState1.BackColor = System.Drawing.Color.DarkGray;
            toggleState1.BackColorInner = System.Drawing.Color.White;
            toggleState1.BorderColor = System.Drawing.Color.DarkGray;
            toggleState1.BorderColorInner = System.Drawing.Color.White;
            toggleState1.BorderRadius = 17;
            toggleState1.BorderRadiusInner = 11;
            toggleState1.BorderThickness = 1;
            toggleState1.BorderThicknessInner = 1;
            this.toggle_Theme.ToggleStateDisabled = toggleState1;
            toggleState2.BackColor = System.Drawing.Color.White;
            toggleState2.BackColorInner = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            toggleState2.BorderColor = System.Drawing.Color.White;
            toggleState2.BorderColorInner = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            toggleState2.BorderRadius = 17;
            toggleState2.BorderRadiusInner = 11;
            toggleState2.BorderThickness = 1;
            toggleState2.BorderThicknessInner = 1;
            this.toggle_Theme.ToggleStateOff = toggleState2;
            toggleState3.BackColor = System.Drawing.Color.Black;
            toggleState3.BackColorInner = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            toggleState3.BorderColor = System.Drawing.Color.Black;
            toggleState3.BorderColorInner = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            toggleState3.BorderRadius = 17;
            toggleState3.BorderRadiusInner = 11;
            toggleState3.BorderThickness = 1;
            toggleState3.BorderThicknessInner = 1;
            this.toggle_Theme.ToggleStateOn = toggleState3;
            this.toggle_Theme.Value = false;
            // 
            // lbl_Light
            // 
            this.lbl_Light.AutoSize = true;
            this.lbl_Light.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Light.ForeColor = System.Drawing.Color.White;
            this.lbl_Light.Location = new System.Drawing.Point(122, 266);
            this.lbl_Light.Name = "lbl_Light";
            this.lbl_Light.Size = new System.Drawing.Size(57, 22);
            this.lbl_Light.TabIndex = 12;
            this.lbl_Light.Text = "Light";
            // 
            // lbl_Dark
            // 
            this.lbl_Dark.AutoSize = true;
            this.lbl_Dark.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dark.ForeColor = System.Drawing.Color.White;
            this.lbl_Dark.Location = new System.Drawing.Point(262, 266);
            this.lbl_Dark.Name = "lbl_Dark";
            this.lbl_Dark.Size = new System.Drawing.Size(54, 22);
            this.lbl_Dark.TabIndex = 13;
            this.lbl_Dark.Text = "Dark";
            // 
            // lbl_Language
            // 
            this.lbl_Language.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Language.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Language.ForeColor = System.Drawing.Color.White;
            this.lbl_Language.Location = new System.Drawing.Point(0, 0);
            this.lbl_Language.Name = "lbl_Language";
            this.lbl_Language.Size = new System.Drawing.Size(163, 43);
            this.lbl_Language.TabIndex = 17;
            this.lbl_Language.Text = "Language";
            this.lbl_Language.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Language);
            this.panel1.Location = new System.Drawing.Point(139, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 43);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Title);
            this.panel2.Location = new System.Drawing.Point(146, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 50);
            this.panel2.TabIndex = 19;
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(152, 50);
            this.Title.TabIndex = 18;
            this.Title.Text = "Settings";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Theme
            // 
            this.lbl_Theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Theme.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Theme.ForeColor = System.Drawing.Color.White;
            this.lbl_Theme.Location = new System.Drawing.Point(0, 0);
            this.lbl_Theme.Name = "lbl_Theme";
            this.lbl_Theme.Size = new System.Drawing.Size(160, 40);
            this.lbl_Theme.TabIndex = 20;
            this.lbl_Theme.Text = "Theme";
            this.lbl_Theme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_Theme);
            this.panel3.Location = new System.Drawing.Point(142, 219);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 40);
            this.panel3.TabIndex = 21;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbl_Dark);
            this.Controls.Add(this.lbl_Light);
            this.Controls.Add(this.toggle_Theme);
            this.Controls.Add(this.btn_Turkish);
            this.Controls.Add(this.btn_English);
            this.Controls.Add(this.ExitPicture);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.ExitPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox ExitPicture;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_English;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Turkish;
        private Bunifu.UI.WinForms.BunifuToggleSwitch toggle_Theme;
        private System.Windows.Forms.Label lbl_Dark;
        private System.Windows.Forms.Label lbl_Light;
        private System.Windows.Forms.Label lbl_Language;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Theme;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel3;
    }
}