using LeituraXml.Utils;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.IO.Compression;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LeituraXml
{
    public partial class Form1 : Form
    {
        private DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AddColumns();
            textBox1.Text = @"C:\Playlist\pgm";
            MessageBox.Show("leitor montagem xml");
        }
        private void AddColumns()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Ins_Name", typeof(string));
            dataTable.Columns.Add("Ins_Id", typeof(string));
            dataTable.Columns.Add("Ins_CTA", typeof(string));
            dataTable.Columns.Add("Ins_Source", typeof(string));
            dataTable.Columns.Add("Ins_MovedTo", typeof(string));
            dataTable.Columns.Add("Ins_Type", typeof(string));
            dataTable.Columns.Add("Ins_Title", typeof(string));
            dataTable.Columns.Add("Ins_File", typeof(string));
            dataTable.Columns.Add("Ins_Folder", typeof(string));
            dataTable.Columns.Add("Ins_Text", typeof(string));
            dataTable.Columns.Add("Ins_Composer", typeof(string));
            dataTable.Columns.Add("Ins_Comment", typeof(string));
            dataTable.Columns.Add("Ins_Checked", typeof(string));
            dataTable.Columns.Add("Ins_Err", typeof(string));
            dataTable.Columns.Add("Ins_sErr", typeof(string));
            dataTable.Columns.Add("Ins_HoraAudio", typeof(string));
            dataTable.Columns.Add("Ins_HoraPK", typeof(string));
            dataTable.Columns.Add("Ins_IsAudioFile", typeof(string));
            dataTable.Columns.Add("Ins_DurOrig", typeof(string));
            dataTable.Columns.Add("Ins_Dur", typeof(string));
            dataTable.Columns.Add("Ins_Refr", typeof(string));
            dataTable.Columns.Add("Ins_DurRefr", typeof(string));
            dataTable.Columns.Add("Ins_PtVh", typeof(string));
            dataTable.Columns.Add("Ins_PtMx", typeof(string));
            dataTable.Columns.Add("Ins_MxIni", typeof(string));
            dataTable.Columns.Add("Ins_Intro", typeof(string));
            dataTable.Columns.Add("Ins_PtLoc", typeof(string));
            dataTable.Columns.Add("Ins_Vol", typeof(string));
            dataTable.Columns.Add("Ins_Bitrate", typeof(string));
            dataTable.Columns.Add("Ins_Reg", typeof(string));
            dataTable.Columns.Add("Ins_MD5", typeof(string));
            dataTable.Columns.Add("Locked", typeof(string));
            dataTable.Columns.Add("Changed", typeof(string));
            dataTable.Columns.Add("Filetime", typeof(string));
            dataTable.Columns.Add("Filetime2", typeof(string));
            dataTable.Columns.Add("Time", typeof(string));
            dataTable.Columns.Add("Type", typeof(string));
            dataTable.Columns.Add("Id", typeof(string));
            dataTable.Columns.Add("Id_Edited", typeof(string));
            dataTable.Columns.Add("Fixo", typeof(string));
            dataTable.Columns.Add("Descarte", typeof(string));
            dataTable.Columns.Add("Net", typeof(string));
            dataTable.Columns.Add("Dur", typeof(string));
            dataTable.Columns.Add("Slots", typeof(string));
            dataTable.Columns.Add("Orig", typeof(string));
        }
        private void buttonReadXml_Click_1(object sender, EventArgs e)
        {
            dataGrid1.DataSource = dataTable;
            Playlist.ReadScheduleDay(textBox1.Text, date1.Value);
            dataTable.Rows.Clear();
            PreencherDataGridView(Playlist.Breaks);
        }
        private ScheduleDay Playlist = new ScheduleDay();
        private void PreencherDataGridView(List<Break> suaLista)
        {
            if (suaLista!=null)
            {
                foreach (var breaks in suaLista)
                {
                    FillBreaks(breaks);

                    foreach (var insObj in breaks.Insertions)
                    {
                        FillIns(insObj, breaks);
                    }
                }
            }
            else
            {
            }
        }
        private void FillBreaks(Break breaks)
        {
            dataTable.Rows.Add(
                    breaks.Name,
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    breaks.Locked,
                    breaks.Changed,
                    breaks.Filetime,
                    breaks.Filetime2,
                    breaks.Time,
                    breaks.Type,
                    breaks.Id,
                    breaks.Id_Edited,
                    breaks.Fixo,
                    breaks.Descarte,
                    breaks.Net,
                    breaks.Dur,
                    breaks.Slots,
                    breaks.Orig
                );


        }
        private void FillIns(Ins insObj, Break breaks)
        {
            dataTable.Rows.Add(
                "",
                insObj.Name,
                insObj.Id,
                insObj.CTA,
                insObj.Source,
                insObj.MovedTo,
                insObj.Type,
                insObj.Title,
                insObj.File,
                insObj.Folder,
                insObj.Text,
                insObj.Composer,
                insObj.Comment,
                insObj.Checked,
                insObj.Err,
                insObj.sErr,
                insObj.HoraAudio,
                insObj.HoraPK,
                insObj.IsAudioFile,
                insObj.DurOrig,
                insObj.Dur,
                insObj.Refr,
                insObj.DurRefr,
                insObj.PtVh,
                insObj.PtMx,
                insObj.MxIni,
                insObj.Intro,
                insObj.PtLoc,
                insObj.Vol,
                insObj.Bitrate,
                insObj.Reg,
                insObj.MD5,
                breaks.Locked,
                breaks.Changed,
                breaks.Filetime,
                breaks.Filetime2,
                breaks.Time,
                breaks.Type,
                breaks.Id,
                breaks.Id_Edited,
                breaks.Fixo,
                breaks.Descarte,
                breaks.Net,
                breaks.Dur,
                breaks.Slots,
                breaks.Orig
            );
        }
        private void buttonPathMontagem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string path = folderBrowserDialog1.SelectedPath;
            folderBrowserDialog1.Reset();
            if (!Directory.Exists(path + @"\montagem"))
            {
                MessageBox.Show("Pasta 'Montagem' não encontrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                buttonReadXml.Enabled = true;
                textBox1.Text = path;
            }
        }
        private void buttonPathJson_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string path = folderBrowserDialog1.SelectedPath;
            folderBrowserDialog1.Reset();
            buttonReadXml.Enabled = true;
            textBoxJson.Text = path;
        }
        private void buttonJson_Click(object sender, EventArgs e)
        {
            Playlist.ReadScheduleDay(textBox1.Text, date1.Value);
            Playlist.parseJson(textBoxJson.Text);

        }

    }
}