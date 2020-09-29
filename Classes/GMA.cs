using System;
using System.Diagnostics;
using System.IO;

namespace gman.Classes
{
    static class GMA
    {
        private static string Run( string cmd )
        {
            var process = new Process()
            {
                StartInfo =
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                }
            };

            process.Start();
            process.StandardInput.WriteLine( cmd );
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();

            return process.StandardOutput.ReadToEnd();
        }

        public static string Compress( string gmad_path, string folder_path, string out_path )
        {
            return Run( String.Format( "\"{0}\" create -folder \"{1}\" -out \"{2}\"", gmad_path, folder_path, out_path ) );
        }

        public static string Publish( string gmpublish_path, string gma_path, string icon_path )
        {
            return Run( String.Format( "\"{0}\" create -addon \"{1}\" -icon \"{2}\"", gmpublish_path, gma_path, icon_path ) );
        }
    }
}
