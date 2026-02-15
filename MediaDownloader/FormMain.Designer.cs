namespace MediaDownloader
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxURL = new TextBox();
            panel1 = new Panel();
            button3 = new Button();
            buttonPasteURL = new Button();
            label1 = new Label();
            button2 = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            tableLayoutPanel1 = new TableLayoutPanel();
            label7 = new Label();
            label6 = new Label();
            tabBtnThumbnail = new PictureBox();
            tabBtnAudio = new PictureBox();
            tabBtnVideo = new PictureBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            creditsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            richTextBoxLog = new RichTextBox();
            label4 = new Label();
            tabDownloadType = new TabControl();
            pageVideo = new TabPage();
            pageAudio = new TabPage();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            pageThumbnail = new TabPage();
            groupBox2 = new GroupBox();
            comboBox2 = new ComboBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            label8 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripYTDLPStatus = new ToolStripStatusLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button5 = new Button();
            button4 = new Button();
            label11 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabBtnThumbnail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabBtnAudio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabBtnVideo).BeginInit();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            tabDownloadType.SuspendLayout();
            pageAudio.SuspendLayout();
            groupBox1.SuspendLayout();
            pageThumbnail.SuspendLayout();
            groupBox2.SuspendLayout();
            statusStrip1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxURL
            // 
            textBoxURL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxURL.Location = new Point(40, 0);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(517, 23);
            textBoxURL.TabIndex = 0;
            textBoxURL.MouseUp += TextBoxURL_MouseUp;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(textBoxURL);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 56);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(283, 6);
            button3.Name = "button3";
            button3.Size = new Size(274, 23);
            button3.TabIndex = 3;
            button3.Text = "Download";
            button3.UseVisualStyleBackColor = true;
            button3.Click += StartDownloadButton_Click;
            // 
            // buttonPasteURL
            // 
            buttonPasteURL.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonPasteURL.Location = new Point(3, 6);
            buttonPasteURL.Name = "buttonPasteURL";
            buttonPasteURL.Size = new Size(274, 23);
            buttonPasteURL.TabIndex = 2;
            buttonPasteURL.Text = "Paste URL";
            buttonPasteURL.UseVisualStyleBackColor = true;
            buttonPasteURL.Click += ButtonPasteURL_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "URL:";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(12, 398);
            button2.Name = "button2";
            button2.Size = new Size(560, 41);
            button2.TabIndex = 3;
            button2.Text = "Download";
            button2.UseVisualStyleBackColor = true;
            button2.Click += StartDownloadButton_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(label7, 2, 1);
            tableLayoutPanel1.Controls.Add(label6, 1, 1);
            tableLayoutPanel1.Controls.Add(tabBtnThumbnail, 2, 0);
            tableLayoutPanel1.Controls.Add(tabBtnAudio, 1, 0);
            tableLayoutPanel1.Controls.Add(tabBtnVideo, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 118);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(560, 99);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(434, 81);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 9;
            label7.Text = "Thumbnail";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(259, 81);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 8;
            label6.Text = "Audio";
            // 
            // tabBtnThumbnail
            // 
            tabBtnThumbnail.Anchor = AnchorStyles.None;
            tabBtnThumbnail.Image = Properties.Resources.thumbnail;
            tabBtnThumbnail.Location = new Point(426, 0);
            tabBtnThumbnail.Margin = new Padding(0);
            tabBtnThumbnail.Name = "tabBtnThumbnail";
            tabBtnThumbnail.Size = new Size(80, 79);
            tabBtnThumbnail.TabIndex = 3;
            tabBtnThumbnail.TabStop = false;
            tabBtnThumbnail.Click += TabBtnThumbnail_Click;
            // 
            // tabBtnAudio
            // 
            tabBtnAudio.Anchor = AnchorStyles.None;
            tabBtnAudio.Image = Properties.Resources.audio;
            tabBtnAudio.Location = new Point(239, 0);
            tabBtnAudio.Margin = new Padding(0);
            tabBtnAudio.Name = "tabBtnAudio";
            tabBtnAudio.Size = new Size(80, 79);
            tabBtnAudio.TabIndex = 3;
            tabBtnAudio.TabStop = false;
            tabBtnAudio.Click += TabBtnAudio_Click;
            // 
            // tabBtnVideo
            // 
            tabBtnVideo.Anchor = AnchorStyles.None;
            tabBtnVideo.Image = Properties.Resources.video;
            tabBtnVideo.Location = new Point(53, 0);
            tabBtnVideo.Margin = new Padding(0);
            tabBtnVideo.Name = "tabBtnVideo";
            tabBtnVideo.Size = new Size(80, 79);
            tabBtnVideo.TabIndex = 0;
            tabBtnVideo.TabStop = false;
            tabBtnVideo.Click += TabBtnVideo_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(74, 81);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 4;
            label5.Text = "Video";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(560, 16);
            label2.TabIndex = 3;
            label2.Text = "Download Type";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(0, 220);
            label3.Name = "label3";
            label3.Size = new Size(584, 20);
            label3.TabIndex = 4;
            label3.Text = "Download Options";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem, updateToolStripMenuItem, creditsToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.ShortcutKeyDisplayString = "O";
            optionsToolStripMenuItem.Size = new Size(132, 22);
            optionsToolStripMenuItem.Text = "&Options";
            optionsToolStripMenuItem.Click += OptionsToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.ShortcutKeyDisplayString = "U";
            updateToolStripMenuItem.Size = new Size(132, 22);
            updateToolStripMenuItem.Text = "&Update";
            // 
            // creditsToolStripMenuItem
            // 
            creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            creditsToolStripMenuItem.ShortcutKeyDisplayString = "A";
            creditsToolStripMenuItem.Size = new Size(132, 22);
            creditsToolStripMenuItem.Text = "&About";
            creditsToolStripMenuItem.Click += CreditsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeyDisplayString = "E";
            exitToolStripMenuItem.Size = new Size(132, 22);
            exitToolStripMenuItem.Text = "&Exit";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(richTextBoxLog);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 445);
            panel2.Name = "panel2";
            panel2.Size = new Size(560, 204);
            panel2.TabIndex = 6;
            // 
            // richTextBoxLog
            // 
            richTextBoxLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxLog.AutoWordSelection = true;
            richTextBoxLog.BackColor = Color.FromArgb(35, 35, 35);
            richTextBoxLog.ForeColor = Color.Lime;
            richTextBoxLog.Location = new Point(4, 18);
            richTextBoxLog.Name = "richTextBoxLog";
            richTextBoxLog.Size = new Size(552, 173);
            richTextBoxLog.TabIndex = 1;
            richTextBoxLog.Text = "Console Sample Text. This is what code would look like when being ran. etc. etc. etc. next line should be appearing soon.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 0;
            label4.Text = "Output";
            // 
            // tabDownloadType
            // 
            tabDownloadType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabDownloadType.Controls.Add(pageVideo);
            tabDownloadType.Controls.Add(pageAudio);
            tabDownloadType.Controls.Add(pageThumbnail);
            tabDownloadType.Location = new Point(0, 223);
            tabDownloadType.Name = "tabDownloadType";
            tabDownloadType.SelectedIndex = 0;
            tabDownloadType.Size = new Size(584, 132);
            tabDownloadType.SizeMode = TabSizeMode.FillToRight;
            tabDownloadType.TabIndex = 7;
            // 
            // pageVideo
            // 
            pageVideo.Location = new Point(4, 24);
            pageVideo.Name = "pageVideo";
            pageVideo.Padding = new Padding(3);
            pageVideo.Size = new Size(576, 104);
            pageVideo.TabIndex = 0;
            pageVideo.Text = "Video";
            pageVideo.UseVisualStyleBackColor = true;
            // 
            // pageAudio
            // 
            pageAudio.Controls.Add(groupBox1);
            pageAudio.Location = new Point(4, 24);
            pageAudio.Name = "pageAudio";
            pageAudio.Padding = new Padding(3);
            pageAudio.Size = new Size(576, 104);
            pageAudio.TabIndex = 1;
            pageAudio.Text = "Audio";
            pageAudio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(564, 92);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Album Art Options";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "512", "1024", "2048", "4096" });
            comboBox1.Location = new Point(290, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 23);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "1024";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(173, 22);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(111, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Scale Album Art";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 47);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(142, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Crop Album Art to 1:1";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Embed Album Art";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // pageThumbnail
            // 
            pageThumbnail.Controls.Add(groupBox2);
            pageThumbnail.Location = new Point(4, 24);
            pageThumbnail.Name = "pageThumbnail";
            pageThumbnail.Size = new Size(576, 104);
            pageThumbnail.TabIndex = 2;
            pageThumbnail.Text = "Thumbnail";
            pageThumbnail.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(564, 92);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thumbnail Options";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "512", "1024", "2048", "4096" });
            comboBox2.Location = new Point(84, 45);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(268, 23);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "1024";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 47);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(72, 19);
            checkBox4.TabIndex = 2;
            checkBox4.Text = "Scale Art";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 22);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(103, 19);
            checkBox5.TabIndex = 1;
            checkBox5.Text = "Crop Art to 1:1";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(12, 24);
            label8.Name = "label8";
            label8.Size = new Size(560, 19);
            label8.TabIndex = 8;
            label8.Text = "Source";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, toolStripYTDLPStatus });
            statusStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            statusStrip1.Location = new Point(0, 640);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(584, 21);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 15);
            // 
            // toolStripYTDLPStatus
            // 
            toolStripYTDLPStatus.Name = "toolStripYTDLPStatus";
            toolStripYTDLPStatus.Size = new Size(148, 15);
            toolStripYTDLPStatus.Text = "YT-DLP Status: Unavailable";
            toolStripYTDLPStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 116F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.5927544F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.7036228F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.7036228F));
            tableLayoutPanel2.Controls.Add(button5, 3, 0);
            tableLayoutPanel2.Controls.Add(button4, 2, 0);
            tableLayoutPanel2.Controls.Add(label11, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Location = new Point(12, 361);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(560, 31);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button5.Location = new Point(475, 4);
            button5.Name = "button5";
            button5.Size = new Size(82, 23);
            button5.TabIndex = 3;
            button5.Text = "Default";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button4.Location = new Point(388, 4);
            button4.Name = "button4";
            button4.Size = new Size(81, 23);
            button4.TabIndex = 2;
            button4.Text = "Assign";
            button4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(3, 8);
            label11.Name = "label11";
            label11.Size = new Size(110, 15);
            label11.TabIndex = 0;
            label11.Text = "Download Location";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(119, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 23);
            textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(buttonPasteURL, 0, 0);
            tableLayoutPanel3.Controls.Add(button3, 1, 0);
            tableLayoutPanel3.Location = new Point(0, 21);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(560, 35);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 661);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Controls.Add(tabDownloadType);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "YT-DLP GUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabBtnThumbnail).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabBtnAudio).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabBtnVideo).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabDownloadType.ResumeLayout(false);
            pageAudio.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pageThumbnail.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxURL;
        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button buttonPasteURL;
        private FileSystemWatcher fileSystemWatcher1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox tabBtnVideo;
        private PictureBox tabBtnThumbnail;
        private PictureBox tabBtnAudio;
        private Label label3;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem creditsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel panel2;
        private Label label4;
        private ToolStripMenuItem updateToolStripMenuItem;
        private TabControl tabDownloadType;
        private TabPage pageVideo;
        private TabPage pageAudio;
        private TabPage pageThumbnail;
        private Label label7;
        private Label label6;
        private Label label5;
        private RichTextBox richTextBoxLog;
        private Button button3;
        private Label label8;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripYTDLPStatus;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private GroupBox groupBox2;
        private ComboBox comboBox2;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button4;
        private Label label11;
        private TextBox textBox1;
        private Button button5;
        private TableLayoutPanel tableLayoutPanel3;
    }
}
