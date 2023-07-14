using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public XmlDocument XmlDocumento(String FileZIP,string NameArchive) {
            XmlDocument xmlDocument = new XmlDocument();

            using (FileStream zipToOpen = new FileStream(FileZIP, FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Read))
                {
                    ZipArchiveEntry xmlEntry = archive.GetEntry(NameArchive);
                    if (xmlEntry != null)
                    {
                        using (Stream xmlStream = xmlEntry.Open())
                        {
                            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                            xmlDocument.Load(xmlStream);

                   
                        }
                    }
                    else
                    {
                    }
                }
            }
           


           //Super necessario
            return xmlDocument;
        }
        public void setBreaks(List <XmlNode>list)
        {

       


            foreach (var item in list)
            {
                Break objBreak = new Break();
                //Melhor maneira de fazer


                string[] attributeNames = { "Ins", "Changed", "Locked", "Filetime", "Filetime2", "Time", "Type", "Id", "Id_Edited", "Fixo", "Descarte", "Net", "Dur", "Slots", "Orig" };

                foreach (string attributeName in attributeNames)
                {
                    string attributeValue = item.Attributes[attributeName]?.Value;
                    if (string.IsNullOrEmpty(attributeValue))
                    {
                        attributeValue = "Null";
                    }
                    typeof(Break).GetProperty(attributeName)?.SetValue(objBreak, attributeValue);
                }

                Breaks.Add(objBreak);


                /*
                Maneira grande de fazer
                objBreak.Ins = item.Attributes["Ins"]?.Value;
                objBreak.locked = item.Attributes["Locked"]?.Value;
                objBreak.Changed = item.Attributes["Changed"]?.Value;
                objBreak.Filetime = item.Attributes["Filetime"]?.Value;
                objBreak.Filetime2 = item.Attributes["Filetime2"]?.Value;
                objBreak.Time = item.Attributes["Time"]?.Value;
                objBreak.Type = item.Attributes["Type"]?.Value;
                objBreak.Id = item.Attributes["Id"]?.Value;
                objBreak.Id_Edited = item.Attributes["Id_Edited"]?.Value;
                objBreak.Fixo = item.Attributes["Fixo"]?.Value;
                objBreak.Descarte = item.Attributes["Descarte"]?.Value;
                objBreak.Net = item.Attributes["Net"]?.Value;
                objBreak.Dur = item.Attributes["Dur"]?.Value;
                objBreak.Slots = item.Attributes["Slots"]?.Value;
                objBreak.Orig = item.Attributes["Orig"]?.Value;
                */

            }


        }

        public bool Comparar(List<string > listcomp, string comp)
        {
            foreach (var item in listcomp)
            {
                if (item.Equals(comp))
                {
                    return true;
                }
            }
            return false;
        }


        public List<XmlNode> GetAllIns(List<XmlNode> list)
        {
            List<XmlNode> listains = new List<XmlNode>();


            for (int i = 0; i < list.Count; i++)
            {
                if (list.Count > 0)
                {
                    foreach (XmlNode childNode in list[i].ChildNodes)
                    {
                        if (childNode.Name.StartsWith("Ins"))
                        {
                            listains.Add(childNode);
                        }
                    }
                }
            }

            return listains;
        }

        public List<string> TransformarEmAtributos(XmlNode node) {


            List<string> nomesAtributos = new List<string>();

            foreach (XmlAttribute attribute in node.Attributes)
            {
                string nomeAtributo = attribute.Name;
                nomesAtributos.Add(nomeAtributo);
            }

        
        
             return nomesAtributos;
        }

        



    }
}
