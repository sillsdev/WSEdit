using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Palaso.UI.WindowsForms.WritingSystems;
using Palaso.TestUtilities;
using Palaso.WritingSystems;
using Palaso.WritingSystems.Migration.WritingSystemsLdmlV0To1Migration;

namespace wsedit
{
  internal class DummyWritingSystemHandler

  {

	  public static void onMigration(IEnumerable<LdmlVersion0MigrationStrategy.MigrationInfo> migrationInfo)

	  {

	  }



	  public static void onLoadProblem(IEnumerable<WritingSystemRepositoryProblem> problems)

	  {

	  }



  }

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
			var folder = new TemporaryFolder("WS-Edit");
			var repository = LdmlInFolderWritingSystemRepository.Initialize(folder.Path,
		DummyWritingSystemHandler.onMigration,
		DummyWritingSystemHandler.onLoadProblem);

			var dlg = new WritingSystemSetupDialog(repository);

			dlg.WritingSystemSuggestor.SuggestVoice = true;

//            WSPropertiesDialog dlg = new WSPropertiesDialog();
			dlg.Text = String.Format("{0:s} {1:s}", Application.ProductName, Application.ProductVersion);
			Application.Run(dlg);
		}
	}
}
