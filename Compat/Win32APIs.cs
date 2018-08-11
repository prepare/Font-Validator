using System;
using System.Windows.Forms;

namespace Win32APIs
{
  
    public class SH
    {
        public static string BrowseForFolder ()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description =
                "Select the directory to save XML font reports to";

            folderBrowserDialog.ShowNewFolderButton = true;

            // default to user's home, allow navigate to everywhere else
            folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            DialogResult result = folderBrowserDialog.ShowDialog();
            if( result == DialogResult.OK )
            {
                return folderBrowserDialog.SelectedPath;
            } else {
                return null; //compat
            }
        }
    }
}
