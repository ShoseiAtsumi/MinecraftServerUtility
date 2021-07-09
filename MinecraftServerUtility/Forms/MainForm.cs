using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MinecraftServerUtility.Utility;
using System.IO;

namespace MinecraftServerUtility.Forms
{
    public partial class MainForm : MetroForm
    {
        private CancellationTokenSource cancellationTokenSource;
        private Task updateTask;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Reload();
            // 非同期処理をCancelするためのTokenを取得.
            cancellationTokenSource = new CancellationTokenSource();
            var cancelToken = cancellationTokenSource.Token;
            updateTask = Task.Run(() => StartUpdate(cancelToken));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        private void Reload()
        {
            cmbMemoryValue.SelectedIndex = 0;
        }

        private void StartUpdate(CancellationToken cancelToken)
        {
            while (true)
            {
                if (cancelToken.IsCancellationRequested)
                {
                    // キャンセルされたらTaskを終了する.
                    return;
                }
                this.Invoke(new Action(this.UpdateServerStatus));
                Thread.Sleep(1000);
            }
        }

        public void UpdateServerStatus()
        {
            if(ResidentForm.serverProcessId == null)TextBoxServerStatus.Text = "Server is down";
            else TextBoxServerStatus.Text = "Server is running";
        }

        private void btnEexcute_Click(object sender, EventArgs e)
        {
            var serverPath = string.Empty;
            var config = string.Empty;
            serverPath = string.IsNullOrEmpty(TextBoxServerPath.Text) ? string.Empty : TextBoxServerPath.Text;
            config = string.IsNullOrEmpty(TextBoxConfigStr.Text) ? string.Empty : TextBoxConfigStr.Text;
            ServerExecuter serverExecuter = new ServerExecuter();
            try
            {
                Task.Run(() => serverExecuter.KickProcess(serverPath, config));
            }
            catch
            {
                return;
            }
        }

        private void SeverPathSelectButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog()
            {
                Filter = "jar files (*.jar)|*.txt|All files (*.*)|*.*",
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.TextBoxServerPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void CreateConfig(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TextBoxServerPath.Text)) return;
            if (this.cmbMemoryValue.SelectedIndex == -1) return;

            var minMemoryValue = 1;
            var maxMemoryValue = 1;

            int.TryParse(this.cmbMemoryValue.SelectedItem.ToString(), out maxMemoryValue);

            TextBoxConfigStr.Text = $"-Xmx{1024 * maxMemoryValue}M -Xms{1024 * minMemoryValue}M -jar {this.TextBoxServerPath.Text} nogui";

        }
    }
}
