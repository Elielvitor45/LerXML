using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
namespace LeituraXml.Utils
{
    public class Playlist
    {
        public List<Break> Breaks = new List<Break>();
        public XmlNodeList ListadeXMl(XmlDocument doc,String no)
        {
            XmlNodeList listadenos = doc.SelectNodes(no);
            return listadenos;
        }
        public XmlDocument XmlDocumento(String caminho) {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);//Super necessario
            XmlDocument doc = new XmlDocument();
            doc.Load(caminho);
            return doc;
        }

        public void setBreaks(List <XmlNode>list)
        {
            foreach (var item in list)
            {
                Break objBreak = new Break();
                objBreak.Ins = item.Attributes["Ins"]?.Value;
                objBreak.locked = item.Attributes["Locked"]?.Value;
                Breaks.Add(objBreak);
            }


        }



        List<XmlNode> listains = new List<XmlNode>();

        public void GetAllIns(List<XmlNode> list)
        {
            List<XmlNode> insList = new List<XmlNode>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list.Count > 0)
                {
                    foreach (XmlNode childNode in list[0].ChildNodes)
                    {
                        if (childNode.Name.StartsWith("Ins"))
                        {
                            listains.Add(childNode);
                        }
                    }
                }
            }

            
    
        }












    }
}
