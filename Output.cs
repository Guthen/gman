using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gman
{
    public partial class Output : Form
    {
        public string IconName = "myaddon.jpg";

        public Output()
        {
            InitializeComponent();
            CenterToParent();

            // doesn't work
            //tb_output.SelectionLength = 0;
            //b_ok.Focus();
        }

        public void SetOutput( string text )
        {
            //  > Set output
            tb_output.Text = text;

            ///  > Comment output
            string comment = "Success! ";

            /// > GMAD
            //  > Not allowed by whitelist
            var count = get_occurences_count( text, "Not allowed by whitelist"/*, "Filename contains captial letters"*/ );
            if ( count > 0 )
                comment = String.Format( "Failed! {0} unwhitelisted files. ", count );

            //  > Filename capital letters
            count = get_occurences_count( text, "Filename contains captial letters" );
            if ( count > 0 )
                comment += String.Format( "{0} capital filenames.", count );

            /// > GMPUBLISH
            //  > Couln't open the icon
            if ( text.Contains( "Couldn't open the icon!" ) )
                comment = String.Format( "Failed! Icon not found, must be '{0}'", IconName );

            l_output_commentary.Text = comment;
        }

        private int get_occurences_count( string text, string pattern )
        {
            return Regex.Matches( text, pattern ).Count;
        }

        private int get_occurences_count( string text, string pattern_1, string pattern_2 )
        {
            return Math.Max( Regex.Matches( text, pattern_1 ).Count, Regex.Matches( text, pattern_2 ).Count );
        }

        private void b_ok_Click( object sender, EventArgs e ) => Close();

        private void b_copy_all_Click( object sender, EventArgs e )
        {
            tb_output.SelectAll();
            tb_output.Focus();

            Clipboard.SetText( tb_output.Text );
        }
    }
}
