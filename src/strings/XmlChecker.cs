using RemotesResourcesExtractor_cSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RemotesStringsFileMaker_cSharp.src
{
    class XmlChecker
    {
        private readonly string _CMNT_PACKAGE_NAME = "Package Name ";
        private readonly string _CMNT_MISSING = " IS MISSING";

        private readonly string _RESOURCES_NODE_TAG = "string";

        private readonly string _ATT_NAME_KEY = "name";
        private readonly string _ATT_NAME_VAL = "package_name";

        private readonly string _ATT_TRANSLATEABLE_KEY = "translatable";
        private readonly string _ATT_TRANSLATEABLE_VAL = "false";


        public void CheckAndFixXml(String stringsXmlFileDest, String packageName, bool removeComments)
        {

            //load the xml and prepare the checklist
            XmlDocument document = new XmlDocument();
            document.Load(@stringsXmlFileDest);
            var checkList = new Dictionary<string, bool>();
            FillCheckList(checkList);
            var elementRes = document.GetElementsByTagName("resources")[0];
            //insert the package name comment and the content provider node
            elementRes.AppendChild(document.CreateComment(_CMNT_PACKAGE_NAME + packageName));

            List<XmlNode> toDeleteNodes = new List<XmlNode>();
            foreach (XmlNode node in elementRes.ChildNodes)
            {

                //todo: if its a comment then leave it be!
                if (node.Name == "#comment")
                {
                    toDeleteNodes.Add(node);
                    continue;
                }

                string tagName = node.Attributes[0].Value;
                if (checkList.ContainsKey(tagName))
                    checkList[tagName] = true;
            }

            if(removeComments)
                RemoveToDeleteNodes(elementRes, toDeleteNodes);

            MarkCheckList(checkList, elementRes, packageName, document);
            document.Save(stringsXmlFileDest);
        }

        private void RemoveToDeleteNodes(XmlNode elementRes, List<XmlNode> toDeleteNodes)
        {
            foreach (XmlNode node in toDeleteNodes)
                elementRes.RemoveChild(node);
        }

        private void MarkCheckList(Dictionary<string, bool> checkList, XmlNode elementRes, string packageName, XmlDocument document)
        {
            foreach (String key in checkList.Keys)
            {
                if (key == _ATT_NAME_VAL && !checkList[key])
                {
                    AddPackageTag(document, elementRes, packageName);
                    continue;
                }
                if (!checkList[key])
                {
                    elementRes.AppendChild(document.CreateComment(key + _CMNT_MISSING));
                }
            }
        }

      

        private void AddPackageTag(XmlDocument document, XmlNode elementRes, string packageName)
        {
            XmlElement fileProviderNode = document.CreateElement(_RESOURCES_NODE_TAG);
            fileProviderNode.SetAttribute(_ATT_NAME_KEY, _ATT_NAME_VAL);
            fileProviderNode.SetAttribute(_ATT_TRANSLATEABLE_KEY, _ATT_TRANSLATEABLE_VAL);
            fileProviderNode.InnerText = packageName + ".fileprovider";
            elementRes.AppendChild(fileProviderNode);

        }

        private void FillCheckList(Dictionary<string, bool> checkList)
        {
            checkList.Add("app_name", false);
            checkList.Add("app_short_name", false);
            checkList.Add("app_id", false);
            checkList.Add("banner_ad_unit_id", false);
            checkList.Add("interstitial_ad_unit_id", false);
            checkList.Add("reward_ad_unit_id", false);
            checkList.Add(_ATT_NAME_VAL, false);
        }
    }
}
