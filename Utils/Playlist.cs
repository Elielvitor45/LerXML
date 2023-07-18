using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
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
    public class Playlist
    {
        public DataGridView dataGrid { get; set; }
        public string caminho { get; set; }
        public string day { get; set; }
        public string mounth { get; set; }
        public string year { get; set; }
        public Playlist(string caminho, string day, string mounth, string year, DataGridView datagrid)
        {
            this.caminho = caminho;
            this.day = day;
            this.mounth = mounth;
            this.year = year;
            this.dataGrid = datagrid;
        }
        //utilizar esse metodo precisa de split
        public string setpath(string caminho,string dayS,string monthS,string yearS)
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
        public void getXmlDocument(String FileZIP,string NameArchive) {

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
        public XmlNodeList getXmlNodeList()
        {
            //Adicionar getXmldocument aqui
            XmlNodeList NodeList = xmlDocument.SelectNodes("//Playlist/*");
            return NodeList;
        }        
        public void AddGridView(List<XmlNode> listBreak, List<XmlNode> listIns, List<Break> listobjBreak, List<Ins> listObjIns ) {
            dataGrid.Rows.Clear();
            int count = 0;
            for (int i = 0; i < listBreak.Count; i++)
            {
                for (int j = 0; j < int.Parse(listobjBreak[i].Ins); j++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGrid);
                    row.Cells[0].Value = listBreak[i].Name;
                    row.Cells[1].Value = listobjBreak[i].Ins;
                    row.Cells[2].Value = listobjBreak[i].Locked;
                    row.Cells[3].Value = listobjBreak[i].Changed;
                    row.Cells[4].Value = listobjBreak[i].Filetime;
                    row.Cells[5].Value = listobjBreak[i].Filetime2;
                    row.Cells[6].Value = listobjBreak[i].Time;
                    row.Cells[7].Value = listobjBreak[i].Type;
                    row.Cells[8].Value = listobjBreak[i].Id;
                    row.Cells[9].Value = listobjBreak[i].Id_Edited;
                    row.Cells[10].Value = listobjBreak[i].Fixo;
                    row.Cells[11].Value = listobjBreak[i].Descarte;
                    row.Cells[12].Value = listobjBreak[i].Net;
                    row.Cells[13].Value = listobjBreak[i].Dur;
                    row.Cells[14].Value = listobjBreak[i].Slots;
                    row.Cells[15].Value = listobjBreak[i].Orig;
                    row.Cells[16].Value = listIns[count].Name;
                    row.Cells[17].Value = listObjIns[count].Id;
                    row.Cells[18].Value = listObjIns[count].CTA;
                    row.Cells[19].Value = listObjIns[count].Source;
                    row.Cells[20].Value = listObjIns[count].MovedTo;
                    row.Cells[21].Value = listObjIns[count].Type;
                    row.Cells[22].Value = listObjIns[count].Title;
                    row.Cells[23].Value = listObjIns[count].File;
                    row.Cells[24].Value = listObjIns[count].Folder;
                    row.Cells[25].Value = listObjIns[count].Text;
                    row.Cells[26].Value = listObjIns[count].Composer;
                    row.Cells[27].Value = listObjIns[count].Comment;
                    row.Cells[28].Value = listObjIns[count].Checked;
                    row.Cells[29].Value = listObjIns[count].Err;
                    row.Cells[30].Value = listObjIns[count].sErr;
                    row.Cells[31].Value = listObjIns[count].HoraAudio;
                    row.Cells[32].Value = listObjIns[count].HoraPK;
                    row.Cells[33].Value = listObjIns[count].IsAudioFile;
                    row.Cells[34].Value = listObjIns[count].DurOrig;
                    row.Cells[35].Value = listObjIns[count].Dur;
                    row.Cells[36].Value = listObjIns[count].Refr;
                    row.Cells[37].Value = listObjIns[count].DurRefr;
                    row.Cells[38].Value = listObjIns[count].PtVh;
                    row.Cells[39].Value = listObjIns[count].PtMx;
                    row.Cells[40].Value = listObjIns[count].MxIni;
                    row.Cells[41].Value = listObjIns[count]?.Intro;
                    row.Cells[42].Value = listObjIns[count]?.PtLoc;
                    row.Cells[43].Value = listObjIns[count]?.Vol;
                    row.Cells[44].Value = listObjIns[count]?.Bitrate;
                    row.Cells[45].Value = listObjIns[count]?.Reg;
                    row.Cells[46].Value = listObjIns[count]?.MD5;
                    dataGrid.Rows.Add(row);
                    count++;
                }
            }
        }
        public void Init()
        {
            if (setpath(caminho, day, mounth, year) != null) {
                //Carrega o arquivo xml
                string[] caminhoCompleto = setpath(caminho, day, mounth, year).Split("%");
                getXmlDocument(caminhoCompleto[0], caminhoCompleto[1]);
                //lista com todos os nós do xml
                XmlNodeList listXML = getXmlNodeList();
                //instancia das Listas
                List<XmlNode> listBreak = new List<XmlNode>();
                List<XmlNode> listIns = new List<XmlNode>();
                List<Break> listObjBreak = new List<Break>();
                List<Ins> listObjIns = new List<Ins>();
                //Instancia dos Objetos
                Break objBreak = new Break();
                Ins objIns = new Ins();
                //ListasXMl
                listBreak = objBreak.getXmlBreakNodeList(listXML);
                listIns = objIns.GetAllIns(listBreak);
                //ListasObjetos
                listObjBreak = objBreak.getBreaks(listBreak);
                listObjIns = objIns.getObjIns(listIns);
                if (dataGrid != null)
                {
                    AddGridView(listBreak, listIns, listObjBreak, listObjIns);
                }
                else
                {
                    MessageBox.Show("Erro Grid", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else { }
        }   
    }
}
