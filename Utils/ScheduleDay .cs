using System.Text.Json;
using System.IO.Compression;
using System.Text;
using System.Xml;
namespace LeituraXml.Utils
{
    public class ScheduleDay
    {
        public string path_Montagem { get; set; }
        public DateTime date { get; set; }
        public List<Break> Breaks { get; set; } = new List<Break>();
        public void ReadScheduleDay(string path, DateTime date)
        {
            this.path_Montagem = path;
            this.date = date;
            Init();
        }
        public void ReadScheduleDay(string pathMontagem, string pathJson, DateTime date)
        {
            this.path_Montagem = pathMontagem;
            this.date = date;
            if (Init())
            {
                parseJson(pathJson);
            }
        }

        private void parseJson(string path)
        {
            string nameJson = $@"{date.ToString("dd-MM-yyyy")}.json";
            if (string.IsNullOrEmpty(path))
            {
            }
            else
            {
                string filePath = @$"{path}\{nameJson}";
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(Breaks, options);
                File.WriteAllText(filePath, jsonString);
            }
        }
        private string getpath(string path)
        {
            string datePath = date.ToString("dd-MM-yyyy");
            if (string.IsNullOrEmpty(path))
            {
                return null;
            }
            string fullPath = @path;
            fullPath += @"\Montagem";
            int day, month, year;
            if ((int.TryParse(datePath.Split('-')[0], out day) && int.TryParse(datePath.Split('-')[1], out month) && int.TryParse(datePath.Split('-')[2], out year)))
            {
                string filename = @"\" + $"{datePath}" + ".zip";
                fullPath += filename + "%" + @$"{datePath}.xml";
            }
            else
            {
                return null;
            }
            return fullPath;
        }
        XmlDocument xmlDocument = new XmlDocument();
        private bool readXmlDocument()
        {
            string[] fullPath;
            if (getpath(path_Montagem) == null)
            {
                return false;
            }
            else
            {
                fullPath = getpath(path_Montagem).Split("%");
            }
            try
            {
                if (!File.Exists(fullPath[0]))
                {
                    return false;
                }
                using (FileStream zipToOpen = new FileStream(fullPath[0], FileMode.Open))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry xmlEntry = archive.GetEntry(fullPath[1]);
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
                return false;
                throw;
            }
        }
        private XmlNodeList getXmlNodeList()
        {
            XmlNodeList NodeList = xmlDocument.SelectNodes("//Playlist/*");
            return NodeList;
        }
        public void ReadBreaks()
        {
            XmlNodeList listXML = getXmlNodeList();
            foreach (XmlNode item in listXML)
            {
                Break Break0 = new Break(item);
                Breaks.Add(Break0);
            }
        }
        private bool Init()
        {
            if (readXmlDocument())
            {
                ReadBreaks();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}