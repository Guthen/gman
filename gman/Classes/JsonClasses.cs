
namespace gman.Classes
{
    /// <summary>
    /// Represents 'main' form settings. 
    /// </summary>
    public class Settings
    {
        public string gmad_path { get; set; }
        public string gmpublish_path { get; set; }
        public string addon_path { get; set; }
        public string output_path { get; set; }
    }

    /// <summary>
    /// Represents 'addon.json' object.
    /// </summary>
    public class Addon
    {
        //  > Static properties
        public static string[] Types = new string[] {
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
        public static string[] Tags = new string[] {
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

        //  > Instance properties
        public string title { get; set; }
        public string type { get; set; }
        public string[] tags { get; set; }
        public string[] ignore { get; set; }
    }
}
