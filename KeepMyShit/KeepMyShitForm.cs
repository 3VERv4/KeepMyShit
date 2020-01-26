using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Timers;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using AudioSwitcher.AudioApi.CoreAudio;
using Microsoft.Win32;
using NAudio.Mixer;

namespace KeepMyShit
{    public partial class KMSWindow : Form
    {

        #region Imports

        [DllImport("user32.dll")]
        private static extern bool PostMessage(int hhwnd, uint msg, IntPtr wparam, IntPtr lparam);

        [DllImport("user32.dll")]
        private static extern IntPtr LoadKeyboardLayout(string pwszKLID, uint Flags);

        #endregion

        #region Strings

        
        private static string InUseCC;

        private static string InUseCCHex;

        //Ground Path where the Config file will be storaged
        string AppDataFolde = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        #endregion

        #region Integer

        //The current in use Mic Volume
        int InUseMV;

        //The current in use Output Volume
        int InUseOV;

        //The current interval in milisec of a the main timer
        int InUseTI;

        private static int HWND_BROADCAST = 0xffff;


        #endregion

        #region Uint

        private static uint WM_INPUTLANGCHANGEREQUEST = 0x0050;

        private static uint KLF_ACTIVATE = 1;

        #endregion

        #region Booleans

        //Checkbox bool if Autostart is enabled
        bool LaunchWithWindows;

        #endregion

        ////////////////////////////////////////////////////////////////
        //------------------------------------------------------------//
        ////////////////////////////////////////////////////////////////

        #region Dictonaries

        //Dictonary for Config Files
        Dictionary<string, string> KeepSettings = new Dictionary<string, string>();

        #endregion

        #region Elements

        System.Timers.Timer CheckTimerAndFireFunc = new System.Timers.Timer();

        CoreAudioDevice Main_Output_Audio_Deveic;

        UnsignedMixerControl Mic_Input_Volume_Control;

        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        #endregion

        ////////////////////////////////////////////////////////////////
        //------------------------------------------------------------//
        ////////////////////////////////////////////////////////////////

        #region Initialize
        public KMSWindow()
        {
            InitializeComponent();
            CheckConfigAviableAndLoadOrCreate();

            try {
                Main_Output_Audio_Deveic = new CoreAudioController().DefaultPlaybackDevice;
            }
            catch (IOException es)
            {
                Log_Text_Box.AppendText(es + Environment.NewLine);
            }

            try 
            {
                Main_Output_Audio_Deveic = new CoreAudioController().DefaultPlaybackDevice;
            }
                catch (IOException es)
                {
                    Log_Text_Box.AppendText(es + Environment.NewLine);
                }

            }

        private void KMSWindow_Load(object sender, EventArgs e)
        {
            SafeToConfigBottom.Text = "Safe to Config";
        }

        void LoadConfigFile()
        {
            var LoadMySettings = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(File.ReadAllText(AppDataFolde + @"\KeepMySettings.cfg"));

            InUseMV = String2Integer(LoadMySettings["Input_Volume"]);

            InUseOV = String2Integer(LoadMySettings["Output_Volume"]);

            InUseTI = String2Integer(LoadMySettings["Check_Interval"]);

            InUseCC = LoadMySettings["Keyboard_Prefix"];

            int autostartint = String2Integer(LoadMySettings["Autostart"]);
            if (autostartint == 1) { LaunchWithWindows = true; }

            SetUpConfig();
        }

    
        void SetUpConfig()
        {

            if (LaunchWithWindows)
            {
                this.Top += 5000;
            }

            Is_Autostart_CheckBox.Checked = LaunchWithWindows;
            Mic_Volume_Input_Pegel_Slider.Value = InUseMV;
            Out_Volume_Pegel_Slider.Value = InUseOV;
            Interval_Picker_For_Timer.Value = InUseTI;
            CultureCodeCB.Text = InUseCC;
            InitTimer(InUseTI);

            Cur_Culture_Code_Label.Text = CultureCodeCB.Text + " is set as Keyboard Language";
            Cur_Output_Volume_Per_Label.Text = InUseOV.ToString() + "%";
            Cur_Mic_Input_Volume_Per_Label.Text = InUseMV.ToString() + "%";

            CheckTimerAndFireFunc.Start();
            
        }

        void InitTimer(int interval)
        {
            CheckTimerAndFireFunc.Elapsed += new ElapsedEventHandler(TimerCheckAndFireAsync);
            CheckTimerAndFireFunc.Interval = interval;
        }
        #endregion

        ////////////////////////////////////////////////////////////////
        //------------------------------------------------------------//
        ////////////////////////////////////////////////////////////////

        #region Handler

        void TimerCheckAndFireAsync(object source, ElapsedEventArgs e)
        {

     
                    if (GetMicInputVolume() != InUseMV)
                    {
                        SetMicInputVolume(InUseMV);
                    }
           


       
                    if (Main_Output_Audio_Deveic.Volume != InUseOV)
                    {

                        Main_Output_Audio_Deveic.Volume = InUseOV;
                    }
         
           


        
                    if (InUseTI != Interval_Picker_For_Timer.Value)
                    {
                        Timer_Reinterval(InUseTI);
                    }
        

                    KeepWantedLanguage();

        }

        private void SafeToConfigBottom_click(object sender, EventArgs e)
        {
            UpdateConfif();
        }

        private void Interval_Picker_For_Timer_ValueChanged(object sender, EventArgs e)
        {
            InUseTI = String2Integer(Interval_Picker_For_Timer.Value.ToString());
        }

        private void Disclaimer_Label_Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/3VERv4/KeepMyShit");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.flaticon.com/packs/essentials-botton");
        }

        private void Disclaimer_Label_3ver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://steamcommunity.com/id/3ver/");
        }

        private void Is_Autostart_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Is_Autostart_CheckBox.Checked)
            {
                registryKey.SetValue("KeepMyShit", Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue("KeepMyShit");
            }
        }

        private void KMS_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Top += 5000;
                NotifyIcon_KMS.Visible = true;
            
            }
        }

        private void Notify_Icon_Click(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {

                this.Top += 5000;

            }
            else { this.Top -= 5000; }
        }

        private void exitKMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CultureCodeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cur_Culture_Code_Label.Text = CultureCodeCB.Text + " is set as Keyboard Language";
            InUseCCHex = GetKeyboardHexByName(CultureCodeCB.Text);
            InUseCC = CultureCodeCB.Text;
        }

        private void Mic_Volume_Input_Slider_Changed(object sender, EventArgs e)
        {
            Cur_Mic_Input_Volume_Per_Label.Text = Mic_Volume_Input_Pegel_Slider.Value.ToString() + "%";
            InUseMV = Mic_Volume_Input_Pegel_Slider.Value;
        }

        private void Out_Volume_Slider_Changed(object sender, EventArgs e)
        {
            Cur_Output_Volume_Per_Label.Text = Out_Volume_Pegel_Slider.Value.ToString() + "%";
            InUseOV = Out_Volume_Pegel_Slider.Value;
        }

        #endregion

        ////////////////////////////////////////////////////////////////
        //------------------------------------------------------------//
        ////////////////////////////////////////////////////////////////

        #region Voids

        void UpdateConfif()
        {

            KeepSettings["Input_Volume"] = InUseMV.ToString();
            KeepSettings["Output_Volume"] = InUseOV.ToString();
            KeepSettings["Keyboard_Prefix"] = InUseCC.ToString();
            KeepSettings["Check_Interval"] = InUseTI.ToString();

            if (Is_Autostart_CheckBox.Checked)
            {
                KeepSettings["Autostart"] = "1";
            }
            else
            {
                KeepSettings["Autostart"] = "0";
            }

            File.WriteAllText(AppDataFolde + @"\KeepMySettings.cfg", new JavaScriptSerializer().Serialize(KeepSettings));

            MessageBox.Show("Configuration changes have been saved successfully");

        }

        private static void KeepWantedLanguage()
        {
            PostMessage(HWND_BROADCAST, WM_INPUTLANGCHANGEREQUEST, IntPtr.Zero, LoadKeyboardLayout(InUseCCHex, KLF_ACTIVATE));
        }

        void Timer_Reinterval(int interval)
        {
            CheckTimerAndFireFunc.Stop();
            CheckTimerAndFireFunc.Interval = interval;
            CheckTimerAndFireFunc.Start();
        }
     
        void GenerateFirstConfigFile()
        {
            KeepSettings.Add("Input_Volume", "70");
            KeepSettings.Add("Output_Volume", "70");
            KeepSettings.Add("Keyboard_Prefix", "United States");
            KeepSettings.Add("Check_Interval", "100");
            KeepSettings.Add("Autostart", "1");
            KeepSettings.Add("Notify_Icon", "true");
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"KeepMySettings.cfg");
            File.WriteAllText(AppDataFolde + @"\KeepMySettings.cfg", new JavaScriptSerializer().Serialize(KeepSettings));
        }

        void SetMicInputVolume(int input_vol)
        {
            int waveInDeviceNumber = 0;
            var mixerLine = new MixerLine((IntPtr)waveInDeviceNumber, 0, MixerFlags.WaveIn);

            foreach (var control in mixerLine.Controls)
            {
                if (control.ControlType == MixerControlType.Volume)
                {
                    Mic_Input_Volume_Control = control as UnsignedMixerControl;
                    Mic_Input_Volume_Control.Percent = input_vol;
                }
            }
        }

        void CheckConfigAviableAndLoadOrCreate()
        {

            if (File.Exists(AppDataFolde + @"\KeepMySettings.cfg"))
            {
                LoadConfigFile();
            }
            else
            {
                GenerateFirstConfigFile();
            }

        }


        #endregion

        #region Int func

        public int String2Integer(string value)
        {

            string intString = value;
            if (!Int32.TryParse(intString, out int i))
            {
                i = -1;
            }
            return i;

        }

        public int GetMicInputVolume()
        {
            int waveInDeviceNumber = 0;
            var mixerLine = new MixerLine((IntPtr)waveInDeviceNumber, 0, MixerFlags.WaveIn);

            foreach (var control in mixerLine.Controls)
            {
                if (control.ControlType == MixerControlType.Volume)
                {
                    Mic_Input_Volume_Control = control as UnsignedMixerControl;
                    return Convert.ToInt16(Mic_Input_Volume_Control.Percent);
                }
            }

            return 50;

        }

        #endregion

        #region String func
        String GetKeyboardHexByName(string code)
        {
    
            switch (code)
            {
                case "Albanian":
                    return "0000041C";
                case "Arabic (101)":
                    return "00000401";
                case "Arabic (102)":
                    return "00010401";
                case "Arabic (102) Azerty":
                    return "00020401";
                case "Armenian eastern":
                    return "0000042B";
                case "Armenian Western":
                    return "0001042B";
                case "Assamese - inscript":
                    return "0000044D";
                case "Azeri Cyrillic":
                    return "0000082C";
                case "Azeri Latin":
                    return "0000042C";
                case "Bashkir":
                    return "0000046D";
                case "Belarusian":
                    return "00000423";
                case "Belgian French":
                    return "0000080C";
                case "Belgian (period)":
                    return "00000813";
                case "Belgian (comma)":
                    return "0001080C";
                case "Bengali":
                    return "00000445";
                case "Bengali - inscript (legacy)":
                    return "00010445";
                case "Bengali - inscript":
                    return "00020445";
                case "Bosnian (cyrillic)":
                    return "0000201A";
                case "Bulgarian":
                    return "00030402";
                case "Bulgarian(typewriter)":
                    return "00000402";
                case "Bulgarian (latin)":
                    return "00010402";
                case "Bulgarian (phonetic)":
                    return "00020402"; 
                case "Bulgarian (phonetic traditional)":
                    return "00040402"; 
                case "Canada Multilingual":
                    return "00011009";
                case "Canada French":
                    return "00001009";
                case "Canada French (legacy)":
                    return "00000C0C";
                case "Chinese (traditional) - us keyboard":
                    return "00000404";
                case "Chinese (simplified) -us keyboard":
                    return "00000804";
                case "Chinese (traditional, hong kong s.a.r.) - us keyboard":
                    return "00000C04";
                case "Chinese (simplified, singapore) - us keyboard":
                    return "00001004";
                case "Chinese (traditional, macao s.a.r.) - us keyboard":
                    return "00001404";
                case "Czech":
                    return "00000405";
                case "Czech programmers":
                    return "00020405"; 
                case "Czech (qwerty)":
                    return "00010405";
                case "Croatian":
                    return "0000041A";
                case "Deanagari - inscript":
                    return "00000439";
                case "Danish":
                    return "00000406";
                case "Divehi phonetic":
                    return "00000465";
                case "Divehi typewriter":
                    return "00010465";
                case "Dutch":
                    return "00000413";
                case "Estonian":
                    return "00000425";
                case "Faeroese":
                    return "00000438";
                case "Finnish":
                    return "0000040B";
                case "Finnish with sami":
                    return "0001083B";
                case "French":
                    return "0000040C";
                case "Gaelic":
                    return "00011809";
                case "Georgian":
                    return "00000437";
                case "Georgian (ergonomic)":
                    return "00020437";
                case "Georgian (qwerty)":
                    return "00010437";
                case "German":
                    return "00000407";
                case "German (ibm)":
                    return "00010407";
                case "Greenlandic":
                    return "0000046F";
                case "Hausa":
                    return "00000468";
                case "Hebrew":
                    return "0000040D";
                case "Hindi traditional":
                    return "00010439";
                case "Greek":
                    return "00000408";
                case "Greek (220)":
                    return "00010408";
                case "Greek (220) latin":
                    return "00030408";
                case "Greek (319)":
                    return "00020408";
                case "Greek (319) latin":
                    return "00040408";
                case "Greek latin":
                    return "00050408";
                case "Greek polyonic":
                    return "00060408";
                case "Gujarati":
                    return "00000447";
                case "Hungarian":
                    return "0000040E";
                case "Hungarian 101 key":
                    return "0001040E";
                case "Icelandic":
                    return "0000040F";
                case "Igbo":
                    return "00000470";
                case "Inuktitut - latin":
                    return "0000085D";
                case "Inuktitut - naqittaut":
                    return "0001045D";
                case "Irish":
                    return "00001809";
                case "Italian":
                    return "00000410";
                case "Italian (142)":
                    return "00010410";
                case "Japanese":
                    return "00000411";
                case "Kannada":
                    return "0000044B";
                case "Kazakh":
                    return "0000043F";
                case "Khmer":
                    return "00000453";
                case "Korean":
                    return "00000412";
                case "Kyrgyz cyrillic":
                    return "00000440";
                case "Lao":
                    return "00000454";
                case "Latin america":
                    return "0000080A";
                case "Latvian":
                    return "00000426";
                case "Latvian (qwerty)":
                    return "00010426";
                case "Lithuanian":
                    return "00010427";
                case "Lithuanian ibm":
                    return "00000427";
                case "Lithuanian standard":
                    return "00020427";
                case "Luxembourgish":
                    return "0000046E";
                case "Macedonian (fyrom)":
                    return "0000042F";
                case "Macedonian (fyrom) - standard":
                    return "0001042F";
                case "Malayalam":
                    return "0000044C";
                case "Maltese 47-key":
                    return "0000043A";
                case "Maltese 48-key":
                    return "0001043A";
                case "Marathi":
                    return "0000044E";
                case "Maroi":
                    return "00000481";
                case "Mongolian cyrillic":
                    return "00000450";
                case "Mongolian (mongolian script)":
                    return "00000850";
                case "Nepali":
                    return "00000461";
                case "Norwegian":
                    return "00000414";
                case "Norwegian with sami":
                    return "0000043B";
                case "Oriya":
                    return "00000448";
                case "Pashto (afghanistan)":
                    return "00000463";
                case "Persian":
                    return "00000429";
                case "Polish (programmers)":
                    return "00000415";
                case "Polish (214)":
                    return "00010415";
                case "Portuguese":
                    return "00000816";
                case "Portuguese (brazillian abnt)":
                    return "00000416";
                case "Portuguese (brazillian abnt2)":
                    return "00010416";
                case "Punjabi":
                    return "00000446";
                case "Romanian (standard)":
                    return "00010418";
                case "Romanian (legacy)":
                    return "00000418";
                case "Romanian (programmers)":
                    return "00020418";
                case "Russian":
                    return "00000419";
                case "Russian (typewriter)":
                    return "00010419";
                case "Sami extended finland-sweden":
                    return "0002083B";
                case "Sami extended norway":
                    return "0001043B";
                case "Serbian (cyrillic)":
                    return "00000C1A";
                case "Serbian (latin)":
                    return "0000081A";
                case "Sesotho sa Leboa":
                    return "0000046C";
                case "Setswana":
                    return "00000432";
                case "Sinhala":
                    return "0000045B";
                case "Sinhala -Wij 9":
                    return "0001045B";
                case "Slovak":
                    return "0000041B";
                case "Slovak (qwerty)":
                    return "0001041B";
                case "Slovenian":
                    return "00000424";
                case "Sorbian extended":
                    return "0001042E";
                case "Sorbian standard":
                    return "0002042E";
                case "Sorbian standard (legacy)":
                    return "0000042E";
                case "Spanish":
                    return "0000040A";
                case "Spanish variation":
                    return "0001040A";
                case "Swedish":
                    return "0000041D";
                case "Swedish with sami":
                    return "0000083B";
                case "Swiss german":
                    return "00000807";
                case "Swiss french":
                    return "0000100C";
                case "Syriac":
                    return "0000045A";
                case "Syriac phonetic":
                    return "0001045A";
                case "Tajik":
                    return "00000428";
                case "Tamil":
                    return "00000449";
                case "Tatar":
                    return "00000444";
                case "Telugu":
                    return "0000044A";
                case "Thai Kedmanee":
                    return "0000041E";
                case "Thai Kedmanee (non-shiftlock)":
                    return "0002041E";
                case "Thai Pattachote":
                    return "0001041E";
                case "Thai Pattachote (non-shiftlock)":
                    return "0003041E";
                case "Tibetan (prc)":
                    return "00000451";
                case "Turkish F":
                    return "0001041F";
                case "Turkish Q":
                    return "0000041F";
                case "Turkmen":
                    return "00000442";
                case "Ukrainian":
                    return "00000422";
                case "Ukrainian (enhanced)":
                    return "00020422";
                case "United Kingdom":
                    return "00000809";
                case "United Kingdom Extended":
                    return "00000452";
                case "United States":
                    return "00000409";
                case "United States - dvorak left hand":
                    return "00010409";
                case "United States - dvorak right hand":
                    return "00050409";
                case "United States - india":
                    return "00004009";
                case "United States - international":
                    return "00020409";
                case "Urdu":
                    return "00000420";
                case "Uyghur":
                    return "00010480";
                case "Uyghur (legacy)":
                    return "00000480";
                case "Uzbek cyrillic":
                    return "00000843";
                case "Vietnamese":
                    return "0000042A";
                case "Yakut":
                    return "00000485";
                case "Yoruba":
                    return "0000046A";
                case "Wolof":
                    return "00000488";
                default: return "unknown";

            }
        }
        #endregion

    }
}
