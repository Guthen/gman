using System.Windows.Forms;

namespace gman
{
    class Notification
    {
        public static void Inform( string text, string title = "Information" )
        {
            MessageBox.Show( text, title, MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        public static void Error( string text, string title = "Error" )
        {
            MessageBox.Show( text, title, MessageBoxButtons.OK, MessageBoxIcon.Error );
        }
    }
}
