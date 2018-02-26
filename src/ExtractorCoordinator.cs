using RemoteAppMaker;
using System;
using System.IO;
using System.Windows.Forms;

namespace RemotesResourcesExtractor_cSharp
{
    internal class ExtractorCoordinator
    {

        internal void Coordinate(string remotesRootPath, string remotesPathDest, string remotesNamesPrefix, bool removeComments)
        {
            //set local instances
            LogoFileHandler logoFileHandler = new LogoFileHandler();
            StringsFileHandler stringsFileHandler = new StringsFileHandler();


            //run on all of the applications folders which start with the name Remote for..
            String[] appsDirectories = Directory.GetDirectories(remotesRootPath, remotesNamesPrefix+"*");
            //FileInfo[] remotesApplications = new DirectoryInfo(remotesRootPath).GetFiles("Remote for TalkTalk", SearchOption.TopDirectoryOnly);
            foreach (String appDirPath in appsDirectories)
            {


                //create the new directory for the remote
                String appName = appDirPath.Substring(appDirPath.LastIndexOf("\\")+1);
                String newAppPath = remotesPathDest + "\\" + appName;
                Directory.CreateDirectory(remotesPathDest + "\\" + appName);

                //copy the strings file
                //string stringsXmlFileDest = stringsFileCopier.CopyStringsFile(appDirPath, newAppPath);

                //fix strings file
                stringsFileHandler.HandleStringsFile(appDirPath, newAppPath, removeComments);

             

                //copy the logo
                logoFileHandler.CopyLogoFile(appDirPath, newAppPath);
            }

            MessageBox.Show("all done! ("+appsDirectories.Length+" values)");
        }
    }
}