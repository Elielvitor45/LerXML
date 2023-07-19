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
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            MessageBox.Show("leitor montagem xml");
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Playlist objPrincipal = new Playlist(textBox1.Text, @date1.Value.Day.ToString("00"), date1.Value.Month.ToString("00"), date1.Value.Year.ToString(), dataGrid1);
            objPrincipal.Init();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string path = folderBrowserDialog1.SelectedPath;
            if (!Directory.Exists(path + @"\montagem"))
            {
                MessageBox.Show("Pasta 'Montagem' não encontrada", "Erro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }else {
                
                button1.Enabled = true;
                textBox1.Text = path;
            }   
        }
    }
}