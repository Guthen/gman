using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace gman.Classes
{
    public static class Shell
    {
        /// <summary>
        /// Create and launch a process with given arguments.
        /// </summary>
        /// <param name="file_name">Executable path to launch.</param>
        /// <param name="arg">Argument to pass in.</param>
        /// <returns>Standard output of the process.</returns>
        public static string Execute( string file_name, string arg )
        {
            Process process = new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = file_name,
                    Arguments = arg,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };

            string result;
            try
            {
                process.Start();
                result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
            }
            catch ( System.ComponentModel.Win32Exception e )
            {
                MessageBox.Show( $"Process failed:\n{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return "";
            }

            return result;
        }
    }
}
