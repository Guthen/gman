using System.Text.RegularExpressions;

namespace gman.Classes
{
    class StringPath
    {
        public static string RemoveExtension( string path )
        {
            return Regex.Replace( path, @"[.](\w+)\z", "" );
        }

        public static string GetFileName( string path, bool extension )
        {
            Match match = Regex.Match( path, @"([\w+\d+_])+[.]\w+" );

            string name = match.Success ? match.Value : "";
            return !extension ? RemoveExtension( name ) : name;
        }

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
