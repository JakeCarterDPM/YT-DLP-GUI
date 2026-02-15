namespace MediaDownloader
{
    using MediaDownloader.Properties;
    using System.Diagnostics;

    public partial class FormMain : Form
    {
        #region Initialization
        private const int consoleMaxLines = 100;

        public FormMain()
        {
            InitializeComponent();
            richTextBoxLog.Clear();
            AppendLog($"Welcome to Media Downloader! Version {Application.ProductVersion}.");
        }
        #endregion

        #region MenuStrip Event Handlers
        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using FormOptions optionsForm = new(this);
            optionsForm.ShowDialog();
        }
        private void CreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Jake Carter", "Credits");
        }
        #endregion

        #region Tab Events
        private void TabBtnVideo_Click(object sender, EventArgs e)
        {
            tabDownloadType.SelectedTab = pageVideo;
        }
        private void TabBtnAudio_Click(object sender, EventArgs e)
        {
            tabDownloadType.SelectedTab = pageAudio;
        }
        private void TabBtnThumbnail_Click(object sender, EventArgs e)
        {
            tabDownloadType.SelectedTab = pageThumbnail;
        }
        #endregion

        #region Download Logic
        private void PasteAndDownloadButton_Click(object sender, EventArgs e)
        {
            // Check if there is text in the clipboard
            if(Clipboard.ContainsText())
            {
                textBoxURL.Text = Clipboard.GetText();
                StartDownloadButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Clipboard does not contain any text.");
            }
        }

        private void StartDownloadButton_Click(object sender, EventArgs e)
        {
            //Ensure URL is not empty.
            string url = textBoxURL.Text.Trim();
            if(string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please enter a URL.");
                return;
            }

            string baseArgs =
                "--embed-metadata " +
                "--restrict-filenames " +
                "--windows-filenames " +
                "--no-overwrites " +
                "--trim-filenames 200 " +
                "--no-mtime " +
                "--ignore-errors";

            string urlPlusArgs = $"{url} {baseArgs}";
            Debug.WriteLine($"Staring a base Argument with: {urlPlusArgs}");

            //Args that should be default.
            //"--embed-metadata"        - Embed metadata in the file (e.g. title, artist, album, etc.)
            //"--restrict-filenames"    - Restrict filenames to only ASCII characters, and avoid "&" and spaces in filenames
            //"--windows-filenames"     - Forces window-compatible filenames.
            //"--no-overwrites"         - Don't redownload files. duh.
            //"--trim-filenames 200"    - Ensures filename is not too long for windows.
            //"--no-mtime"              - doesn't set file modified time to upload date. Easier to find latest download.
            //"--ignore-errors"         - Continue on download errors, for example to skip unavailable videos in a playlist.

            //Not adding this to base args as each option has a different use case.
            //"-o "DIRHERE\%(title)s.%(ext)s""  - sets the output of the file to title.extension in the specified directory.

            //Video tab is active.
            if(tabDownloadType.SelectedTab == pageVideo)
            {
                //If Instragram, prefer unknown format to avoid artifacting.
                if(url.Contains("instagram.com"))
                {
                    // Prefer unknown format for instagram.com urls. ("-f bestvideo[vcodec=unknown]+bestaudio/best[vcodec=unknown]/best")
                    urlPlusArgs += " -f bestvideo[vcodec=unknown]+bestaudio/best[vcodec=unknown]/best";
                }

                //Fix naming convention for facebook and instagram URLS.
                if(url.Contains("facebook.com") || url.Contains("instagram.com"))
                {
                    urlPlusArgs += $" -o \"{Settings.Default.VideoOutDir}\\%(uploader)s_%(upload_date)s_%(id)s.%(ext)s\"";
                }
                else
                {
                    urlPlusArgs += $" -o \"{Settings.Default.VideoOutDir}\\%(title)s.%(ext)s\"";
                }
            }

            // Audio tab is active
            else if(tabDownloadType.SelectedTab == pageAudio)
            {
                //Embed thumbnail.
                urlPlusArgs += " --embed-thumbnail";

                //Soundcloud best qaulity format.
                if(url.Contains("soundcloud.com"))
                {
                    urlPlusArgs += " -f \"bestaudio[ext=flac]/bestaudio[ext=wav]/bestaudio[ext=mp3]/bestaudio\"";
                }

                //YouTube Music remux to opus for best quality and better compatibility.
                if(url.Contains("music.youtube.com"))
                {
                    urlPlusArgs += " --remux-video opus";
                    urlPlusArgs += " -f \"bestaudio\"";
                }

                //Audio Out Directory.
                urlPlusArgs += $" -o \"{Settings.Default.AudioOutDir}\\%(artist)s - %(title)s.%(ext)s\"";
            }

            //Thumbnail.
            else if(tabDownloadType.SelectedTab == pageThumbnail)
            {
                //Only get thumbnail.
                urlPlusArgs += " --skip-download --write-thumbnail";

                //Thumbnail directory.
                urlPlusArgs += $" -o \"{Settings.Default.ThumbOutDir}\\%(artist)s - %(title)s.%(ext)s\"";
            }

            //Apply Cookies
            urlPlusArgs += $" --cookies {Settings.Default.CookiesDir}";

            // Apply JS Runtime
            JSRuntime runtime = (JSRuntime)Convert.ToInt32(Settings.Default.JSRuntime);

            // Apply JS Runtime
            switch(runtime)
            {
                case JSRuntime.Deno:
                    // Default, no args
                    break;

                case JSRuntime.Node:
                    urlPlusArgs += " --js-runtimes node";
                    break;

                case JSRuntime.Bun:
                    urlPlusArgs += " --js-runtimes bun";
                    break;

                case JSRuntime.QuickJS:
                    urlPlusArgs += " --js-runtimes quickjs";
                    break;
            }

            AppendLog($"-------------------------------------------------------------------------");
            AppendLog($"Sending CMD: {urlPlusArgs}");
            YTDPLHandler.SendCMDToYTDLP(urlPlusArgs, AppendLog);
        }

        #endregion

        #region Misc UI
        private void TextBoxURL_MouseUp(object sender, EventArgs e)
        {
            textBoxURL.SelectAll();

        }

        private void ButtonPasteURL_Click(object sender, EventArgs e)
        {
            // Check if there is text in the clipboard
            if(Clipboard.ContainsText())
            {
                textBoxURL.Text = Clipboard.GetText();
                textBoxURL.Focus();          // Optional: move focus to the TextBox
                textBoxURL.SelectAll();      // Optional: select all text
            }
        }

        public void AppendLog(string text)
        {
            if(richTextBoxLog.InvokeRequired)
            {
                richTextBoxLog.Invoke(new Action<string>(AppendLog), text);
                return;
            }

            // Append the new line
            richTextBoxLog.AppendText(text + Environment.NewLine);

            // Enforce max line count
            if(richTextBoxLog.Lines.Length > consoleMaxLines)
            {
                string[] lines = richTextBoxLog.Lines;
                int removeCount = lines.Length - consoleMaxLines;
                richTextBoxLog.Lines = lines.Skip(removeCount).ToArray();
            }

            // Scroll to bottom
            richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
            richTextBoxLog.SelectionLength = 0;
            richTextBoxLog.ScrollToCaret();
        }

        #endregion
    }
}