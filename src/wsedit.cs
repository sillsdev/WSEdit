using System;
using System.Windows.Forms;
using Palaso.UI.WindowsForms.WritingSystems;

namespace wsedit
{
	static class WSEdit
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			WSPropertiesDialog dlg = new WSPropertiesDialog();
			dlg.Text = String.Format("{0:s} {1:s}", Application.ProductName, Application.ProductVersion);
			Application.Run(dlg);
		}
	}
}