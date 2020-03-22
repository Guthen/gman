using System;
using System.Diagnostics;

namespace gman.Classes
{
    public static class Shell
    {
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

            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return result;
        }
    }
}
