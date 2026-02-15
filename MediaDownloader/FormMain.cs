namespace MediaDownloader
{
    using System.Diagnostics;

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        #region Menu strip event handlers
        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using FormOptions optionsForm = new();
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
        private void StartDownloadButton_Click(object sender, EventArgs e)
        {
            //Ensure URL is not empty.
            string url = textBoxURL.Text.Trim();
            if(string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please enter a URL.");
                return;
            }

            //Args that should be default.
            //"--embed-metadata"        - Embed metadata in the file (e.g. title, artist, album, etc.)
            //"--restrict-filenames"    - Restrict filenames to only ASCII characters, and avoid "&" and spaces in filenames
            //"--windows-filenames"     - Forces window-compatible filenames.
            //"--no-overwrites"         - Don't redownload files. duh.
            //"--trim-filenames 200"    - Ensures filename is not too long for windows.
            // --no-mtime               - doesn't set file modified time to upload date. Easier to find latest download.
            // --ignore-errors           - Continue on download errors, for example to skip unavailable videos in a playlist.

            //Format based on tab type here.
            if(tabDownloadType.SelectedTab == pageVideo)
            {
                // Video tab is active
                //To Do:
                // - Prefer unknown format for instagram.com urls. ("-f bestvideo[vcodec=unknown]+bestaudio/best[vcodec=unknown]/best")
                // Cause it avoids meta's artifacting.

                // - on either instagram.com or facebook.com urls, set output name to ("-o DIRHERE\%(uploader)s_%(upload_date)s_%(title)s.%(ext)s")
                // Cause it defaults to "video by uploader". so this allows multiple videos from same uploader.
            }
            else if(tabDownloadType.SelectedTab == pageAudio)
            {
                // Audio tab is active
                // - 

            }
            else if(tabDownloadType.SelectedTab == pageThumbnail)
            {
                // Thumbnail tab is active

            }

            //After formatting arguments, send to yt-dlp

            // Build yt-dlp arguments and send to YTDLPHandler.
            string arguments = $"{url} --no-playlist -o \"%(title)s.%(ext)s\"";
            YTDPLHandler.SendCMDToYTDLP(arguments);
        }
        #endregion
    }
}