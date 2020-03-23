using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

using gman.Classes;

namespace gman.Forms
{
    public partial class GenerateAddonMenu : Form
    {
        /// <summary>
        /// Ignored files/folders list.
        /// </summary>
        public List<string> ignore;

        //  > Constructor
        public GenerateAddonMenu()
        {
            InitializeComponent();

            //  > Load tags & types
            combobox_settings_type.Items.AddRange( Addon.Types );
            combobox_settings_tag1.Items.AddRange( Addon.Tags );
            combobox_settings_tag2.Items.AddRange( Addon.Tags );
        }

        /// <summary>
        /// Generate the default ignore list.
        /// </summary>
        public void GenerateIgnoreList()
        {
            ignore = new List<string>
            {
                "*.cmd",
                "*.ini",
                "*.lnk",
                "*.url",
                "*.md",
                ".gitignore",
                ".gitattributes",
                ".git/*",
                ".vscode/*",
            };
        }

        /// <summary>
        /// Add element to the ignore list.
        /// </summary>
        /// <param name="element">Element to add.</param>
        public void AddIgnoreListElement( string element )
        {
            ignore.Add( element );
        }

        /// <summary>
        /// Set addon path TextBox's text.
        /// </summary>
        /// <param name="path">Path to set.</param>
        public void SetAddonPath( string path )
        {
            textbox_settings_path.Text = path;

            LoadSettings();
        }

        /// <summary>
        /// Load settings from 'addon.json' of the folder if exists.
        /// </summary>
        private void LoadSettings()
        {
            //  > Load 'addon.json' if exists
            string path = textbox_settings_path.Text + "/addon.json";
            if( File.Exists( path ) )
            {
                //  > Get JSON content
                Addon addon;
                try
                {
                    addon = JsonSerializer.Deserialize<Addon>( File.ReadAllText( path ) );
                }
                catch( JsonException e )
                {
                    Notification.Error( $"{path}:\n{e.Message}" );
                    Close();

                    return;
                }

                //  > Load current settings
                textbox_settings_title.Text = addon.title;
                combobox_settings_type.SelectedIndex = combobox_settings_type.FindStringExact( addon.type );
                combobox_settings_tag1.SelectedIndex = combobox_settings_tag1.FindStringExact( addon.tags[0] );
                combobox_settings_tag2.SelectedIndex = combobox_settings_tag1.FindStringExact( addon.tags[1] );
            }
        }

        private void button_actions_generate_Click( object sender, EventArgs e )
        {
            //  > Checks
            if ( !( StringPath.GetExtension( textbox_settings_path.Text ).Length == 0 ) ) {
                Notification.Error( $"File '{textbox_settings_path.Text}' isn't a directory! Please specify a valid directory!" );
                return;
            }

            Addon addon;
            try
            {
                addon = new Addon
                {
                    title = textbox_settings_title.Text,
                    type = combobox_settings_type.SelectedItem.ToString(),
                    tags = new string[]
                    {
                        combobox_settings_tag1.SelectedItem.ToString(),
                        combobox_settings_tag2.SelectedItem.ToString(),
                    },
                    ignore = ignore.ToArray(),
                };
            }
            catch ( NullReferenceException exception )
            {
                Notification.Error( "You didn't specified all fields, unable to generate the JSON file." );
                return;
            }

            string path = textbox_settings_path.Text + "/addon.json";
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            File.WriteAllText( path, JsonSerializer.Serialize( addon, options ) );

            if( File.Exists( path ) )
                Notification.Information( "Success! File 'addon.json' has been generated!" );
        }

        //  > Form elements functions
        private void textbox_settings_path_TextChanged( object sender, EventArgs e )
        {
            LoadSettings();
        }

        private void button_settings_output_browse_Click( object sender, EventArgs e )
        {
            if ( folderbrowser_settings_addon_browser.ShowDialog() == DialogResult.OK )
            {
                textbox_settings_path.Text = folderbrowser_settings_addon_browser.SelectedPath;
                //LoadSettings();
            }
        }
    }
}
