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
        public Break(XmlNode Break)
        {
            string[] attributeNames = { "Ins", "Changed", "Locked", "Filetime", "Filetime2", "Time", "Type", "Id", "Id_Edited", "Fixo", "Descarte", "Net", "Dur", "Slots", "Orig" };
            foreach (string attributeName in attributeNames)
            {
                string attributeValue = Break.Attributes[attributeName]?.Value;
                if (string.IsNullOrEmpty(attributeValue))
                {
                    attributeValue = "";
                }
                typeof(Break).GetProperty(attributeName).SetValue(this, attributeValue);
            }
            ReadInsertions(Break);
            this.Name = Break.Name;
        }
        private void ReadInsertions(XmlNode list)
        {
            Insertions = new List<Ins>();
            foreach (XmlNode childNode in list.ChildNodes)
            {
                if (childNode.Name.StartsWith("Ins"))
                {
                    Ins objins = new Ins(childNode);
                    Insertions.Add(objins);
                }
            }
        }
        public string Name { get; set; }
        public string Ins { get; set; }
        public List<Ins> Insertions { get; set; }
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
