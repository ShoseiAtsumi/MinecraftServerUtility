using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MinecraftServerUtility.Forms
{
    public partial class ResidentForm : MetroForm
    {
        /// <summary>
        /// サーバー PID
        /// </summary>
        public static int? serverProcessId = null;

        public ResidentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            var exsistMF = fc.Cast<Form>().Where(x => x.Name == "MainForm");

            if (exsistMF.Any()) return;

            OpenMainForm();
        }

        private void OpenMainForm()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        /// <summary>
        /// 終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //アプリケーションを終了する
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}
