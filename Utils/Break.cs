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



        public List<Ins> objLista = new List<Ins>();

        public void setObjIns(List<XmlNode> listIns) {
            foreach (var item in listIns)
            {
                Ins objins = new Ins();

                string[] attributeNames = { "Id", "CTA", "Source", "MovedTo", "Type" , "Title" , "File", "Folder" , "Text", "Composer", "Comment", "Checked", "Err", "sErr", "HoraAudio", "HoraPK", "IsAudioFile", "DurOrig", "Dur", "Refr", "DurRefr", "PtVh", "PtMx", "MxIni", "Intro", "PtLoc", "Vol", "Bitrate", "Reg", "MD5" };

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
        }



        




    }
}
