using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * Scoop the package name of a an app from the \app\build.gradle file 
 */

namespace RemotesStringsFileMaker_cSharp.src
{
    class PackageFinder
    {
        private readonly string _APPLICATION_ID = "applicationId";
        private readonly string _BUILD_GRADLE_PATH = "\\app\\build.gradle";

        public String getPackageName(String applicationPath)
        {
            int counter = 0;
            string line;

            var text = Console.ReadLine();
            String loc = applicationPath + _BUILD_GRADLE_PATH;
            System.IO.StreamReader file =
                new System.IO.StreamReader(loc);

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(_APPLICATION_ID))
                {
                    String part1 = line.Substring(line.IndexOf('\"') + 1);
                    return part1.Substring(0, part1.IndexOf('\"'));
                }

                counter++;
            }

            file.Close();
            return null;
        }
    }
}
