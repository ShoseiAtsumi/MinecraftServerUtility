
namespace MinecraftServerUtility.Forms
{
    partial class MainForm
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
            if (disposing && (components != null))
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
            this.btnEexcute = new MetroFramework.Controls.MetroButton();
            this.DownloadFolderLabel = new MetroFramework.Drawing.Html.HtmlLabel();
            this.TextBoxServerPath = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxConfigStr = new MetroFramework.Controls.MetroTextBox();
            this.URL_Label = new MetroFramework.Drawing.Html.HtmlLabel();
            this.cmbMemoryValue = new MetroFramework.Controls.MetroComboBox();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.btnSeverPathSelect = new MetroFramework.Controls.MetroButton();
            this.TextBoxServerStatus = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnEexcute
            // 
            this.btnEexcute.Location = new System.Drawing.Point(370, 188);
            this.btnEexcute.Name = "btnEexcute";
            this.btnEexcute.Size = new System.Drawing.Size(75, 23);
            this.btnEexcute.TabIndex = 0;
            this.btnEexcute.Text = "Execute";
            this.btnEexcute.UseSelectable = true;
            this.btnEexcute.Click += new System.EventHandler(this.btnEexcute_Click);
            // 
            // DownloadFolderLabel
            // 
            this.DownloadFolderLabel.AutoScrollMinSize = new System.Drawing.Size(70, 22);
            this.DownloadFolderLabel.AutoSize = false;
            this.DownloadFolderLabel.BackColor = System.Drawing.SystemColors.Window;
            this.DownloadFolderLabel.Location = new System.Drawing.Point(23, 64);
            this.DownloadFolderLabel.Name = "DownloadFolderLabel";
            this.DownloadFolderLabel.Size = new System.Drawing.Size(91, 17);
            this.DownloadFolderLabel.TabIndex = 8;
            this.DownloadFolderLabel.Text = "Server Path";
            // 
            // TextBoxServerPath
            // 
            // 
            // 
            // 
            this.TextBoxServerPath.CustomButton.Image = null;
            this.TextBoxServerPath.CustomButton.Location = new System.Drawing.Point(311, 1);
            this.TextBoxServerPath.CustomButton.Name = "";
            this.TextBoxServerPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxServerPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxServerPath.CustomButton.TabIndex = 1;
            this.TextBoxServerPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxServerPath.CustomButton.UseSelectable = true;
            this.TextBoxServerPath.CustomButton.Visible = false;
            this.TextBoxServerPath.Lines = new string[0];
            this.TextBoxServerPath.Location = new System.Drawing.Point(23, 87);
            this.TextBoxServerPath.MaxLength = 32767;
            this.TextBoxServerPath.Name = "TextBoxServerPath";
            this.TextBoxServerPath.PasswordChar = '\0';
            this.TextBoxServerPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxServerPath.SelectedText = "";
            this.TextBoxServerPath.SelectionLength = 0;
            this.TextBoxServerPath.SelectionStart = 0;
            this.TextBoxServerPath.ShortcutsEnabled = true;
            this.TextBoxServerPath.Size = new System.Drawing.Size(333, 23);
            this.TextBoxServerPath.TabIndex = 7;
            this.TextBoxServerPath.UseSelectable = true;
            this.TextBoxServerPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxServerPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxServerPath.TextChanged += new System.EventHandler(this.CreateConfig);
            // 
            // TextBoxConfigStr
            // 
            // 
            // 
            // 
            this.TextBoxConfigStr.CustomButton.Image = null;
            this.TextBoxConfigStr.CustomButton.Location = new System.Drawing.Point(311, 1);
            this.TextBoxConfigStr.CustomButton.Name = "";
            this.TextBoxConfigStr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxConfigStr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxConfigStr.CustomButton.TabIndex = 1;
            this.TextBoxConfigStr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxConfigStr.CustomButton.UseSelectable = true;
            this.TextBoxConfigStr.CustomButton.Visible = false;
            this.TextBoxConfigStr.Lines = new string[] {
        "-Xmx1024M -Xms1024M"};
            this.TextBoxConfigStr.Location = new System.Drawing.Point(23, 188);
            this.TextBoxConfigStr.MaxLength = 32767;
            this.TextBoxConfigStr.Name = "TextBoxConfigStr";
            this.TextBoxConfigStr.PasswordChar = '\0';
            this.TextBoxConfigStr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxConfigStr.SelectedText = "";
            this.TextBoxConfigStr.SelectionLength = 0;
            this.TextBoxConfigStr.SelectionStart = 0;
            this.TextBoxConfigStr.ShortcutsEnabled = true;
            this.TextBoxConfigStr.Size = new System.Drawing.Size(333, 23);
            this.TextBoxConfigStr.TabIndex = 11;
            this.TextBoxConfigStr.Text = "-Xmx1024M -Xms1024M";
            this.TextBoxConfigStr.UseSelectable = true;
            this.TextBoxConfigStr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxConfigStr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // URL_Label
            // 
            this.URL_Label.AutoScrollMinSize = new System.Drawing.Size(43, 22);
            this.URL_Label.AutoSize = false;
            this.URL_Label.BackColor = System.Drawing.SystemColors.Window;
            this.URL_Label.Location = new System.Drawing.Point(23, 171);
            this.URL_Label.Name = "URL_Label";
            this.URL_Label.Size = new System.Drawing.Size(60, 19);
            this.URL_Label.TabIndex = 10;
            this.URL_Label.Text = "Config";
            // 
            // cmbMemoryValue
            // 
            this.cmbMemoryValue.FormattingEnabled = true;
            this.cmbMemoryValue.ItemHeight = 23;
            this.cmbMemoryValue.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbMemoryValue.Location = new System.Drawing.Point(23, 136);
            this.cmbMemoryValue.Name = "cmbMemoryValue";
            this.cmbMemoryValue.Size = new System.Drawing.Size(130, 29);
            this.cmbMemoryValue.TabIndex = 12;
            this.cmbMemoryValue.UseSelectable = true;
            this.cmbMemoryValue.SelectedValueChanged += new System.EventHandler(this.CreateConfig);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(71, 22);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(23, 116);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(130, 18);
            this.htmlLabel1.TabIndex = 11;
            this.htmlLabel1.Text = "MaxMemory";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(36, 29);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.htmlLabel2.Location = new System.Drawing.Point(159, 136);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(60, 29);
            this.htmlLabel2.TabIndex = 11;
            this.htmlLabel2.Text = "GB";
            // 
            // btnSeverPathSelect
            // 
            this.btnSeverPathSelect.Location = new System.Drawing.Point(370, 87);
            this.btnSeverPathSelect.Name = "btnSeverPathSelect";
            this.btnSeverPathSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSeverPathSelect.TabIndex = 13;
            this.btnSeverPathSelect.Text = "Select";
            this.btnSeverPathSelect.UseSelectable = true;
            this.btnSeverPathSelect.Click += new System.EventHandler(this.SeverPathSelectButton_Click);
            // 
            // TextBoxServerStatus
            // 
            // 
            // 
            // 
            this.TextBoxServerStatus.CustomButton.Image = null;
            this.TextBoxServerStatus.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.TextBoxServerStatus.CustomButton.Name = "";
            this.TextBoxServerStatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxServerStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxServerStatus.CustomButton.TabIndex = 1;
            this.TextBoxServerStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxServerStatus.CustomButton.UseSelectable = true;
            this.TextBoxServerStatus.CustomButton.Visible = false;
            this.TextBoxServerStatus.Lines = new string[0];
            this.TextBoxServerStatus.Location = new System.Drawing.Point(347, 32);
            this.TextBoxServerStatus.MaxLength = 32767;
            this.TextBoxServerStatus.Name = "TextBoxServerStatus";
            this.TextBoxServerStatus.PasswordChar = '\0';
            this.TextBoxServerStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxServerStatus.SelectedText = "";
            this.TextBoxServerStatus.SelectionLength = 0;
            this.TextBoxServerStatus.SelectionStart = 0;
            this.TextBoxServerStatus.ShortcutsEnabled = true;
            this.TextBoxServerStatus.Size = new System.Drawing.Size(98, 23);
            this.TextBoxServerStatus.TabIndex = 14;
            this.TextBoxServerStatus.UseSelectable = true;
            this.TextBoxServerStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxServerStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 238);
            this.Controls.Add(this.TextBoxServerStatus);
            this.Controls.Add(this.btnSeverPathSelect);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.cmbMemoryValue);
            this.Controls.Add(this.TextBoxConfigStr);
            this.Controls.Add(this.URL_Label);
            this.Controls.Add(this.DownloadFolderLabel);
            this.Controls.Add(this.TextBoxServerPath);
            this.Controls.Add(this.btnEexcute);
            this.MaximumSize = new System.Drawing.Size(483, 238);
            this.MinimumSize = new System.Drawing.Size(483, 238);
            this.Name = "MainForm";
            this.Text = "SeverSetting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnEexcute;
        private MetroFramework.Drawing.Html.HtmlLabel DownloadFolderLabel;
        private MetroFramework.Controls.MetroTextBox TextBoxServerPath;
        private MetroFramework.Controls.MetroTextBox TextBoxConfigStr;
        private MetroFramework.Drawing.Html.HtmlLabel URL_Label;
        private MetroFramework.Controls.MetroComboBox cmbMemoryValue;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroButton btnSeverPathSelect;
        private MetroFramework.Controls.MetroTextBox TextBoxServerStatus;
    }
}