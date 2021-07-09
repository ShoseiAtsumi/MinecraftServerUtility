using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinecraftServerUtility.Forms;

namespace MinecraftServerUtility
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>

        private static ResidentForm residentForm;

        [STAThread]
        static void Main()
        {
            try
            {
                if (!File.Exists(System.IO.Directory.GetCurrentDirectory() + @"\conf"))
                {
                    Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + @"\conf");
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                residentForm = new ResidentForm();
                Application.Run();
            }
            catch(Exception e)
            {
                var aaa = e;
                var aas = e; 
            }
            finally
            {
                //アプリケーションを終了する
                Application.Exit();
            }
        }
    }
}
