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
            MessageBox.Show("leitor montagem xml");
        }        
        private void button1_Click_1(object sender, EventArgs e)
        {
           
            Playlist objPrincipal = new Playlist(textBox1.Text,textday.Text,textmounth.Text,textyear.Text,dataGrid1);
            objPrincipal.Init();

            
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

 
    }
}