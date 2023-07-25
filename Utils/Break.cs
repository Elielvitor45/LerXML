﻿using System;
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

        public Break() { }

        public Break(XmlNode Break, List<XmlNode> listIns)
        {   
            string[] attributeNames = {"Ins", "Changed", "Locked", "Filetime", "Filetime2", "Time", "Type", "Id", "Id_Edited", "Fixo", "Descarte", "Net", "Dur", "Slots", "Orig" };
            foreach (string attributeName in attributeNames)
            {
                string attributeValue = Break.Attributes[attributeName]?.Value;
                if (string.IsNullOrEmpty(attributeValue))
                {
                    attributeValue = "";
                }
                typeof(Break).GetProperty(attributeName).SetValue(this, attributeValue);
            }
            this.Insercao = getListObjIns(listIns);
            this.Name = Break.Name;
        }
        //Recebe lista xml de Ins
        public List<Ins> getListObjIns(List<XmlNode> listIns)
        {
            List<Ins> objLista = new List<Ins>();
            foreach (var item in listIns)
            {
                Ins objins = new Ins(item);
               objLista.Add(objins);
           }
           return objLista;
        }
        //Recebe lista xml de Break
        public List<XmlNode> GetListXmlIns(XmlNode list)
        {
            List<XmlNode> listains = new List<XmlNode>();
                    foreach (XmlNode childNode in list.ChildNodes)
                    {
                        if (childNode.Name.StartsWith("Ins"))
                        {
                            listains.Add(childNode);
                        }
                    }     
            return listains;
        }
        //Recebe uma lista xml De todos os nós.
        public List<XmlNode> getXmlBreakNodeList(XmlNodeList xmlnodelist)
        {
            List<XmlNode> list = new List<XmlNode>();
            foreach (XmlNode noFilho in xmlnodelist)
                {
                    list.Add(noFilho);
                }
            return list;
        }
        
        public string Name { get; set; }
        public string Ins { get; set; }
        public List<Ins> Insercao { get; set; } = new List<Ins>();
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
