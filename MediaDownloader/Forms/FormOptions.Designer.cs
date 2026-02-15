namespace MediaDownloader
{
    partial class FormOptions
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
            if(disposing && (components != null))
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
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonSetVideoDir = new Button();
            buttonSetAudioDir = new Button();
            buttonSetThumbnailDir = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBoxThumbnailDir = new TextBox();
            textBoxVideoDir = new TextBox();
            textBoxAudioDir = new TextBox();
            label4 = new Label();
            textBoxCookieDir = new TextBox();
            buttonSetCookieDir = new Button();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonYTDLPDir = new Button();
            label7 = new Label();
            textBoxYTDLPDir = new TextBox();
            buttonUpdateYTDLP = new Button();
            groupBox3 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label6 = new Label();
            comboBoxJSRuntime = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonFFMPEGDir = new Button();
            label5 = new Label();
            textBoxFFMPEGDir = new TextBox();
            buttonReset = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Default Directories";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 132F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.8802261F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.1197777F));
            tableLayoutPanel1.Controls.Add(buttonSetVideoDir, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonSetAudioDir, 2, 1);
            tableLayoutPanel1.Controls.Add(buttonSetThumbnailDir, 2, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxThumbnailDir, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxVideoDir, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxAudioDir, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(textBoxCookieDir, 1, 3);
            tableLayoutPanel1.Controls.Add(buttonSetCookieDir, 2, 3);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(381, 122);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // buttonSetVideoDir
            // 
            buttonSetVideoDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonSetVideoDir.Location = new Point(326, 3);
            buttonSetVideoDir.Name = "buttonSetVideoDir";
            buttonSetVideoDir.Size = new Size(52, 23);
            buttonSetVideoDir.TabIndex = 2;
            buttonSetVideoDir.Text = "Assign";
            buttonSetVideoDir.UseVisualStyleBackColor = true;
            buttonSetVideoDir.Click += ButtonSetVideoDir_Click;
            // 
            // buttonSetAudioDir
            // 
            buttonSetAudioDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonSetAudioDir.Location = new Point(326, 33);
            buttonSetAudioDir.Name = "buttonSetAudioDir";
            buttonSetAudioDir.Size = new Size(52, 23);
            buttonSetAudioDir.TabIndex = 2;
            buttonSetAudioDir.Text = "Assign";
            buttonSetAudioDir.UseVisualStyleBackColor = true;
            // 
            // buttonSetThumbnailDir
            // 
            buttonSetThumbnailDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonSetThumbnailDir.Location = new Point(326, 63);
            buttonSetThumbnailDir.Name = "buttonSetThumbnailDir";
            buttonSetThumbnailDir.Size = new Size(52, 23);
            buttonSetThumbnailDir.TabIndex = 2;
            buttonSetThumbnailDir.Text = "Assign";
            buttonSetThumbnailDir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.Location = new Point(14, 37);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 0;
            label2.Text = "Audio Directory";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.Location = new Point(14, 67);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 0;
            label3.Text = "Thumbnail Directory";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.Location = new Point(14, 3);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 0;
            label1.Text = "Video Directory";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxThumbnailDir
            // 
            textBoxThumbnailDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxThumbnailDir.Location = new Point(135, 63);
            textBoxThumbnailDir.Name = "textBoxThumbnailDir";
            textBoxThumbnailDir.Size = new Size(185, 23);
            textBoxThumbnailDir.TabIndex = 1;
            // 
            // textBoxVideoDir
            // 
            textBoxVideoDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxVideoDir.Location = new Point(135, 3);
            textBoxVideoDir.Name = "textBoxVideoDir";
            textBoxVideoDir.Size = new Size(185, 23);
            textBoxVideoDir.TabIndex = 1;
            textBoxVideoDir.TextChanged += TextBoxVideoDir_TextChanged;
            // 
            // textBoxAudioDir
            // 
            textBoxAudioDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxAudioDir.Location = new Point(135, 33);
            textBoxAudioDir.Name = "textBoxAudioDir";
            textBoxAudioDir.Size = new Size(185, 23);
            textBoxAudioDir.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.Location = new Point(14, 98);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 0;
            label4.Text = "cookie.txt Directory";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxCookieDir
            // 
            textBoxCookieDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxCookieDir.Location = new Point(135, 94);
            textBoxCookieDir.Name = "textBoxCookieDir";
            textBoxCookieDir.Size = new Size(185, 23);
            textBoxCookieDir.TabIndex = 1;
            // 
            // buttonSetCookieDir
            // 
            buttonSetCookieDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonSetCookieDir.Location = new Point(326, 94);
            buttonSetCookieDir.Name = "buttonSetCookieDir";
            buttonSetCookieDir.Size = new Size(52, 23);
            buttonSetCookieDir.TabIndex = 2;
            buttonSetCookieDir.Text = "Assign";
            buttonSetCookieDir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Controls.Add(buttonUpdateYTDLP);
            groupBox2.Location = new Point(12, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 93);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "YT-DLP";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 132F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.88F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.12F));
            tableLayoutPanel2.Controls.Add(buttonYTDLPDir, 2, 0);
            tableLayoutPanel2.Controls.Add(label7, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxYTDLPDir, 1, 0);
            tableLayoutPanel2.Location = new Point(6, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(381, 35);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // buttonYTDLPDir
            // 
            buttonYTDLPDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonYTDLPDir.Location = new Point(326, 6);
            buttonYTDLPDir.Name = "buttonYTDLPDir";
            buttonYTDLPDir.Size = new Size(52, 23);
            buttonYTDLPDir.TabIndex = 2;
            buttonYTDLPDir.Text = "Assign";
            buttonYTDLPDir.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(32, 10);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 0;
            label7.Text = "YT-DLP Directory";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxYTDLPDir
            // 
            textBoxYTDLPDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxYTDLPDir.Location = new Point(135, 6);
            textBoxYTDLPDir.Name = "textBoxYTDLPDir";
            textBoxYTDLPDir.Size = new Size(185, 23);
            textBoxYTDLPDir.TabIndex = 1;
            // 
            // buttonUpdateYTDLP
            // 
            buttonUpdateYTDLP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonUpdateYTDLP.Location = new Point(6, 63);
            buttonUpdateYTDLP.Name = "buttonUpdateYTDLP";
            buttonUpdateYTDLP.Size = new Size(378, 23);
            buttonUpdateYTDLP.TabIndex = 0;
            buttonUpdateYTDLP.Text = "Update YT-DLP";
            buttonUpdateYTDLP.UseVisualStyleBackColor = true;
            buttonUpdateYTDLP.Click += ButtonUpdateYTDLP_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(tableLayoutPanel4);
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Location = new Point(12, 261);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(390, 92);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "External Tools";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 131F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 99.99999F));
            tableLayoutPanel4.Controls.Add(label6, 0, 0);
            tableLayoutPanel4.Controls.Add(comboBoxJSRuntime, 1, 0);
            tableLayoutPanel4.Location = new Point(6, 57);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(378, 27);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(18, 6);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 1;
            label6.Text = "External JS Runtime";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBoxJSRuntime
            // 
            comboBoxJSRuntime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxJSRuntime.FormattingEnabled = true;
            comboBoxJSRuntime.Location = new Point(134, 3);
            comboBoxJSRuntime.Margin = new Padding(3, 3, 50, 3);
            comboBoxJSRuntime.Name = "comboBoxJSRuntime";
            comboBoxJSRuntime.Size = new Size(194, 23);
            comboBoxJSRuntime.TabIndex = 2;
            comboBoxJSRuntime.SelectedIndexChanged += ComboBoxJSRuntime_SelectedIndexChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 132F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.88F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.12F));
            tableLayoutPanel3.Controls.Add(buttonFFMPEGDir, 2, 0);
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Controls.Add(textBoxFFMPEGDir, 1, 0);
            tableLayoutPanel3.Location = new Point(6, 22);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(378, 35);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // buttonFFMPEGDir
            // 
            buttonFFMPEGDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonFFMPEGDir.Location = new Point(324, 6);
            buttonFFMPEGDir.Name = "buttonFFMPEGDir";
            buttonFFMPEGDir.Size = new Size(51, 23);
            buttonFFMPEGDir.TabIndex = 2;
            buttonFFMPEGDir.Text = "Assign";
            buttonFFMPEGDir.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(27, 10);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 0;
            label5.Text = "FFMPEG Directory";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxFFMPEGDir
            // 
            textBoxFFMPEGDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxFFMPEGDir.Location = new Point(135, 6);
            textBoxFFMPEGDir.Name = "textBoxFFMPEGDir";
            textBoxFFMPEGDir.Size = new Size(183, 23);
            textBoxFFMPEGDir.TabIndex = 1;
            // 
            // buttonReset
            // 
            buttonReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonReset.Location = new Point(12, 356);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(390, 23);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "Reset Settings";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += ButtonReset_Click;
            // 
            // FormOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 391);
            Controls.Add(buttonReset);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MinimumSize = new Size(430, 430);
            Name = "FormOptions";
            StartPosition = FormStartPosition.CenterParent;
            Text = "YT-DLP GUI Options";
            Load += FormOptions_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button buttonSetThumbnailDir;
        private Button buttonSetAudioDir;
        private Button buttonSetVideoDir;
        private TextBox textBoxThumbnailDir;
        private Label label3;
        private TextBox textBoxAudioDir;
        private Label label2;
        private TextBox textBoxVideoDir;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private TextBox textBoxCookieDir;
        private Button buttonSetCookieDir;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonYTDLPDir;
        private Label label7;
        private TextBox textBoxYTDLPDir;
        private Button buttonUpdateYTDLP;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonFFMPEGDir;
        private Label label5;
        private TextBox textBoxFFMPEGDir;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label6;
        private ComboBox comboBoxJSRuntime;
        private Button buttonReset;
    }
}