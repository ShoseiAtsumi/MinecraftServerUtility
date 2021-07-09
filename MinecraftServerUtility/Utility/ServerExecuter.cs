using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using MinecraftServerUtility.Forms;

namespace MinecraftServerUtility.Utility
{
    class ServerExecuter
    {
        public ServerExecuter()
        {

        }

        /// <summary>
        /// サーバーを起動
        /// </summary>
        /// <param name="severPath"></param>
        /// <param name="config"></param>
        public void KickProcess(string severPath, string config)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo();
                processInfo.FileName = "java";
                processInfo.Arguments = @config;
                processInfo.UseShellExecute = false;
                Process p = Process.Start(processInfo);
                ResidentForm.serverProcessId = p.SessionId;
                p.WaitForExit();
                p.Close();
            }
            finally
            {
                ResidentForm.serverProcessId = null;
            }
        }
    }
}
