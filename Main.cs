using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gman.Classes;
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;

namespace gman
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CenterToScreen();

            //  > Set default parameters
            cob_create_json_type.Items.AddRange( AddonJSON.Types );
            cob_create_json_tag_1.Items.AddRange( AddonJSON.Tags );
            cob_create_json_tag_2.Items.AddRange( AddonJSON.Tags );
        }

        public string GetGmadPath()
        {
            return cb_settings_paths.Checked ? tb_settings_paths_gmad.Text : Path.Combine( tb_settings_gmh.Text, "bin/gmad.exe" );
        }

        public string GetGmpublishPath()
        {
            return cb_settings_paths.Checked ? tb_settings_paths_gmpublish.Text : Path.Combine( tb_settings_gmh.Text, "bin/gmpublish.exe" );
        }

        private void create_gman_folder( string path )
        {
            path = Path.Combine( path, ".gman" );

            if ( !Directory.Exists( path ) )
            {
                DirectoryInfo dir = Directory.CreateDirectory( path );
                dir.Attributes |= FileAttributes.Hidden;
            }
        }

        private void choose_folder_dialog( TextBox text_box )
        {
            //  > Choose folder dialog
            var dialog = new CommonOpenFileDialog()
            {
                InitialDirectory = text_box.Text,
                IsFolderPicker = true,
            };

            //  > Change folder path
            if ( dialog.ShowDialog() == CommonFileDialogResult.Ok )
            {
                text_box.Text = dialog.FileName;
            }
        }

        //
        ///  > Category: Create
        //
        private void b_create_folder_Click( object sender, EventArgs ea ) {
            choose_folder_dialog( tb_create_folder );

            ///  > JSON
            //  > Check Existence
            var path = Path.Combine( tb_create_folder.Text, "addon.json" );
            if ( !File.Exists( path ) )
                return;

            //  > Read & Convert
            var json = File.ReadAllText( path );
            try
            {
                var addon = JsonConvert.DeserializeObject<AddonJSON>( json );

                //  > Replace
                tb_create_json_title.Text = addon.title;
                tb_create_json_ignore.Text = String.Join( "\r\n", addon.ignore );
                cob_create_json_type.Text = addon.type;
                cob_create_json_tag_1.Text = addon.tags[0];
                cob_create_json_tag_2.Text = addon.tags[1];
            }
            catch ( JsonSerializationException e )
            {
                Notification.Error( e.Message, "JSON Parsing Error" );
            }
            catch ( ArgumentException e )
            {
                Notification.Error( e.Message, "JSON Reading Bad Argument" );
            }
        }

        //
        ///  > Category: Settings
        //
        private void b_settings_gmh_Click( object sender, EventArgs e ) => choose_folder_dialog( tb_settings_gmh );
        private void b_settings_gmh_gmad_Click( object sender, EventArgs e ) => choose_folder_dialog( tb_settings_paths_gmad );
        private void b_settings_gmh_gmpublish_Click( object sender, EventArgs e ) => choose_folder_dialog( tb_settings_paths_gmpublish );

        //  > Enables/Disables customs paths
        private void cb_settings_paths_CheckedChanged( object sender, EventArgs e )
        {
            bool check = cb_settings_paths.Checked;

            //  > gmad
            tb_settings_paths_gmad.Enabled = check;
            b_settings_paths_gmad.Enabled = check;
            l_settings_paths_gmad.Enabled = check;

            //  > gmpublish
            tb_settings_paths_gmpublish.Enabled = check;
            b_settings_paths_gmpublish.Enabled = check;
            l_settings_paths_gmpublish.Enabled = check;
        }

        //  > Generate JSON
        private void b_create_json_generate_Click( object sender, EventArgs ea )
        {
            try
            {
                var addon = new AddonJSON( 
                    tb_create_json_title.Text,
                    cob_create_json_type.Text,
                    new string[2] {
                        cob_create_json_tag_1.Text,
                        cob_create_json_tag_2.Text,
                    },
                    tb_create_json_ignore.Text.Replace( "\r\n", "\n" ).Split( '\n' )
                );

                var path = Path.Combine( tb_create_folder.Text, "addon.json" );
                File.WriteAllText( path, addon.ToString() );
                Notification.Inform( String.Format( "JSON file has been generated and saved in '{0}'.", path ) );
            }
            catch ( ArgumentException e )
            {
                Notification.Error( e.Message, "Bad Argument" );
            }
        }

        private void b_create_workshop_compress_Click( object sender, EventArgs e )
        {
            //  > TODO: put this into a function and ask for notification for publish button
            //  > Create .gman folder
            var folder = tb_create_folder.Text;
            create_gman_folder( folder );

            //  > Compress
            var out_path = Path.Combine( folder, ".gman/.gma" );
            Notification.Inform( GMA.Compress( GetGmadPath(), folder, out_path ) );
        }

        private void b_create_workshop_publish_Click( object sender, EventArgs e )
        {
            //  > Create .gman folder & Compress
            //b_create_workshop_compress_Click( sender, e );

            //  > Publish
            var folder = tb_create_folder.Text;
            Console.WriteLine( Path.GetDirectoryName( folder + "/" ) );
            Console.WriteLine( Path.GetFullPath( folder + "/" ) );
            return;
            var icon_path = Path.GetDirectoryName( folder + "/" ) + ".jpg";
            Notification.Inform( GMA.Publish( GetGmpublishPath(), Path.Combine( tb_create_folder.Text, ".gman/.gma" ), icon_path ) );
        }
    }
}
