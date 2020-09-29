using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace gman
{
    class AddonJSON
    {
        public static string[] Types = new string[]
        {
            "ServerContent",
            "gamemode",
            "map",
            "weapon",
            "vehicle",
            "npc",
            "tool",
            "effects",
            "model",
        };

        public static string[] Tags = new string[]
        {
            "fun",
            "roleplay",
            "scenic",
            "movie",
            "realism",
            "cartoon",
            "water",
            "comic",
            "build",
        };

        public string title;
        public string type;
        public string[] tags = new string[2];
        public string[] ignore;

        public AddonJSON( string title, string type, string[] tags, string[] ignore )
        {
            //  > Title
            this.title = title;

            //  > Type
            if ( Types.Contains( type ) )
                this.type = type;
            else
                throw new ArgumentException( String.Format( "Type '{0}' is not a valid type.", type ) );

            //  > Tags
            for ( int i = 0; i < 2; i++ )
            {
                if ( Tags.Contains( tags[i] ) )
                    this.tags[i] = tags[i];
                else
                    throw new ArgumentException( String.Format( "Tag {0} is not a valid tag.", i + 1 ) );
            }

            //  > Ignore
            this.ignore = ignore;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject( this, Formatting.Indented );
        }
    }
}
