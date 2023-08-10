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
        public List<Break> Breaks { get; set; }
        public void ReadScheduleDay(string path, DateTime date)
        {
            this.path_Montagem = path;
            this.date = date;
            Init();
        }
        public void parseJson(string path)
        {
            string nameJson = $@"{date.ToString("dd-MM-yyyy")}.json";
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("O caminho não pode ser vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string filePath = @$"{path}\{nameJson}";
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(Breaks, options);
                File.WriteAllText(filePath, jsonString);
                MessageBox.Show(" Json Salvo com Sucesso", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //utilizar esse metodo precisa de split
        private string getpath(string path)
        {
            string datePath = date.ToString("dd-MM-yyyy");
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Caminho não pode ser Vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("A Data não pode ser vazia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return fullPath;
        }
        //Objeto que guarda o xml todo
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
                    MessageBox.Show("Arquivo não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (readXmlDocument())
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
    }
}