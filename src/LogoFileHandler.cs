using System;
using System.IO;
using System.Windows.Forms;

namespace RemoteAppMaker
{
    internal class LogoFileHandler
    {
        private readonly string _LOGO_PNG = "logo.png";
        private readonly string _LAUNCHER_PNG = "launcher.png";
        private readonly string _REMOTE_LAUNCHER_PNG = "remote_launcher.png";

        internal void CopyLogoFile(string oldAppPath, string newAppPath)
        {
            //prototype remote resources
            String appFolderPath = Directory.GetDirectories(oldAppPath, "app")[0];
            String srcFolderPath = Directory.GetDirectories(appFolderPath, "src")[0];
            String mainFolderPath = Directory.GetDirectories(srcFolderPath, "main")[0];

            FileInfo oldLogoFilePath;

            if (new DirectoryInfo(mainFolderPath).GetFiles(_LOGO_PNG, SearchOption.AllDirectories).Length != 0)
                oldLogoFilePath = new DirectoryInfo(mainFolderPath).GetFiles(_LOGO_PNG, SearchOption.AllDirectories)[0];
            else if (new DirectoryInfo(mainFolderPath).GetFiles(_LAUNCHER_PNG, SearchOption.AllDirectories).Length != 0)
            {
                MessageBox.Show("couldnt find 'logo.png' file, but i found 'launcher.png' instead...");
                oldLogoFilePath = new DirectoryInfo(mainFolderPath).GetFiles(_LAUNCHER_PNG, SearchOption.AllDirectories)[0];
            }
            else if (new DirectoryInfo(mainFolderPath).GetFiles(_REMOTE_LAUNCHER_PNG, SearchOption.AllDirectories).Length != 0)
            {
                MessageBox.Show("couldnt find 'logo.png' nor 'launcher.png' files, but i found 'remote_launcher.png' instead...");
                oldLogoFilePath = new DirectoryInfo(mainFolderPath).GetFiles(_REMOTE_LAUNCHER_PNG, SearchOption.AllDirectories)[0];
            }
            else
            {
                MessageBox.Show("sorry. couldn't find any remote logo. Remember that "+appFolderPath + "is missing a logo");
                return;
            }

        File.Copy(oldLogoFilePath.FullName, newAppPath+"\\"+ _LOGO_PNG, true);
        }
    }
}