using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Reflection;

namespace ZadatakZaOcjenuXMLERDGabrielMatosevic20211213
{
    public partial class UnosKnjige : Form
    {
        public int ID = 0;
        public UnosKnjige()
        {
            InitializeComponent();
        }

        private void UnosKnjige_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UnosKnjigeButun_Click(object sender, EventArgs e)
        {
            if(KnjigaAutor.Text!=""&& KnjigaIme.Text != "" && KnjigaIzdanje.Text != "" && KnjigaOpis.Text != "" && KnjigaStanje.Text != "")
            {
                var NewKnjiga = new XDocument();
                NewKnjiga.AddFirst(new XElement("Knjiga"));
                NewKnjiga.Root.Add(new XElement("ID", ID));
                ID++;
                NewKnjiga.Root.Add(new XElement("Ime", KnjigaIme.Text));
                NewKnjiga.Root.Add(new XElement("Autor", KnjigaAutor.Text));
                NewKnjiga.Root.Add(new XElement("Izdanje", KnjigaIzdanje.Text));
                NewKnjiga.Root.Add(new XElement("Opis", KnjigaOpis.Text));
                NewKnjiga.Root.Add(new XElement("Stanje", KnjigaStanje.Text));
                NewKnjiga.Save(@"C:\Users\ucenik\source\repos\ZadatakZaOcjenuXMLERDGabrielMatosevic20211213\Knjiga"+NewKnjiga.Element("ID")+".xml");
            }
        }
    }
}
