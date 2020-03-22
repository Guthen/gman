using System;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;

using gman.Classes;
using gman.Forms;

namespace gman
{
	public partial class Main : Form
	{
		readonly string file_name_settings = "settings.json";
		readonly string folder_name_gman = ".gman";
		readonly string version = "v0.4.0";

		//  > Constructor
		public Main()
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
		/// <returns>Whenever path is correct.</returns>
		private bool CheckAddonPath()
		{
			if( textbox_settings_paths_addon.Text.Length == 0 )
			{
				Notification.Error( "Please specify the 'Addon' path in the Settings!" );
				return false;
			}
			return true;
		}

		/// <summary>
		/// Check if the addon path is specified, and show a message if it's not. Then, test if file exists, if not, an error notification is sent.
		/// </summary>
		/// <param name="is_file">Whenever the file check should be made.</param>
		/// <returns>Whenever path is correct and file exists.</returns>
		private bool CheckAddonPath( bool is_file )
		{
			if( !CheckAddonPath() )
				return false;

			if( is_file && !File.Exists( textbox_settings_paths_addon.Text ) )
			{
				Notification.NoFileError( textbox_settings_paths_addon.Text );
				return false;
			}
			return true;
		}

		/// <summary>
		/// Check if the given file path is a .gma file.
		/// </summary>
		/// <param name="path">File path</param>
		/// <returns>Whenever the file is a .gma file.</returns>
		private bool CheckGMA( string path )
		{
			if ( !( StringPath.GetExtension( path ) == ".gma" ) )
			{
				Notification.Error( $"File '{path}' isn't a .gma file! Please specify a correct file path!" );
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
				return;
			if( !File.Exists( addon_path + "/addon.json" ) )
			{
				Notification.NoFileError( addon_path + "/addon.json" );
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
			if( stdout.Length == 0 )
				return;

			Notification.Information( "gmad.exe:\n" + stdout );
		}

		private void button_actions_gmad_extract_Click( object sender, EventArgs e )
		{
			SaveSettings();

			//  > Get paths
			string gmad_path = textbox_settings_paths_gmad.Text;
			string addon_path = textbox_settings_paths_addon.Text;
			string output = GetOutput( StringPath.RemoveExtension( addon_path ) );

			//  > Check
			if( !CheckAddonPath( true ) )
				return;
			if( !( CheckGMA( addon_path ) ) )
				return;

			//  > Create directory
			if( !Directory.Exists( output ) )
			{
				Console.WriteLine( output );
				Directory.CreateDirectory( output );
			}

			//  > Extract gma
			string stdout = Shell.Execute( gmad_path, $"extract -file {addon_path} -out {output}" );
			if( stdout.Length == 0 )
				return;

			Notification.Information( "gmad.exe:\n" + stdout );
		}

		//  > gmpublish functions
		private void button_actions_gmpublish_publish_Click( object sender, EventArgs e )
		{
			SaveSettings();

			//  > Get paths
			string gmpublish_path = textbox_settings_paths_gmpublish.Text;
			string addon_path = textbox_settings_paths_addon.Text;
			string icon_path = StringPath.RemoveExtension( addon_path ) + ".jpg";

			//	> Check .gma
			if ( !CheckAddonPath( true ) )
				return;
			if ( !( CheckGMA( addon_path ) ) )
				return;
			//	> Check icon
			if ( !File.Exists( icon_path ) )
			{
				Notification.NoFileError( icon_path );
			}

			//	> Publish
			string stdout = Shell.Execute( gmpublish_path, $"create -icon {icon_path} -addon {addon_path}" );
			Notification.Information( "gmpublish.exe:\n" + stdout );

			//	> Write ID
			Match match = Regex.Match( stdout, @"[id=](\d+)" );
			string id = ( match.Success ? match.Value : "null" ).Replace( "=", "" );

			File.WriteAllText( StringPath.RemoveExtension( addon_path ) + ".id", id );
		}

		private void button_actions_gmpublish_update_Click( object sender, EventArgs e )
		{
			SaveSettings();

			//  > Get paths
			string gmpublish_path = textbox_settings_paths_gmpublish.Text;
			string addon_path = textbox_settings_paths_addon.Text;
			string icon_path = StringPath.RemoveExtension( addon_path ) + ".jpg";
			string id_path = StringPath.RemoveExtension( addon_path ) + ".id";

			string id = File.ReadAllText( id_path );

			//	> Check .gma
			if( !CheckAddonPath( true ) )
				return;
			if( !( CheckGMA( addon_path ) ) )
				return;
			//	> Check icon
			//if( !File.Exists( icon_path ) )
			//{
			//	Notification.NoFileError( icon_path );
			//}

			//	> Publish
			string stdout = Shell.Execute( gmpublish_path, $"update -icon {icon_path} -addon {addon_path} -id {id}" );
			Notification.Information( "gmpublish.exe:\n" + stdout );
		}

		private void button_actions_gmpublish_list_Click( object sender, EventArgs e )
		{
			SaveSettings();

			//  > Get paths
			string gmpublish_path = textbox_settings_paths_gmpublish.Text;

			//  > Show list
			string stdout = Shell.Execute( gmpublish_path, "list" );
			if( stdout.Length == 0 )
				return;

			Notification.Information( "gmpublish.exe:\n" + stdout );
		}

		//  > gman functions
		private void button_actions_gman_generate_Click( object sender, EventArgs e )
		{
			SaveSettings();

			//  > Show up new form
			GenerateAddonMenu menu = new GenerateAddonMenu();
			menu.ignore.Add( folder_name_gman + "/*" );
			menu.SetAddonPath( textbox_settings_paths_addon.Text );
			if( !menu.IsDisposed )
				menu.ShowDialog( this );
		}
	}
}
