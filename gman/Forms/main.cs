using System;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

using gman.Classes;
using gman.Forms;

namespace gman
{
    public partial class main : Form
    {
        readonly string file_name_settings = "settings.json";
        readonly string folder_name_gman = ".gman";
        readonly string version = "v0.1.0";

        //  > Constructor
        public main()
        {
            InitializeComponent();

            //  > Version in title
            this.Text += $" ({version})";

            //  > Load 'settings.json'
            if( File.Exists( file_name_settings ) )
            {
                string content = File.ReadAllText( file_name_settings );
                Settings settings = JsonSerializer.Deserialize<Settings>( content );

                textbox_settings_paths_gmad.Text = settings.gmad_path;
                textbox_settings_paths_gmpublish.Text = settings.gmpublish_path;
                textbox_settings_paths_addon.Text = settings.addon_path;
                textbox_settings_paths_output.Text = settings.output_path;
                Console.WriteLine( "Settings: loaded" );
            }
        }

        //  > Utility functions
        /// <summary>
        /// Get output path.
        /// </summary>
        /// <param name="fallback">String which will be return if the output is not available.</param>
        /// <returns>Output path or fallback.</returns>
        private string GetOutput( string fallback )
        {
            string output = textbox_settings_paths_output.Text;
            return output.Length == 0 ? fallback : output;
        }

        /// <summary>
        /// Save settings in a JSON file
        /// </summary>
        private void SaveSettings()
        {
            Settings settings = new Settings
            {
                gmad_path = textbox_settings_paths_gmad.Text,
                gmpublish_path = textbox_settings_paths_gmpublish.Text,
                addon_path = textbox_settings_paths_addon.Text,
                output_path = textbox_settings_paths_output.Text,
            };

            File.WriteAllText( file_name_settings, JsonSerializer.Serialize( settings ) );
            Console.WriteLine( "Settings: saved" );
        }

        /// <summary>
        /// Check if the addon path is specified, and show a message if it's not.
        /// </summary>
        /// <returns>Whenever path is correct</returns>
        private bool CheckAddonPath()
        {
            if( textbox_settings_paths_addon.Text.Length == 0 )
            {
                MessageBox.Show( "Please specify the 'Addon' path in the Settings!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return false;
            }
            return true;
        }

        //  > gmad.exe functions
        private void button_actions_gmad_create_Click( object sender, EventArgs e )
        {
            SaveSettings();

            //  > Get paths
            string gmad_path = textbox_settings_paths_gmad.Text;
            string addon_path = textbox_settings_paths_addon.Text;
            string path = GetOutput( $"{addon_path}/{folder_name_gman}" );

            //  > Check
            if( !CheckAddonPath() )
            {
                return;
            }
            if( !File.Exists( addon_path + "/addon.json" ) )
            {
                MessageBox.Show( "File 'addon.json' isn't detected! Please create it manually or generate it with the 'Generate' button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            //  > Directory check
            if( !Directory.Exists( path ) )
            {
                Directory.CreateDirectory( path );
                Console.WriteLine( $"Directory: '{path}' created" );
            }

            //  > Create gma
            string stdout = Shell.Execute( gmad_path, $"create -folder {addon_path} -out {path}/{StringPath.GetFolderName( addon_path )}.gma" );
            //Console.WriteLine( "gmad.exe: " + stdout );

            MessageBox.Show( "gmad.exe: " + stdout, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void button_actions_gmad_extract_Click( object sender, EventArgs e )
        {
            SaveSettings();

            //  > Get paths
            string gmad_path = textbox_settings_paths_gmad.Text;
            string addon_path = textbox_settings_paths_addon.Text;
            string output = GetOutput( StringPath.RemoveExtension( addon_path ) );

            //  > Check
            if( !CheckAddonPath() )
            {
                return;
            }

            //  > Create directory
            if( !Directory.Exists( output ) )
            {
                Console.WriteLine( output );
                Directory.CreateDirectory( output );
            }

            //  > Extract gma
            string stdout = Shell.Execute( gmad_path, $"extract -file {addon_path} -out {output}" );

            MessageBox.Show( "gmad.exe: " + stdout, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        //  > gman functions
        private void button_actions_gman_generate_Click( object sender, EventArgs e )
        {
            SaveSettings();

            //  > Show up new form
            generate_addon menu = new generate_addon();
            menu.ignore.Add( folder_name_gman + "/*" );
            menu.SetAddonPath( textbox_settings_paths_addon.Text );
            if( !menu.IsDisposed )
            {
                menu.ShowDialog( this );
            }
        }
    }
}
