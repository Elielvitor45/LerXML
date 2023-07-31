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
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace LeituraXml.Utils
{  
    public class ScheduleDay
    {
        public string path_one { get; set; }
        public string day { get; set; }
        public string mounth { get; set; }
        public string year { get; set; }
        public List<Break> Breaks { get; set; }
        public ScheduleDay(string path,string pathTwo,DateTime date) {
            this. path_one = path;
            this.day = date.Day.ToString("00");
            this.mounth = date.Month.ToString("00");
            this.year = date.Year.ToString();
            string nameJson = @$"{day}-{mounth}-{year}.json";
            if (Init())
            {
                parseJson(Breaks, nameJson, pathTwo);
            }
        }
        public ScheduleDay(string path, DateTime date) { 
            this.path_one = path;
            this.day = date.Day.ToString("00");
            this.mounth = date.Month.ToString("00");
            this.year = date.Year.ToString();        
            Init();
        }
        private void parseJson(List<Break> breaks,string filename,string path) {
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("O caminho não pode ser vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string filePath = @$"{path}\{filename}";
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(breaks, options);
                File.WriteAllText(filePath, jsonString);
                MessageBox.Show(" Json Salvo com Sucesso", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //utilizar esse metodo precisa de split
        private string getpath(string path,string dayS,string monthS,string yearS)
        {
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Caminho não pode ser Vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            string fullPath = @path;
            fullPath += @"\Montagem";

            int day, month, year;
            if ((int.TryParse(dayS, out day) && int.TryParse(monthS, out month) && int.TryParse(yearS, out year)))
            {
                string filename = @"\" + $"{dayS}-{monthS}-{yearS}" + ".zip";
                fullPath += filename+"%"+@$"{dayS}-{monthS}-{yearS}.xml";
            }
            else
            {
                MessageBox.Show("A Data não pode ser vazia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return fullPath;
        }
        //Objeto que guarda o xml todo
        XmlDocument xmlDocument = new XmlDocument();
        private bool readXmlDocument(string FileZIP,string NameArchive) {
            try
            {
                if (!File.Exists(FileZIP))
                {
                    MessageBox.Show("Arquivo não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
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
                                return true;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                throw;
            }
        }
        private XmlNodeList getXmlNodeList()
        {
            XmlNodeList NodeList = xmlDocument.SelectNodes("//Playlist/*");
            return NodeList;
        }
        public void ReadBreaks(List<XmlNode> list)
        {
            Breaks = new List<Break>();
            foreach (var item in list)
            {
                Break Break0 = new Break(item);   
                Breaks.Add(Break0);
            }
        }
        private bool Init()
        {
            if (getpath(path_one, day, mounth, year) != null) {
                //Carrega o arquivo xml
                string[] fullPath = getpath(path_one, day, mounth, year).Split("%");
                
                if (readXmlDocument(fullPath[0], fullPath[1]))
                {
                    //lista com todos os nós do xml
                    XmlNodeList listXML = getXmlNodeList();
                    //instancia das Listas
                    List<XmlNode> listBreak = new List<XmlNode>();
                    //Instancia dos Objetos
                    Break breakXml = new Break();
                    //ListasXMl
                    listBreak = breakXml.getXmlBreakNodeList(listXML);
                    ReadBreaks(listBreak);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }   
    }
}       