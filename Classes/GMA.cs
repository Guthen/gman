using System;
using System.Diagnostics;
using System.IO;

namespace gman.Classes
{
    static class GMA
    {
        private static string Run( string file_name, string args )
        {
            if ( !File.Exists( file_name ) )
                return "Executable not found at '" + file_name + "'!";

            var process = new Process()
            {
                StartInfo =
                {
                    FileName = file_name,
                    Arguments = args,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                }
            };

            process.Start();
            process.WaitForExit();

            return process.StandardOutput.ReadToEnd();
        }

        public static string Compress( string gmad_path, string folder_path, string out_path )
        {
            Console.WriteLine( "{0} out to {1}" );
            return Run( gmad_path, String.Format( "create -folder \"{0}\" -out \"{1}\"", folder_path, out_path ) );
        }

        public static string Publish( string gmpublish_path, string gma_path, string icon_path )
        {
            return Run( gmpublish_path, String.Format( "create -addon \"{0}\" -icon \"{1}\"", gma_path, icon_path ) );
        }

        public static string Update( string gmpublish_path, string gma_path, string id, string changes )
        {
            return Run( gmpublish_path, String.Format( "update -addon \"{0}\" -id \"{1}\" -changes \"{2}\"", gma_path, id, changes ) );
        }
    }
}
