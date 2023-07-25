using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Text.Json;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace LeituraXml.Utils
{  
    public class ScheduleDay
    {
        public string caminho { get; set; }
        public string day { get; set; }
        public string mounth { get; set; }
        public string year { get; set; }
        public ScheduleDay(string caminho, string day, string mounth, string year)
        {
            this.caminho = caminho;
            this.day = day;
            this.mounth = mounth;
            this.year = year;
        }
        public void parseJson(List<Break> breaks,string name) {
            string filePath = @$"C:\Desenvolvimento\LeituraXml\LeituraXml\{name}.json";
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(breaks, options);
            File.WriteAllText(filePath, jsonString);
        }



        //utilizar esse metodo precisa de split
        public string getpath(string caminho,string dayS,string monthS,string yearS)
        {
            if (String.IsNullOrEmpty(caminho))
            {
                MessageBox.Show("Caminho não pode ser Vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            string caminhoCompleto = @caminho;
            caminhoCompleto += @"\Montagem";

            int day, month, year;
            if ((int.TryParse(dayS, out day) && int.TryParse(monthS, out month) && int.TryParse(yearS, out year)))
            {
                string nomearquivo = @"\" + $"{dayS}-{monthS}-{yearS}" + ".zip";
                caminhoCompleto += nomearquivo+"%"+@$"{dayS}-{monthS}-{yearS}.xml";
            }
            else
            {
                MessageBox.Show("A Data não pode ser vazia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return caminhoCompleto;
        }
        //Objeto que guarda o xml todo
        XmlDocument xmlDocument = new XmlDocument();
        public void readXmlDocument(String FileZIP,string NameArchive) {
            try
            {
                if (!File.Exists(FileZIP))
                {
                    MessageBox.Show("Arquivo não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                throw;
            }
        }
        public XmlNodeList getXmlNodeList()
        {
            XmlNodeList NodeList = xmlDocument.SelectNodes("//Playlist/*");
            return NodeList;
        }
        public List<Break> getListObjBreaks(List<XmlNode> list)
        {
            List<Break> listObjBreak = new List<Break>();
            Break objBreak01 = new Break();
            foreach (var item in list)
            {
                Break objBreak02 = new Break(item,objBreak01.GetListXmlIns(item));   
                listObjBreak.Add(objBreak02);
            }
            return listObjBreak;
        }
        public List<Break> Init()
        {
            if (getpath(caminho, day, mounth, year) != null) {
                //Carrega o arquivo xml
                string[] caminhoCompleto = getpath(caminho, day, mounth, year).Split("%");
                readXmlDocument(caminhoCompleto[0], caminhoCompleto[1]);
                //lista com todos os nós do xml
                XmlNodeList listXML = getXmlNodeList();
                //instancia das Listas
                List<XmlNode> listBreak = new List<XmlNode>();
                List<Break> listObjBreak = new List<Break>();
                //Instancia dos Objetos
                Break objBreak = new Break();
                //ListasXMl
                listBreak = objBreak.getXmlBreakNodeList(listXML);
                //ListasObjetos
                listObjBreak = getListObjBreaks(listBreak);
                parseJson(listObjBreak, caminhoCompleto[1]);
                return listObjBreak;
            }
            else
            {
                return null;
            }
        }   
    }
}

                    