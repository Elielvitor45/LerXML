using LeituraXml.Utils;
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
            MessageBox.Show("Carreguei zeze");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            XmlDocument xml =  ObjPrincipal.XmlDocumento("C:\\Desenvolvimento\\LeituraXml\\LeituraXml\\TesteXML.xml");
            XmlNodeList ListaXml = ObjPrincipal.ListadeXMl(xml,"//Playlist/*");
            List<XmlNode> lista = new List<XmlNode>();
            List<XmlNode> listains = new List<XmlNode>();
            Break metodosbreak = new Break();

            //Separa a listaXml (Nó) Playlist em uma listaXml (Nó) Break
            foreach (XmlNode noFilho in ListaXml)
            {
                lista.Add(noFilho);
            }
            //Adiciona os valores numa listaObj de (Nó) Breaks
            ObjPrincipal.setBreaks(lista);
            
            //adiciona os valores de uma listaXml de (Nó) Breaks para uma listaXml de (Nó) Ins
            listains = ObjPrincipal.GetAllIns(lista);
           
            //Pega uma lista de (Nó) ins e adiciona os valores dentro de uma ListaObj (Nó) Ins
            metodosbreak.setObjIns(listains);















        }


    }
}