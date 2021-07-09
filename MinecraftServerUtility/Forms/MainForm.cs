using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MinecraftServerUtility.Utility;

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

        /// <summary>
        /// ロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            Reload();
            // 非同期処理をCancelするためのTokenを取得.
            cancellationTokenSource = new CancellationTokenSource();
            var cancelToken = cancellationTokenSource.Token;
            // 更新処理開始
            updateTask = Task.Run(() => StartUpdate(cancelToken));
        }

        /// <summary>
        /// クローズ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // タスクを終了
            cancellationTokenSource.Cancel();
        }

        /// <summary>
        /// 再読み込み
        /// </summary>
        private void Reload()
        {
            // デフォルト
            cmbMemoryValue.SelectedIndex = 0;
        }

        /// <summary>
        /// 更新処理開始
        /// </summary>
        /// <param name="cancelToken"></param>
        private void StartUpdate(CancellationToken cancelToken)
        {
            //更新
            while (true)
            {
                //　終了？
                if (cancelToken.IsCancellationRequested)
                {
                    // キャンセルされたらTaskを終了する.
                    return;
                }
                
                // サーバー稼働状態更新
                this.Invoke(new Action(this.UpdateServerStatus));
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// サーバーが稼働しているかチェックし更新
        /// </summary>
        public void UpdateServerStatus()
        {
            // サーバーが稼働していたら
            if(isServerRunning()) TextBoxServerStatus.Text = "Server is running";
            else TextBoxServerStatus.Text = "Server is down";
        }

        /// <summary>
        /// サーバーの稼働状態を取得
        /// </summary>
        /// <returns></returns>
        private bool isServerRunning()
        {
            // サーバーが稼働しているか? 
            return ResidentForm.serverProcessId != null;
        }

        /// <summary>
        /// サーバー起動ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEexcute_Click(object sender, EventArgs e)
        {
            // サーバーが稼働しているかチェック
            if (isServerRunning()) return;
            var serverPath = string.Empty;
            var config = string.Empty;

            // サーバー実行ファイルとコンフィグを取得
            serverPath = string.IsNullOrEmpty(TextBoxServerPath.Text) ? string.Empty : TextBoxServerPath.Text;
            config = string.IsNullOrEmpty(TextBoxConfigStr.Text) ? string.Empty : TextBoxConfigStr.Text;
            ServerExecuter serverExecuter = new ServerExecuter();
            try
            {
                // サーバー起動
                Task.Run(() => serverExecuter.KickProcess(serverPath, config));
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// サーバー実行ファイルを選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// コンフィグを生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
