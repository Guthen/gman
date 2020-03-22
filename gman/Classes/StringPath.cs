using System.Text.RegularExpressions;

namespace gman.Classes
{
    class StringPath
    {
        /// <summary>
        /// Remove extension of given path.
        /// </summary>
        /// <param name="path">Path to remove extension.</param>
        /// <returns>Path without extension.</returns>
        public static string RemoveExtension( string path )
        {
            return Regex.Replace( path, @"[.](\w+)\z", "" );
        }

        /// <summary>
        /// Get extension of given path.
        /// </summary>
        /// <param name="path">Path to get extension.</param>
        /// <returns>Extensin</returns>
        public static string GetExtension( string path )
        {
            Match match = Regex.Match( path, @"[.](\w+)\z" );
            return match.Success ? match.Value : "";
        }

        /// <summary>
        /// Get file name from given path.
        /// </summary>
        /// <param name="path">Path to get file name.</param>
        /// <param name="extension">Whenever should return file name with extension or not.</param>
        /// <returns>File name.</returns>
        public static string GetFileName( string path, bool extension )
        {
            Match match = Regex.Match( path, @"([\w+\d+_])+[.]\w+" );

            string name = match.Success ? match.Value : "";
            return !extension ? RemoveExtension( name ) : name;
        }

        /// <summary>
        /// Get last folder name from given path.
        /// </summary>
        /// <param name="path">Path to get folder name.</param>
        /// <returns>Folder name.</returns>
        public static string GetFolderName( string path )
        {
            if( !path.EndsWith( "/" ) )
            {
                path = path + "/";
            }

            Match match = Regex.Match( Regex.Replace( path, @"\\", "/" ), @"([\w+\d+_])+/\z" );

            return match.Success ? match.Value.Replace( "/", "" ) : "";
        }
    }
}
