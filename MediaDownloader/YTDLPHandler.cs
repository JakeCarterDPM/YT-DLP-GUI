namespace MediaDownloader
{
    using System;
    using System.Diagnostics;
    using System.IO;

    public static class YTDPLHandler
    {
        /// <summary>
        /// Runs yt-dlp.exe (from settings) with the given arguments.
        /// </summary>
        /// <param name="arguments">Command-line arguments for yt-dlp</param>
        /// <returns>Process object for further tracking</returns>
        public static Process SendCMDToYTDLP(string arguments, Action<string> onOutput)
        {
            string ytDlpPath = Properties.Settings.Default.YTDLPDir;

            if(string.IsNullOrWhiteSpace(ytDlpPath) || !File.Exists(ytDlpPath))
                throw new InvalidOperationException("YT-DLP executable not found. Check your settings.");

            ProcessStartInfo psi = new()
            {
                FileName = ytDlpPath,
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            Process proc = new()
            {
                StartInfo = psi
            };

            proc.OutputDataReceived += (s, e) =>
            {
                if(!string.IsNullOrWhiteSpace(e.Data))
                    onOutput?.Invoke(e.Data);
            };

            proc.ErrorDataReceived += (s, e) =>
            {
                if(!string.IsNullOrWhiteSpace(e.Data))
                    onOutput?.Invoke("[ERROR] " + e.Data);
            };

            proc.Start();
            proc.BeginOutputReadLine();
            proc.BeginErrorReadLine();

            return proc;
        }
    }
}
