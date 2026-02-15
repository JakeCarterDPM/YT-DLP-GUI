namespace MediaDownloader
{
    using System;
    using System.Diagnostics;
    using System.Windows.Forms;

    public partial class FormOptions : Form
    {
        private readonly FormMain _formMain;

        #region Form Open/Close Events
        public FormOptions(FormMain formMain)
        {
            InitializeComponent();
            _formMain = formMain;
        }
        private void FormOptions_Load(object sender, EventArgs e)
        {
            // Get settings and apply defaults if necessary
            // Directory Text Boxes
            Properties.Settings.Default.VideoOutDir = EnsureDefaultDir(Properties.Settings.Default.VideoOutDir);
            Properties.Settings.Default.AudioOutDir = EnsureDefaultDir(Properties.Settings.Default.AudioOutDir);
            Properties.Settings.Default.ThumbOutDir = EnsureDefaultDir(Properties.Settings.Default.ThumbOutDir);
            // Directory - cookies.txt
            if(string.IsNullOrWhiteSpace(Properties.Settings.Default.CookiesDir))
            {
                Properties.Settings.Default.CookiesDir = Path.Combine(
                    Application.StartupPath,
                    "cookies.txt"
                );
            }
            //YT-DLP 
            if(string.IsNullOrWhiteSpace(Properties.Settings.Default.YTDLPDir))
            {
                string? foundPath = GetFullPathFromPath("yt-dlp.exe");

                Properties.Settings.Default.YTDLPDir =
                    !string.IsNullOrEmpty(foundPath)
                    ? foundPath
                    : Path.Combine(Application.StartupPath, "yt-dlp.exe");
            }

            // FFMPEG
            if(string.IsNullOrWhiteSpace(Properties.Settings.Default.FFMPEGDir))
            {
                string? foundPath = GetFullPathFromPath("ffmpeg.exe");

                if(!string.IsNullOrEmpty(foundPath))
                {
                    Properties.Settings.Default.FFMPEGDir = foundPath;
                }
                else
                {
                    string ffmpegFolder = Path.Combine(Application.StartupPath, "FFMPEG");

                    if(!Directory.Exists(ffmpegFolder))
                        Directory.CreateDirectory(ffmpegFolder);

                    Properties.Settings.Default.FFMPEGDir = ffmpegFolder;
                }
            }

            // Save any changes to settings
            Properties.Settings.Default.Save();

            // Update UI with loaded settings
            textBoxVideoDir.Text = Properties.Settings.Default.VideoOutDir;
            textBoxAudioDir.Text = Properties.Settings.Default.AudioOutDir;
            textBoxThumbnailDir.Text = Properties.Settings.Default.ThumbOutDir;
            textBoxCookieDir.Text = Properties.Settings.Default.CookiesDir;
            textBoxYTDLPDir.Text = Properties.Settings.Default.YTDLPDir;
            textBoxFFMPEGDir.Text = Properties.Settings.Default.FFMPEGDir;

            // Dropdown list for JSRuntime
            comboBoxJSRuntime.DataSource = Enum.GetValues(typeof(JSRuntime));
            int savedValue = Properties.Settings.Default.JSRuntime;
            JSRuntime runtime = Enum.IsDefined(typeof(JSRuntime), savedValue) ? (JSRuntime)savedValue : JSRuntime.Deno;
            comboBoxJSRuntime.SelectedItem = runtime;

        }
        private static string EnsureDefaultDir(string settingValue)
        {
            return string.IsNullOrWhiteSpace(settingValue)
                ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "Downloads") : settingValue;
        }
        private static string? GetFullPathFromPath(string exeName)
        {
            string? pathEnv = Environment.GetEnvironmentVariable("PATH");
            if(string.IsNullOrWhiteSpace(pathEnv))
                return null;

            string[] paths = pathEnv.Split(';');

            foreach(string path in paths)
            {
                try
                {
                    string fullPath = Path.Combine(path.Trim(), exeName);
                    if(File.Exists(fullPath))
                        return fullPath;
                }
                catch { }
            }

            return null;
        }
        private void FormOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.VideoOutDir = textBoxVideoDir.Text;
            Properties.Settings.Default.Save();
        }
        #endregion

        #region Default Directory Settings
        //Video
        private void ButtonSetVideoDir_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderDialog = new();
            folderDialog.Description = "Select video output folder";

            if(folderDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxVideoDir.Text = folderDialog.SelectedPath;
            }
        }
        private void TextBoxVideoDir_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.VideoOutDir = textBoxVideoDir.Text;
            Properties.Settings.Default.Save();
        }

        //Audio
        private void ButtonSetAudioDir_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderDialog = new();
            folderDialog.Description = "Select audio output folder";

            if(folderDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxVideoDir.Text = folderDialog.SelectedPath;
            }
        }
        private void TextBoxAudioDir_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AudioOutDir = textBoxAudioDir.Text;
            Properties.Settings.Default.Save();
        }

        //Thumbnail
        private void ButtonSetThumbnailDir_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderDialog = new();
            folderDialog.Description = "Select thumbnail output folder";

            if(folderDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxThumbnailDir.Text = folderDialog.SelectedPath;
            }
        }
        private void TextBoxThumbnailDir_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ThumbOutDir = textBoxThumbnailDir.Text;
            Properties.Settings.Default.Save();
        }

        //Cookies.txt
        private void ButtonSetCookieDir_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new();
            dialog.Filter = "Text Document (*.txt)|*.txt";
            dialog.Title = "Select cookies.txt";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxCookieDir.Text = dialog.FileName;
                Properties.Settings.Default.CookiesDir = dialog.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void TextBoxCookieDir_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CookiesDir = textBoxCookieDir.Text;
            Properties.Settings.Default.Save();
        }
        #endregion

        #region YT-DLP Settings
        private void ButtonYTDLPDir_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new();
            dialog.Filter = "Executable (*.exe)|*.exe";
            dialog.Title = "Select yt-dlp executable";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxYTDLPDir.Text = dialog.FileName;
                Properties.Settings.Default.YTDLPDir = dialog.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private async void ButtonUpdateYTDLP_Click(object sender, EventArgs e)
        {
            try
            {
                buttonUpdateYTDLP.Enabled = false;

                Process proc = MediaDownloader.YTDPLHandler
                    .SendCMDToYTDLP("-U", _formMain.AppendLog);

                await Task.Run(() => proc.WaitForExit());

                _formMain.AppendLog("Update finished.");
            }
            catch(Exception ex)
            {
                _formMain.AppendLog("Update failed: " + ex.Message);
            }
            finally
            {
                buttonUpdateYTDLP.Enabled = true;
            }
        }
        #endregion

        #region External Tools Settings
        private void ButtonFFMPEGDir_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog dialog = new();
            dialog.Description = "Select FFMPEG folder";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFFMPEGDir.Text = dialog.SelectedPath;
                Properties.Settings.Default.FFMPEGDir = dialog.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }
        private void ComboBoxJSRuntime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxJSRuntime.SelectedItem is JSRuntime selectedRuntime)
            {
                Properties.Settings.Default.JSRuntime = (int)selectedRuntime;
                Properties.Settings.Default.Save();
            }
        }
        #endregion

        #region Reset to Default
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ResetSettingsToDefault();
        }
        private void ResetSettingsToDefault()
        {
            // Directory Text Boxes
            Properties.Settings.Default.VideoOutDir = EnsureDefaultDir(string.Empty);
            Properties.Settings.Default.AudioOutDir = EnsureDefaultDir(string.Empty);
            Properties.Settings.Default.ThumbOutDir = EnsureDefaultDir(string.Empty);

            // Directory - cookies.txt
            Properties.Settings.Default.CookiesDir = Path.Combine(
                Application.StartupPath,
                "cookies.txt"
            );

            // YT-DLP
            string? ytdlpPath = GetFullPathFromPath("yt-dlp.exe");
            Properties.Settings.Default.YTDLPDir =
                !string.IsNullOrEmpty(ytdlpPath)
                ? ytdlpPath
                : Path.Combine(Application.StartupPath, "yt-dlp.exe");

            // FFMPEG
            string? ffmpegPath = GetFullPathFromPath("ffmpeg.exe");
            if(!string.IsNullOrEmpty(ffmpegPath))
            {
                Properties.Settings.Default.FFMPEGDir = ffmpegPath;
            }
            else
            {
                string ffmpegFolder = Path.Combine(Application.StartupPath, "FFMPEG");
                if(!Directory.Exists(ffmpegFolder))
                    Directory.CreateDirectory(ffmpegFolder);

                Properties.Settings.Default.FFMPEGDir = ffmpegFolder;
            }

            // JSRuntime default (optional: choose your default enum value)
            Properties.Settings.Default.JSRuntime = (int)JSRuntime.Node;

            // Save changes
            Properties.Settings.Default.Save();

            // Update UI
            textBoxVideoDir.Text = Properties.Settings.Default.VideoOutDir;
            textBoxAudioDir.Text = Properties.Settings.Default.AudioOutDir;
            textBoxThumbnailDir.Text = Properties.Settings.Default.ThumbOutDir;
            textBoxCookieDir.Text = Properties.Settings.Default.CookiesDir;
            textBoxYTDLPDir.Text = Properties.Settings.Default.YTDLPDir;
            textBoxFFMPEGDir.Text = Properties.Settings.Default.FFMPEGDir;
            comboBoxJSRuntime.DataSource = Enum.GetValues(typeof(JSRuntime));
            comboBoxJSRuntime.SelectedIndex = Properties.Settings.Default.JSRuntime;
        }
        #endregion
    }
}
