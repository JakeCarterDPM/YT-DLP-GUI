# YT-DLP GUI

A simple Windows Form Application that provides a basic user interface for [yt-dlp](https://github.com/yt-dlp/yt-dlp), allowing easy video, audio, and thumbnail downloads without using the command line.

---

## Features
- Download videos, audio, and thumbnails from most websites supported by yt-dlp.
- Simple, lightweight interface.
- No command line knowledge required.
- Support for PATHs (FFMPEG, YT-DLP).
- Updater for YT-DLP.

---

## Requirements
In order to run _"perfectly"_, you must install FFMPEG and an "External JavaScript Runtime".
- **FFMPEG**: Used for modifying media. You can download a Windows version from [the Official FFMPEG Download Page](https://www.ffmpeg.org/download.html#build-windows).
- **External JavaScript Runtime**: Required for solving JavaScript challenges on some sites. Instructions for setting up External JS Scripts with yt-dlp are available on [yt-dlp's wiki page for EJS](https://github.com/yt-dlp/yt-dlp/wiki/EJS).

---

## Installation

1. Download the latest release from the [Releases](#) page.
2. Make sure 'yt-dlp.exe' is in the same folder as the GUI.
3. Run 'YT-DLP GUI.exe'
4. Select Menu > Options
5. Set cookies by selecting a file.
6. Choose an external JS runtime for advanced extraction.
7. YT-DLP GUI is ready to go.

---

## Usage
1. Open the application.
2. Paste a URL into the URL field.
3. Select your download type (Video, Audio, Thumbnail).
4. Select any suitable options that are available.
5. Click download.
6. Check the output folder for your downloaded file.

---

## Troubleshooting
**"The item isn't downloading"** - Try the following steps:
- **Check YT-DLP.exe**: Ensure you have [yt-dlp.exe]([https://github.com/yt-dlp/yt-dlp](https://github.com/yt-dlp/yt-dlp/releases)) in same folder as [YTDLP-GUI.exe](#). 
- **Update**: In YTDLP-GUI, click Menu, Options, then press Update YT-DLP.
- **Cookies**: Some sites require a login to access content, ensure your cookies configured correctly. You can follow [yt-dlp's guide on passing cookies](https://github.com/yt-dlp/yt-dlp/wiki/FAQ#how-do-i-pass-cookies-to-yt-dlp)
- **ExternalJS**: Some sites use JavaScript challenges to block non-browser access. Ensure you have installed an external JS runtime and configured it correctly. For guidance, see [yt-dlp's EJS setup instructions](https://github.com/yt-dlp/yt-dlp/wiki/EJS). 
- If issue persists, check [yt-dlp's main repository](https://github.com/yt-dlp/yt-dlp).

## To Do
- [ ] Upload a build.
- [ ] Complete argument formatting based on tab selected, provided URLs, settings, etc.
- [ ] Complete audio/Thumbnail's options tab.
- [ ] Add an option for auto update YT-DLP on startup.
- [x] Make log/console display text from launched downloads.

---

## License
The project is licensed under the [Creative Commons Attribution-NonComercial 4.0 International License (CC BY-NC 4.0)](https://creativecommons.org/licenses/by-nc/4.0/). You are free to share and adapt this project, but not for commercial purposes. Attribution is required.
