using LeituraXml.Utils;
using System.Data.Common;
using System.IO.Compression;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace LeituraXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Playlist ObjPrincipal = new Playlist();
        private void Form1_Load(object sender, EventArgs e)
        {





            MessageBox.Show("leitor montagem xml");
        }


     
        
        private void button1_Click_1(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Caminho não pode ser Vazio","Aviso", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
                string caminhoCompleto = @textBox1.Text;
                

                caminhoCompleto += @"\Montagem";

            int day, month, year;
            string caminhoArquivo;
            if ((int.TryParse(textday.Text, out day) && int.TryParse(textmounth.Text, out month) && int.TryParse(textyear.Text, out year)))
            {
                // Os valores são números inteiros, você pode continuar construindo as strings
                string nomearquivo = @"\" + $"{textday.Text}-{textmounth.Text}-{textyear.Text}" + ".zip";
                caminhoCompleto += nomearquivo;
                caminhoArquivo = @$"{textday.Text}-{textmounth.Text}-{textyear.Text}.xml";

                // Restante do código para lidar com o caso em que os campos contêm números
            }
            else
            {

                MessageBox.Show("A Data não pode ser vazia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
                





                XmlDocument xml = ObjPrincipal.XmlDocumento(caminhoCompleto, caminhoArquivo);



                XmlNodeList ListXml = ObjPrincipal.ListadeXMl(xml, "//Playlist/*");
                List<XmlNode> list = new List<XmlNode>();
                //listains está com um erro fatal, ela está pegando o numero errado,
                //pois está guardando todas as ins emapenas um lugar
                List<XmlNode> listains = new List<XmlNode>();
                Break metodosbreak = new Break();

                //Separa a listaXml (Nó) Playlist em uma listaXml (Nó) Break
                foreach (XmlNode noFilho in ListXml)
                {
                    list.Add(noFilho);
                }
                //Adiciona os valores numa listaObj de (Nó) Breaks
                ObjPrincipal.setBreaks(list);

                //adiciona os valores de uma listaXml de (Nó) Breaks para uma listaXml de (Nó) Ins
                listains = ObjPrincipal.GetAllIns(list);
                //Pega uma lista de (Nó) ins e adiciona os valores dentro de uma ListaObj (Nó) Ins
                metodosbreak.setObjIns(listains);
                int numeroDeColunas = 1 + list[0].Attributes.Count + 1 + listains[0].Attributes.Count;
                DataGridViewTextBoxColumn breakcolum = new DataGridViewTextBoxColumn();
                breakcolum.HeaderText = "Breaks";
                //dataGrid1.Columns.Add(breakcolum);
                List<string> BreakAtributos = new List<string>();
                BreakAtributos = ObjPrincipal.TransformarEmAtributos(list[0]);

                /*for (int i = 0; i < list[0].Attributes.Count; i++)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.HeaderText ="Atributo: "+BreakAtributos[i] ;
                    dataGrid1.Columns.Add(column);

                }*/
                DataGridViewTextBoxColumn Inscolum = new DataGridViewTextBoxColumn();
                Inscolum.HeaderText = "Ins";
                //dataGrid1.Columns.Add(Inscolum);
                List<string> Insatributos = new List<string>();
                Insatributos = ObjPrincipal.TransformarEmAtributos(listains[0]);

                /*for (int i = 0; i < listains[0].Attributes.Count; i++)
                {
                    DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                    column1.HeaderText = "Atributo: " + Insatributos[i];
                    dataGrid1.Columns.Add(column1);
                }*/


                // Adicionando a linha com o valor da variável
                dataGrid1.Rows.Clear(); // Limpa as linhas existentes



                int cont = 0;
                //Adiciona os objetos no GridView
                for (int i = 0; i < list.Count; i++)
                {


                    for (int j = 0; j < int.Parse(ObjPrincipal.Breaks[i].Ins); j++)
                    {

                        DataGridViewRow row = new DataGridViewRow();
                        //inserindo os valores no DataGrid
                        row.CreateCells(dataGrid1);
                        row.Cells[0].Value = list[i].Name;
                        row.Cells[1].Value = ObjPrincipal.Breaks[i].Ins;
                        row.Cells[2].Value = ObjPrincipal.Breaks[i].Locked;
                        row.Cells[3].Value = ObjPrincipal.Breaks[i].Changed;
                        row.Cells[4].Value = ObjPrincipal.Breaks[i].Filetime;
                        row.Cells[5].Value = ObjPrincipal.Breaks[i].Filetime2;
                        row.Cells[6].Value = ObjPrincipal.Breaks[i].Time;
                        row.Cells[7].Value = ObjPrincipal.Breaks[i].Type;
                        row.Cells[8].Value = ObjPrincipal.Breaks[i].Id;
                        row.Cells[9].Value = ObjPrincipal.Breaks[i].Id_Edited;
                        row.Cells[10].Value = ObjPrincipal.Breaks[i].Fixo;
                        row.Cells[11].Value = ObjPrincipal.Breaks[i].Descarte;
                        row.Cells[12].Value = ObjPrincipal.Breaks[i].Net;
                        row.Cells[13].Value = ObjPrincipal.Breaks[i].Dur;
                        row.Cells[14].Value = ObjPrincipal.Breaks[i].Slots;
                        row.Cells[15].Value = ObjPrincipal.Breaks[i].Orig;
                        row.Cells[16].Value = listains[cont].Name;
                        row.Cells[17].Value = metodosbreak.objLista[cont].Id;
                        row.Cells[18].Value = metodosbreak.objLista[cont].CTA;
                        row.Cells[19].Value = metodosbreak.objLista[cont].Source;
                        row.Cells[20].Value = metodosbreak.objLista[cont].MovedTo;
                        row.Cells[21].Value = metodosbreak.objLista[cont].Type;
                        row.Cells[22].Value = metodosbreak.objLista[cont].Title;
                        row.Cells[23].Value = metodosbreak.objLista[cont].File;
                        row.Cells[24].Value = metodosbreak.objLista[cont].Folder;
                        row.Cells[25].Value = metodosbreak.objLista[cont].Text;
                        row.Cells[26].Value = metodosbreak.objLista[cont].Composer;
                        row.Cells[27].Value = metodosbreak.objLista[cont].Comment;
                        row.Cells[28].Value = metodosbreak.objLista[cont].Checked;
                        row.Cells[29].Value = metodosbreak.objLista[cont].Err;
                        row.Cells[30].Value = metodosbreak.objLista[cont].sErr;
                        row.Cells[31].Value = metodosbreak.objLista[cont].HoraAudio;
                        row.Cells[32].Value = metodosbreak.objLista[cont].HoraPK;
                        row.Cells[33].Value = metodosbreak.objLista[cont].IsAudioFile;
                        row.Cells[34].Value = metodosbreak.objLista[cont].DurOrig;
                        row.Cells[35].Value = metodosbreak.objLista[cont].Dur;
                        row.Cells[36].Value = metodosbreak.objLista[cont].Refr;
                        row.Cells[37].Value = metodosbreak.objLista[cont].DurRefr;
                        row.Cells[38].Value = metodosbreak.objLista[cont].PtVh;
                        row.Cells[39].Value = metodosbreak.objLista[cont].PtMx;
                        row.Cells[40].Value = metodosbreak.objLista[cont].MxIni;
                        row.Cells[41].Value = metodosbreak.objLista[cont]?.Intro;
                        row.Cells[42].Value = metodosbreak.objLista[cont]?.PtLoc;
                        row.Cells[43].Value = metodosbreak.objLista[cont]?.Vol;
                        row.Cells[44].Value = metodosbreak.objLista[cont]?.Bitrate;
                        row.Cells[45].Value = metodosbreak.objLista[cont]?.Reg;
                        row.Cells[46].Value = metodosbreak.objLista[cont]?.MD5;


                        dataGrid1.Rows.Add(row);
                        cont++;

                    }
                }
            
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

 
    }
}