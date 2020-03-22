using System.Windows.Forms;

namespace gman.Classes
{
	class Notification
	{
		/// <summary>
		/// Show up an error message.
		/// </summary>
		/// <param name="text">Error message to show up</param>
		public static void Error( string text )
		{
			MessageBox.Show( text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
		}

		/// <summary>
		/// Show up an information message.
		/// </summary>
		/// <param name="text">Information message to show up</param>
		public static void Information( string text )
		{
			MessageBox.Show( text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information );
		}

		/// <summary>
		/// Show up a file error message.
		/// </summary>
		/// <param name="path">Inexistant file path</param>
		public static void NoFileError( string path )
		{
			Notification.Error( $"File '{path}' isn't detected! Please specify a correct file path!" );
		}
	}
}
