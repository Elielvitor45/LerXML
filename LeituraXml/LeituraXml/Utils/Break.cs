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
        public string locked { get; set; }

        public List<Ins> objLista = new List<Ins>();

        public void setObjIns(List<XmlNode> listIns) {
            foreach (var item in listIns)
            {
                Ins objins = new Ins();
                objins.Id = item.Attributes["Id"]?.Value;
                objins.CTA = item.Attributes["CTA"]?.Value;
                objLista.Add(objins);
            }
        }



        




    }
}
