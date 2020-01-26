namespace KeepMyShit
{
    partial class KMSWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KMSWindow));
            this.CultureCodeCB = new System.Windows.Forms.ComboBox();
            this.Mic_Input_Box = new System.Windows.Forms.GroupBox();
            this.Cur_Mic_Input_Volume_Per_Label = new System.Windows.Forms.Label();
            this.Mic_Input_Image_Box = new System.Windows.Forms.PictureBox();
            this.Mic_Volume_Input_Pegel_Slider = new System.Windows.Forms.TrackBar();
            this.Cur_Culture_Code_Label = new System.Windows.Forms.Label();
            this.Culture_Image_Box = new System.Windows.Forms.PictureBox();
            this.Cur_Output_Volume_Per_Label = new System.Windows.Forms.Label();
            this.Output_Image_Box = new System.Windows.Forms.PictureBox();
            this.Out_Volume_Pegel_Slider = new System.Windows.Forms.TrackBar();
            this.SettingsBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Interval_Disclaimer_Label = new System.Windows.Forms.Label();
            this.Timer_Interval_Disclaimer_Label = new System.Windows.Forms.Label();
            this.Interval_Picker_For_Timer = new System.Windows.Forms.NumericUpDown();
            this.Is_Autostart_CheckBox = new System.Windows.Forms.CheckBox();
            this.Launch_With_Windows_Disclaimer_Label = new System.Windows.Forms.Label();
            this.SafeToConfigBottom = new System.Windows.Forms.Button();
            this.Disclaimer_Label_3ver = new System.Windows.Forms.LinkLabel();
            this.Disclaimer_Label_Github = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.NotifyIcon_KMS = new System.Windows.Forms.NotifyIcon(this.components);
            this.Notifyicon_Context_Strip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitKMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.Keyboard_Box = new System.Windows.Forms.GroupBox();
            this.About_Box = new System.Windows.Forms.GroupBox();
            this.Audio_Output_Box = new System.Windows.Forms.GroupBox();
            this.Icon_List = new System.Windows.Forms.ImageList(this.components);
            this.Log_Box = new System.Windows.Forms.GroupBox();
            this.Log_Text_Box = new System.Windows.Forms.RichTextBox();
            this.Mic_Input_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mic_Input_Image_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mic_Volume_Input_Pegel_Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Culture_Image_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Output_Image_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Out_Volume_Pegel_Slider)).BeginInit();
            this.SettingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Interval_Picker_For_Timer)).BeginInit();
            this.Notifyicon_Context_Strip.SuspendLayout();
            this.Keyboard_Box.SuspendLayout();
            this.About_Box.SuspendLayout();
            this.Audio_Output_Box.SuspendLayout();
            this.Log_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // CultureCodeCB
            // 
            this.CultureCodeCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CultureCodeCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CultureCodeCB.FormattingEnabled = true;
            this.CultureCodeCB.Items.AddRange(new object[] {
            "Albanian",
            "Arabic (101)",
            "Arabic (102)",
            "Arabic (102) Azerty",
            "Armenian eastern",
            "Armenian Western",
            "Assamese - inscript",
            "Azeri Cyrillic",
            "Azeri Latin",
            "Bashkir",
            "Belarusian",
            "Belgian (comma)",
            "Belgian (period)",
            "Belgian French",
            "Bengali",
            "Bengali - inscript",
            "Bengali - inscript (legacy)",
            "Bosnian (cyrillic)",
            "Bulgarian",
            "Bulgarian (latin)",
            "Bulgarian (phonetic traditional)",
            "Bulgarian (phonetic)",
            "Bulgarian(typewriter)",
            "Canada French",
            "Canada French (legacy)",
            "Canada Multilingual",
            "Chinese (simplified) -us keyboard",
            "Chinese (simplified, singapore) - us keyboard",
            "Chinese (traditional) - us keyboard",
            "Chinese (traditional, hong kong s.a.r.) - us keyboard",
            "Chinese (traditional, macao s.a.r.) - us keyboard",
            "Croatian",
            "Czech",
            "Czech (qwerty)",
            "Czech programmers",
            "Danish",
            "Deanagari - inscript",
            "Divehi phonetic",
            "Divehi typewriter",
            "Dutch",
            "Estonian",
            "Faeroese",
            "Finnish",
            "Finnish with sami",
            "French",
            "Gaelic",
            "Georgian",
            "Georgian (ergonomic)",
            "Georgian (qwerty)",
            "German",
            "German (ibm)",
            "Greek",
            "Greek (220)",
            "Greek (220) latin",
            "Greek (319)",
            "Greek (319) latin",
            "Greek latin",
            "Greek polyonic",
            "Greenlandic",
            "Gujarati",
            "Hausa",
            "Hebrew",
            "Hindi traditional",
            "Hungarian",
            "Hungarian 101 key",
            "Icelandic",
            "Igbo",
            "Inuktitut - latin",
            "Inuktitut - naqittaut",
            "Irish",
            "Italian",
            "Italian (142)",
            "Japanese",
            "Kannada",
            "Kazakh",
            "Khmer",
            "Korean",
            "Kyrgyz cyrillic",
            "Lao",
            "Latin america",
            "Latvian",
            "Latvian (qwerty)",
            "Lithuanian",
            "Lithuanian ibm",
            "Lithuanian standard",
            "Luxembourgish",
            "Macedonian (fyrom)",
            "Macedonian (fyrom) - standard",
            "Malayalam",
            "Maltese 47-key",
            "Maltese 48-key",
            "Marathi",
            "Maroi",
            "Mongolian (mongolian script)",
            "Mongolian cyrillic",
            "Nepali",
            "Norwegian",
            "Norwegian with sami",
            "Oriya",
            "Pashto (afghanistan)",
            "Persian",
            "Polish (214)",
            "Polish (programmers)",
            "Portuguese",
            "Portuguese (brazillian abnt)",
            "Portuguese (brazillian abnt2)",
            "Punjabi",
            "Romanian (legacy)",
            "Romanian (programmers)",
            "Romanian (standard)",
            "Russian",
            "Russian (typewriter)",
            "Sami extended finland-sweden",
            "Sami extended norway",
            "Serbian (cyrillic)",
            "Serbian (latin)",
            "Sesotho sa Leboa",
            "Setswana",
            "Sinhala",
            "Sinhala -Wij 9",
            "Slovak",
            "Slovak (qwerty)",
            "Slovenian",
            "Sorbian extended",
            "Sorbian standard",
            "Sorbian standard (legacy)",
            "Spanish",
            "Spanish variation",
            "Swedish",
            "Swedish with sami",
            "Swiss french",
            "Swiss german",
            "Syriac",
            "Syriac phonetic",
            "Tajik",
            "Tamil",
            "Tatar",
            "Telugu",
            "Thai Kedmanee",
            "Thai Kedmanee (non-shiftlock)",
            "Thai Pattachote",
            "Thai Pattachote (non-shiftlock)",
            "Tibetan (prc)",
            "Turkish F",
            "Turkish Q",
            "Turkmen",
            "Ukrainian",
            "Ukrainian (enhanced)",
            "United Kingdom",
            "United Kingdom Extended",
            "United States",
            "United States - dvorak",
            "United States - dvorak left hand",
            "United States - dvorak right hand",
            "United States - india",
            "United States - international",
            "Urdu",
            "Uyghur",
            "Uyghur (legacy)",
            "Uzbek cyrillic",
            "Vietnamese",
            "Wolof",
            "Yakut",
            "Yoruba"});
            this.CultureCodeCB.Location = new System.Drawing.Point(39, 35);
            this.CultureCodeCB.Name = "CultureCodeCB";
            this.CultureCodeCB.Size = new System.Drawing.Size(227, 21);
            this.CultureCodeCB.Sorted = true;
            this.CultureCodeCB.TabIndex = 0;
            this.CultureCodeCB.SelectedIndexChanged += new System.EventHandler(this.CultureCodeCB_SelectedIndexChanged);
            // 
            // Mic_Input_Box
            // 
            this.Mic_Input_Box.Controls.Add(this.Cur_Mic_Input_Volume_Per_Label);
            this.Mic_Input_Box.Controls.Add(this.Mic_Input_Image_Box);
            this.Mic_Input_Box.Controls.Add(this.Mic_Volume_Input_Pegel_Slider);
            this.Mic_Input_Box.Location = new System.Drawing.Point(7, 3);
            this.Mic_Input_Box.Name = "Mic_Input_Box";
            this.Mic_Input_Box.Size = new System.Drawing.Size(51, 266);
            this.Mic_Input_Box.TabIndex = 1;
            this.Mic_Input_Box.TabStop = false;
            // 
            // Cur_Mic_Input_Volume_Per_Label
            // 
            this.Cur_Mic_Input_Volume_Per_Label.AutoSize = true;
            this.Cur_Mic_Input_Volume_Per_Label.Location = new System.Drawing.Point(12, 250);
            this.Cur_Mic_Input_Volume_Per_Label.Name = "Cur_Mic_Input_Volume_Per_Label";
            this.Cur_Mic_Input_Volume_Per_Label.Size = new System.Drawing.Size(88, 13);
            this.Cur_Mic_Input_Volume_Per_Label.TabIndex = 3;
            this.Cur_Mic_Input_Volume_Per_Label.Text = "#Cur_Mic_Vol_%";
            this.Cur_Mic_Input_Volume_Per_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mic_Input_Image_Box
            // 
            this.Mic_Input_Image_Box.Image = global::KeepMyShit.Properties.Resources._016_microphone;
            this.Mic_Input_Image_Box.Location = new System.Drawing.Point(6, 19);
            this.Mic_Input_Image_Box.Name = "Mic_Input_Image_Box";
            this.Mic_Input_Image_Box.Size = new System.Drawing.Size(39, 30);
            this.Mic_Input_Image_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mic_Input_Image_Box.TabIndex = 2;
            this.Mic_Input_Image_Box.TabStop = false;
            // 
            // Mic_Volume_Input_Pegel_Slider
            // 
            this.Mic_Volume_Input_Pegel_Slider.Location = new System.Drawing.Point(4, 53);
            this.Mic_Volume_Input_Pegel_Slider.Maximum = 100;
            this.Mic_Volume_Input_Pegel_Slider.Name = "Mic_Volume_Input_Pegel_Slider";
            this.Mic_Volume_Input_Pegel_Slider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Mic_Volume_Input_Pegel_Slider.Size = new System.Drawing.Size(45, 204);
            this.Mic_Volume_Input_Pegel_Slider.TabIndex = 1;
            this.Mic_Volume_Input_Pegel_Slider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Mic_Volume_Input_Pegel_Slider.Value = 100;
            this.Mic_Volume_Input_Pegel_Slider.Scroll += new System.EventHandler(this.Mic_Volume_Input_Slider_Changed);
            // 
            // Cur_Culture_Code_Label
            // 
            this.Cur_Culture_Code_Label.AutoSize = true;
            this.Cur_Culture_Code_Label.Location = new System.Drawing.Point(6, 59);
            this.Cur_Culture_Code_Label.Name = "Cur_Culture_Code_Label";
            this.Cur_Culture_Code_Label.Size = new System.Drawing.Size(88, 13);
            this.Cur_Culture_Code_Label.TabIndex = 8;
            this.Cur_Culture_Code_Label.Text = "#Cur_Out_Vol_%";
            this.Cur_Culture_Code_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Culture_Image_Box
            // 
            this.Culture_Image_Box.Image = global::KeepMyShit.Properties.Resources._029_settings;
            this.Culture_Image_Box.Location = new System.Drawing.Point(9, 35);
            this.Culture_Image_Box.Name = "Culture_Image_Box";
            this.Culture_Image_Box.Size = new System.Drawing.Size(24, 21);
            this.Culture_Image_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Culture_Image_Box.TabIndex = 7;
            this.Culture_Image_Box.TabStop = false;
            // 
            // Cur_Output_Volume_Per_Label
            // 
            this.Cur_Output_Volume_Per_Label.AutoSize = true;
            this.Cur_Output_Volume_Per_Label.Location = new System.Drawing.Point(8, 250);
            this.Cur_Output_Volume_Per_Label.Name = "Cur_Output_Volume_Per_Label";
            this.Cur_Output_Volume_Per_Label.Size = new System.Drawing.Size(88, 13);
            this.Cur_Output_Volume_Per_Label.TabIndex = 6;
            this.Cur_Output_Volume_Per_Label.Text = "#Cur_Out_Vol_%";
            this.Cur_Output_Volume_Per_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Output_Image_Box
            // 
            this.Output_Image_Box.Image = global::KeepMyShit.Properties.Resources._008_sound;
            this.Output_Image_Box.Location = new System.Drawing.Point(6, 11);
            this.Output_Image_Box.Name = "Output_Image_Box";
            this.Output_Image_Box.Size = new System.Drawing.Size(39, 45);
            this.Output_Image_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Output_Image_Box.TabIndex = 5;
            this.Output_Image_Box.TabStop = false;
            // 
            // Out_Volume_Pegel_Slider
            // 
            this.Out_Volume_Pegel_Slider.Location = new System.Drawing.Point(5, 53);
            this.Out_Volume_Pegel_Slider.Maximum = 100;
            this.Out_Volume_Pegel_Slider.Name = "Out_Volume_Pegel_Slider";
            this.Out_Volume_Pegel_Slider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Out_Volume_Pegel_Slider.Size = new System.Drawing.Size(45, 204);
            this.Out_Volume_Pegel_Slider.TabIndex = 4;
            this.Out_Volume_Pegel_Slider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Out_Volume_Pegel_Slider.Value = 100;
            this.Out_Volume_Pegel_Slider.Scroll += new System.EventHandler(this.Out_Volume_Slider_Changed);
            // 
            // SettingsBox
            // 
            this.SettingsBox.Controls.Add(this.label1);
            this.SettingsBox.Controls.Add(this.Interval_Disclaimer_Label);
            this.SettingsBox.Controls.Add(this.Timer_Interval_Disclaimer_Label);
            this.SettingsBox.Controls.Add(this.Interval_Picker_For_Timer);
            this.SettingsBox.Controls.Add(this.Is_Autostart_CheckBox);
            this.SettingsBox.Controls.Add(this.Launch_With_Windows_Disclaimer_Label);
            this.SettingsBox.Location = new System.Drawing.Point(119, 81);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(272, 99);
            this.SettingsBox.TabIndex = 2;
            this.SettingsBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Other";
            // 
            // Interval_Disclaimer_Label
            // 
            this.Interval_Disclaimer_Label.AutoSize = true;
            this.Interval_Disclaimer_Label.ForeColor = System.Drawing.Color.Gray;
            this.Interval_Disclaimer_Label.Location = new System.Drawing.Point(62, 16);
            this.Interval_Disclaimer_Label.Name = "Interval_Disclaimer_Label";
            this.Interval_Disclaimer_Label.Size = new System.Drawing.Size(197, 13);
            this.Interval_Disclaimer_Label.TabIndex = 13;
            this.Interval_Disclaimer_Label.Text = "(Milliseconds to check the configuration)";
            this.Interval_Disclaimer_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Timer_Interval_Disclaimer_Label
            // 
            this.Timer_Interval_Disclaimer_Label.AutoSize = true;
            this.Timer_Interval_Disclaimer_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer_Interval_Disclaimer_Label.Location = new System.Drawing.Point(6, 16);
            this.Timer_Interval_Disclaimer_Label.Name = "Timer_Interval_Disclaimer_Label";
            this.Timer_Interval_Disclaimer_Label.Size = new System.Drawing.Size(50, 13);
            this.Timer_Interval_Disclaimer_Label.TabIndex = 12;
            this.Timer_Interval_Disclaimer_Label.Text = "Interval";
            // 
            // Interval_Picker_For_Timer
            // 
            this.Interval_Picker_For_Timer.Location = new System.Drawing.Point(9, 32);
            this.Interval_Picker_For_Timer.Name = "Interval_Picker_For_Timer";
            this.Interval_Picker_For_Timer.Size = new System.Drawing.Size(257, 20);
            this.Interval_Picker_For_Timer.TabIndex = 10;
            this.Interval_Picker_For_Timer.ValueChanged += new System.EventHandler(this.Interval_Picker_For_Timer_ValueChanged);
            // 
            // Is_Autostart_CheckBox
            // 
            this.Is_Autostart_CheckBox.AutoSize = true;
            this.Is_Autostart_CheckBox.Location = new System.Drawing.Point(9, 69);
            this.Is_Autostart_CheckBox.Name = "Is_Autostart_CheckBox";
            this.Is_Autostart_CheckBox.Size = new System.Drawing.Size(117, 17);
            this.Is_Autostart_CheckBox.TabIndex = 0;
            this.Is_Autostart_CheckBox.Text = "Start with Windows";
            this.Is_Autostart_CheckBox.UseVisualStyleBackColor = true;
            this.Is_Autostart_CheckBox.CheckedChanged += new System.EventHandler(this.Is_Autostart_CheckBox_CheckedChanged);
            // 
            // Launch_With_Windows_Disclaimer_Label
            // 
            this.Launch_With_Windows_Disclaimer_Label.AutoSize = true;
            this.Launch_With_Windows_Disclaimer_Label.ForeColor = System.Drawing.Color.Gray;
            this.Launch_With_Windows_Disclaimer_Label.Location = new System.Drawing.Point(132, 70);
            this.Launch_With_Windows_Disclaimer_Label.Name = "Launch_With_Windows_Disclaimer_Label";
            this.Launch_With_Windows_Disclaimer_Label.Size = new System.Drawing.Size(85, 13);
            this.Launch_With_Windows_Disclaimer_Label.TabIndex = 9;
            this.Launch_With_Windows_Disclaimer_Label.Text = "(Recommended)";
            this.Launch_With_Windows_Disclaimer_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SafeToConfigBottom
            // 
            this.SafeToConfigBottom.Location = new System.Drawing.Point(119, 239);
            this.SafeToConfigBottom.Name = "SafeToConfigBottom";
            this.SafeToConfigBottom.Size = new System.Drawing.Size(272, 30);
            this.SafeToConfigBottom.TabIndex = 3;
            this.SafeToConfigBottom.Text = "#Cur_Func";
            this.SafeToConfigBottom.UseVisualStyleBackColor = true;
            this.SafeToConfigBottom.Click += new System.EventHandler(this.SafeToConfigBottom_click);
            // 
            // Disclaimer_Label_3ver
            // 
            this.Disclaimer_Label_3ver.AutoSize = true;
            this.Disclaimer_Label_3ver.Location = new System.Drawing.Point(37, 23);
            this.Disclaimer_Label_3ver.Name = "Disclaimer_Label_3ver";
            this.Disclaimer_Label_3ver.Size = new System.Drawing.Size(109, 13);
            this.Disclaimer_Label_3ver.TabIndex = 5;
            this.Disclaimer_Label_3ver.TabStop = true;
            this.Disclaimer_Label_3ver.Text = "KeepMyShit by 3VER";
            this.Disclaimer_Label_3ver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Disclaimer_Label_3ver_LinkClicked);
            // 
            // Disclaimer_Label_Github
            // 
            this.Disclaimer_Label_Github.AutoSize = true;
            this.Disclaimer_Label_Github.Location = new System.Drawing.Point(152, 23);
            this.Disclaimer_Label_Github.Name = "Disclaimer_Label_Github";
            this.Disclaimer_Label_Github.Size = new System.Drawing.Size(38, 13);
            this.Disclaimer_Label_Github.TabIndex = 6;
            this.Disclaimer_Label_Github.TabStop = true;
            this.Disclaimer_Label_Github.Text = "Github";
            this.Disclaimer_Label_Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Disclaimer_Label_Github_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(196, 23);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(33, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Icons";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // NotifyIcon_KMS
            // 
            this.NotifyIcon_KMS.BalloonTipText = "KMS will currently help you to keep your Settings";
            this.NotifyIcon_KMS.BalloonTipTitle = "KeepMyShit";
            this.NotifyIcon_KMS.ContextMenuStrip = this.Notifyicon_Context_Strip;
            this.NotifyIcon_KMS.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon_KMS.Icon")));
            this.NotifyIcon_KMS.Text = "KeepMyShit";
            this.NotifyIcon_KMS.Visible = true;
            this.NotifyIcon_KMS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Notify_Icon_Click);
            // 
            // Notifyicon_Context_Strip
            // 
            this.Notifyicon_Context_Strip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Notifyicon_Context_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitKMSToolStripMenuItem});
            this.Notifyicon_Context_Strip.Name = "Notifyicon_Context_Strip";
            this.Notifyicon_Context_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Notifyicon_Context_Strip.Size = new System.Drawing.Size(121, 26);
            // 
            // exitKMSToolStripMenuItem
            // 
            this.exitKMSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitKMSToolStripMenuItem.Image = global::KeepMyShit.Properties.Resources._028_cancel_1;
            this.exitKMSToolStripMenuItem.Name = "exitKMSToolStripMenuItem";
            this.exitKMSToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exitKMSToolStripMenuItem.Text = "Exit KMS";
            this.exitKMSToolStripMenuItem.Click += new System.EventHandler(this.exitKMSToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Keyboard Layout";
            // 
            // Keyboard_Box
            // 
            this.Keyboard_Box.Controls.Add(this.Cur_Culture_Code_Label);
            this.Keyboard_Box.Controls.Add(this.CultureCodeCB);
            this.Keyboard_Box.Controls.Add(this.Culture_Image_Box);
            this.Keyboard_Box.Controls.Add(this.label3);
            this.Keyboard_Box.Location = new System.Drawing.Point(119, 3);
            this.Keyboard_Box.Name = "Keyboard_Box";
            this.Keyboard_Box.Size = new System.Drawing.Size(272, 79);
            this.Keyboard_Box.TabIndex = 3;
            this.Keyboard_Box.TabStop = false;
            // 
            // About_Box
            // 
            this.About_Box.Controls.Add(this.Disclaimer_Label_3ver);
            this.About_Box.Controls.Add(this.Disclaimer_Label_Github);
            this.About_Box.Controls.Add(this.linkLabel1);
            this.About_Box.Location = new System.Drawing.Point(118, 180);
            this.About_Box.Name = "About_Box";
            this.About_Box.Size = new System.Drawing.Size(273, 53);
            this.About_Box.TabIndex = 3;
            this.About_Box.TabStop = false;
            // 
            // Audio_Output_Box
            // 
            this.Audio_Output_Box.Controls.Add(this.Cur_Output_Volume_Per_Label);
            this.Audio_Output_Box.Controls.Add(this.Output_Image_Box);
            this.Audio_Output_Box.Controls.Add(this.Out_Volume_Pegel_Slider);
            this.Audio_Output_Box.Location = new System.Drawing.Point(62, 3);
            this.Audio_Output_Box.Name = "Audio_Output_Box";
            this.Audio_Output_Box.Size = new System.Drawing.Size(51, 266);
            this.Audio_Output_Box.TabIndex = 2;
            this.Audio_Output_Box.TabStop = false;
            // 
            // Icon_List
            // 
            this.Icon_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icon_List.ImageStream")));
            this.Icon_List.TransparentColor = System.Drawing.Color.Transparent;
            this.Icon_List.Images.SetKeyName(0, "001-zoom.png");
            this.Icon_List.Images.SetKeyName(1, "002-users.png");
            this.Icon_List.Images.SetKeyName(2, "003-user.png");
            this.Icon_List.Images.SetKeyName(3, "004-upload.png");
            this.Icon_List.Images.SetKeyName(4, "005-opposite-arrows.png");
            this.Icon_List.Images.SetKeyName(5, "006-delete.png");
            this.Icon_List.Images.SetKeyName(6, "007-speech-bubble.png");
            this.Icon_List.Images.SetKeyName(7, "008-sound.png");
            this.Icon_List.Images.SetKeyName(8, "009-sending.png");
            this.Icon_List.Images.SetKeyName(9, "010-multimedia.png");
            this.Icon_List.Images.SetKeyName(10, "011-location-pin.png");
            this.Icon_List.Images.SetKeyName(11, "012-pencil.png");
            this.Icon_List.Images.SetKeyName(12, "013-pause.png");
            this.Icon_List.Images.SetKeyName(13, "014-message-1.png");
            this.Icon_List.Images.SetKeyName(14, "015-mute.png");
            this.Icon_List.Images.SetKeyName(15, "016-microphone.png");
            this.Icon_List.Images.SetKeyName(16, "017-menu.png");
            this.Icon_List.Images.SetKeyName(17, "018-label.png");
            this.Icon_List.Images.SetKeyName(18, "019-image.png");
            this.Icon_List.Images.SetKeyName(19, "020-home.png");
            this.Icon_List.Images.SetKeyName(20, "021-heart.png");
            this.Icon_List.Images.SetKeyName(21, "022-arrows.png");
            this.Icon_List.Images.SetKeyName(22, "023-message.png");
            this.Icon_List.Images.SetKeyName(23, "024-edit.png");
            this.Icon_List.Images.SetKeyName(24, "025-file.png");
            this.Icon_List.Images.SetKeyName(25, "026-download.png");
            this.Icon_List.Images.SetKeyName(26, "027-load.png");
            this.Icon_List.Images.SetKeyName(27, "028-cancel-1.png");
            this.Icon_List.Images.SetKeyName(28, "029-settings.png");
            this.Icon_List.Images.SetKeyName(29, "030-clock.png");
            this.Icon_List.Images.SetKeyName(30, "031-attach.png");
            this.Icon_List.Images.SetKeyName(31, "032-check.png");
            this.Icon_List.Images.SetKeyName(32, "033-cancel.png");
            this.Icon_List.Images.SetKeyName(33, "034-camera.png");
            this.Icon_List.Images.SetKeyName(34, "035-calendar.png");
            this.Icon_List.Images.SetKeyName(35, "036-add.png");
            // 
            // Log_Box
            // 
            this.Log_Box.Controls.Add(this.Log_Text_Box);
            this.Log_Box.Location = new System.Drawing.Point(12, 295);
            this.Log_Box.Name = "Log_Box";
            this.Log_Box.Size = new System.Drawing.Size(384, 84);
            this.Log_Box.TabIndex = 4;
            this.Log_Box.TabStop = false;
            this.Log_Box.Text = "Log";
            // 
            // Log_Text_Box
            // 
            this.Log_Text_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Log_Text_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log_Text_Box.Location = new System.Drawing.Point(3, 16);
            this.Log_Text_Box.Name = "Log_Text_Box";
            this.Log_Text_Box.ReadOnly = true;
            this.Log_Text_Box.Size = new System.Drawing.Size(378, 65);
            this.Log_Text_Box.TabIndex = 0;
            this.Log_Text_Box.Text = "";
            // 
            // KMSWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 276);
            this.Controls.Add(this.Log_Box);
            this.Controls.Add(this.Audio_Output_Box);
            this.Controls.Add(this.About_Box);
            this.Controls.Add(this.Keyboard_Box);
            this.Controls.Add(this.SettingsBox);
            this.Controls.Add(this.SafeToConfigBottom);
            this.Controls.Add(this.Mic_Input_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KMSWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeepMyShit";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KMS_Closing);
            this.Load += new System.EventHandler(this.KMSWindow_Load);
            this.Mic_Input_Box.ResumeLayout(false);
            this.Mic_Input_Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mic_Input_Image_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mic_Volume_Input_Pegel_Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Culture_Image_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Output_Image_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Out_Volume_Pegel_Slider)).EndInit();
            this.SettingsBox.ResumeLayout(false);
            this.SettingsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Interval_Picker_For_Timer)).EndInit();
            this.Notifyicon_Context_Strip.ResumeLayout(false);
            this.Keyboard_Box.ResumeLayout(false);
            this.Keyboard_Box.PerformLayout();
            this.About_Box.ResumeLayout(false);
            this.About_Box.PerformLayout();
            this.Audio_Output_Box.ResumeLayout(false);
            this.Audio_Output_Box.PerformLayout();
            this.Log_Box.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CultureCodeCB;
        private System.Windows.Forms.GroupBox Mic_Input_Box;
        private System.Windows.Forms.GroupBox SettingsBox;
        private System.Windows.Forms.PictureBox Mic_Input_Image_Box;
        private System.Windows.Forms.TrackBar Mic_Volume_Input_Pegel_Slider;
        private System.Windows.Forms.Label Cur_Mic_Input_Volume_Per_Label;
        private System.Windows.Forms.Label Cur_Culture_Code_Label;
        private System.Windows.Forms.PictureBox Culture_Image_Box;
        private System.Windows.Forms.Label Cur_Output_Volume_Per_Label;
        private System.Windows.Forms.PictureBox Output_Image_Box;
        private System.Windows.Forms.TrackBar Out_Volume_Pegel_Slider;
        private System.Windows.Forms.CheckBox Is_Autostart_CheckBox;
        private System.Windows.Forms.Button SafeToConfigBottom;
        private System.Windows.Forms.LinkLabel Disclaimer_Label_3ver;
        private System.Windows.Forms.LinkLabel Disclaimer_Label_Github;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label Launch_With_Windows_Disclaimer_Label;
        private System.Windows.Forms.NotifyIcon NotifyIcon_KMS;
        private System.Windows.Forms.ContextMenuStrip Notifyicon_Context_Strip;
        private System.Windows.Forms.ToolStripMenuItem exitKMSToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Keyboard_Box;
        private System.Windows.Forms.GroupBox About_Box;
        private System.Windows.Forms.GroupBox Audio_Output_Box;
        private System.Windows.Forms.ImageList Icon_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Interval_Disclaimer_Label;
        private System.Windows.Forms.Label Timer_Interval_Disclaimer_Label;
        private System.Windows.Forms.NumericUpDown Interval_Picker_For_Timer;
        private System.Windows.Forms.GroupBox Log_Box;
        private System.Windows.Forms.RichTextBox Log_Text_Box;
    }
}

