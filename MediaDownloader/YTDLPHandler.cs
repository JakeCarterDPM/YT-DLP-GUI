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
        public static Process SendCMDToYTDLP(string arguments)
        {
            string ytDlpPath = Properties.Settings.Default.YTDLPDir;

            if(string.IsNullOrWhiteSpace(ytDlpPath) || !File.Exists(ytDlpPath))
                throw new InvalidOperationException("YT-DLP executable not found. Check your settings.");

            ProcessStartInfo psi = new()
            {
                FileName = ytDlpPath,
                Arguments = arguments,
                UseShellExecute = false,   // allows output redirection
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            Process proc = new()
            { StartInfo = psi };

            proc.OutputDataReceived += (sender, e) =>
            {
                if(!string.IsNullOrWhiteSpace(e.Data))
                    Console.WriteLine(e.Data); // replace with form UI if needed
            };

            proc.ErrorDataReceived += (sender, e) =>
            {
                if(!string.IsNullOrWhiteSpace(e.Data))
                    Console.Error.WriteLine(e.Data); // replace with form UI if needed
            };

            proc.Start();
            proc.BeginOutputReadLine();
            proc.BeginErrorReadLine();

            return proc; // caller can wait or track exit
        }
    }
}
