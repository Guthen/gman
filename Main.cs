using System;
using System.Media;
using System.IO;
using System.Windows.Forms;
using gman.Classes;
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using Microsoft.WindowsAPICodePack.Controls.WindowsForms;

namespace gman
{
    public partial class Main : Form
    {
        public string Version = "v2020.09.30";
        public string Author = "by Guthen";

        public Main()
        {
            InitializeComponent();
            CenterToScreen();

            //  > Set default parameters
            l_version.Text = Version;
            l_author.Text = Author;
            cob_create_json_type.Items.AddRange( AddonJSON.Types );
            cob_create_json_tag_1.Items.AddRange( AddonJSON.Tags );
            cob_create_json_tag_2.Items.AddRange( AddonJSON.Tags );

            RefreshForm();
        }

        public void RefreshForm()
        {
            var folder = tb_create_folder.Text;

            //  > JSON
            tb_create_json_ignore.Text = String.Format( ".gman/*\r\n{0}.jpg", Path.GetFileName( Path.GetDirectoryName( tb_create_folder.Text + "/" ) ) );
            b_create_json_find.Enabled = File.Exists( Path.Combine( folder, "addon.json" ) );

            //  > GMA
            gb_create_gma.Enabled = b_create_json_find.Enabled;

            //  > Buttons
            b_create_gma_publish.Enabled = File.Exists( Path.Combine( folder, ".gman/.gma" ) );
            b_create_gma_update.Enabled = File.Exists( Path.Combine( folder, ".gman/.id" ) );
        }

        public string GetGmadPath()
        {
            return cb_settings_paths.Checked ? tb_settings_paths_gmad.Text : Path.Combine( tb_settings_gmh.Text, "bin/gmad.exe" );
        }

        public string GetGmpublishPath()
        {
            return cb_settings_paths.Checked ? tb_settings_paths_gmpublish.Text : Path.Combine( tb_settings_gmh.Text, "bin/gmpublish.exe" );
        }

        private void compress_addon()
        {
            //  > Create .gman folder
            var folder = tb_create_folder.Text;
            create_gman_folder( folder );

            //  > Compress
            var out_path = Path.Combine( folder, ".gman/.gma" );
            var output = GMA.Compress( GetGmadPath(), folder, out_path );

            //  > Output
            var output_form = new Output();
            output_form.SetOutput( output );
            output_form.ShowDialog( this );
        }

        private void error_control( Control control, string message )
        {
            //  > Focus & Tooltip
            control.Focus();
            tool_tip.Show( message, control, 1500 );

            //  > Sound Play
            SystemSounds.Beep.Play();
        }

        private void create_gman_folder( string path )
        {
            path = Path.Combine( path, ".gman" );

            if ( !Directory.Exists( path ) )
                Directory.CreateDirectory( path ).Attributes |= FileAttributes.Hidden;
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
            {
                gb_create_gma.Enabled = false;
                b_create_json_find.Enabled = false;
                return;
            }

            //  > Read & Convert
            var json = File.ReadAllText( path );
            try
            {
                RefreshForm();
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

        //  > Find JSON
        private void b_create_json_find_Click( object sender, EventArgs e )
        {
            System.Diagnostics.Process.Start( "explorer.exe", String.Format( "/select, \"{0}\"", Path.Combine( tb_create_folder.Text, "addon.json" ) ) );
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
                RefreshForm();           
                
                Notification.Inform( String.Format( "JSON file has been generated and saved in '{0}'.", path ) );
            }
            catch ( BadFormArgumentException e )
            {
                Control control = null;
                switch ( e.FormID )
                {
                    case "type":
                        control = cob_create_json_type;
                        break;
                    case "tag_1":
                        control = cob_create_json_tag_1;
                        break;
                    case "tag_2":
                        control = cob_create_json_tag_2;
                        break;
                }

                error_control( control, e.Message );
            }
        }

        private void b_create_gma_compress_Click( object sender, EventArgs e )
        {
            compress_addon();
            RefreshForm();
        }

        private void b_create_gma_publish_Click( object sender, EventArgs e )
        {
            //  > Publish
            var folder = tb_create_folder.Text;

            var gma = Path.Combine( folder, ".gman/.gma" );
            var icon = Path.GetFileName( Path.GetDirectoryName( folder + "/" ) ) + ".jpg";
            var output = GMA.Publish( GetGmpublishPath(), gma, Path.Combine( folder, icon ) );

            //  > Output
            var output_form = new Output();
            output_form.IconName = icon;
            output_form.SetOutput( output );
            output_form.ShowDialog( this );

            //  > Save ID
            var match_id = Regex.Match( output, @"http://steamcommunity.com/sharedfiles/filedetails/\?id=(\d+)" );
            if ( !match_id.Success )
                return;

            var id = match_id.Groups[1].Value;
            File.WriteAllText( Path.Combine( folder, ".gman/.id" ), id );
        }

        private void b_create_gma_update_Click( object sender, EventArgs e )
        {
            var folder = tb_create_folder.Text;

            //  > Changes
            var changes_form = new StringRequest();
            changes_form.SetTitle( "Update Changes" );
            if ( changes_form.ShowDialog( this ) == DialogResult.Cancel )
                return;

            //  > Update
            var id = File.ReadAllText( Path.Combine( folder, ".gman/.id" ) );
            var gma = Path.Combine( folder, ".gman/.gma" );
            var output = GMA.Update( GetGmpublishPath(), gma, id, changes_form.GetText() );

            //  > Output
            var output_form = new Output();
            output_form.SetOutput( output );
            output_form.ShowDialog( this );
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
    }
}
