using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace LeituraXml.Utils
{
    public class Ins
    {
        public List<Ins> getObjIns(List<XmlNode> listIns)
        {
            List<Ins> objLista = new List<Ins>();
            foreach (var item in listIns)
            {
                Ins objins = new Ins();

                string[] attributeNames = { "Id", "CTA", "Source", "MovedTo", "Type", "Title", "File", "Folder", "Text", "Composer", "Comment", "Checked", "Err", "sErr", "HoraAudio", "HoraPK", "IsAudioFile", "DurOrig", "Dur", "Refr", "DurRefr", "PtVh", "PtMx", "MxIni", "Intro", "PtLoc", "Vol", "Bitrate", "Reg", "MD5" };

                foreach (string attributeName in attributeNames)
                {
                    string attributeValue = item.Attributes[attributeName]?.Value;
                    if (string.IsNullOrEmpty(attributeValue))
                    {
                        attributeValue = "Null";
                    }
                    typeof(Ins).GetProperty(attributeName).SetValue(objins, attributeValue);
                }
                objLista.Add(objins);
            }
            return objLista;
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
        public string Id { get; set; }
        public string CTA { get; set; }
        public string Source { get; set; }
        public string MovedTo { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string File { get; set; }
        public string Folder { get; set; }
        public string Text { get; set; }
        public string Composer { get; set; }
        public string Comment { get; set; } 
        public string Checked { get; set; }
        public string Err { get; set; }
        public string sErr { get; set; }
        public string HoraAudio { get; set; }
        public string HoraPK { get; set; }
        public string IsAudioFile { get; set; }
        public string DurOrig { get; set; }
        public string Dur { get; set; }
        public string Refr { get; set; }
        public string DurRefr { get; set; }
        public string PtVh { get; set; }
        public string PtMx { get; set; }
        public string MxIni { get; set; }
        public string Intro { get; set; }
        public string PtLoc { get; set; }
        public string Vol { get; set; }
        public string Bitrate { get; set; }
        public string Reg { get; set; }
        public string MD5 { get; set; }
    }
}
