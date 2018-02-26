using RemotesStringsFileMaker_cSharp.src;
using System;
using System.IO;

namespace RemotesResourcesExtractor_cSharp
{
    internal class StringsFileHandler
    {
        private XmlChecker xmlChecker;
        private readonly string _STRINGS_XML = "strings.xml";

        public StringsFileHandler()
        {
            this.xmlChecker = new XmlChecker();
        }

        internal void HandleStringsFile(string appDirPath, string newAppPath, bool removeComments)
        {

            //find the xml file destination
            string appFolderPath = Directory.GetDirectories(appDirPath, "app")[0];
            string stringsXmlFileOrigin = new DirectoryInfo(appFolderPath).GetFiles("strings.xml", SearchOption.AllDirectories)[0].FullName;
            string stringsXmlFileDest = newAppPath + "\\" + _STRINGS_XML;
            //copy it to the new location
            File.Copy(stringsXmlFileOrigin, stringsXmlFileDest, true);


            //get package name
            string packageName = new PackageFinder().getPackageName(appDirPath);

            //handle all of the xml changes
            xmlChecker.CheckAndFixXml(stringsXmlFileDest, packageName, removeComments);
        }
    }
}