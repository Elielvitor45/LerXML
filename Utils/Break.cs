using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace LeituraXml.Utils
{
    public class Break
    {
        public List<XmlNode> getXmlBreakNodeList(XmlNodeList xmlnodelist)
        {
            List<XmlNode> list = new List<XmlNode>();
            foreach (XmlNode noFilho in xmlnodelist)
                {
                    list.Add(noFilho);
                }
            return list;
        }
        public List<Break> getBreaks(List<XmlNode> list)
        {
            List<Break> listObjBreak = new List<Break>();
            
            foreach (var item in list)
            {
                Break objBreak = new Break();
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

                listObjBreak.Add(objBreak);
            }
            return listObjBreak;
        }
        public string Ins { get; set; }
        public string Locked { get; set; }
        public string Changed { get; set; }
        public string Filetime { get; set; }
        public string Filetime2 { get; set; }
        public string Time { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }
        public string Id_Edited { get; set; }
        public string Fixo { get; set; }
        public string Descarte { get; set; }
        public string Net { get; set; }
        public string Dur { get; set; }
        public string Slots { get; set; }
        public string Orig { get; set; }
    }
}
