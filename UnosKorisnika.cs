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
    public partial class UnosKorisnika : Form
    {
        public int ID=0;
        public UnosKorisnika()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UnosKorisnikaButun_Click(object sender, EventArgs e)
        {
            if (KorisnikIme.Text != "" && KorisnikPrezime.Text != "")
            {
                var NewKorisnik = new XDocument();
                NewKorisnik.AddFirst(new XElement("Korisnik"));
                NewKorisnik.Root.Add(new XElement("ID", ID));
                ID++;
                NewKorisnik.Root.Add(new XElement("Ime", KorisnikIme.Text));
                NewKorisnik.Root.Add(new XElement("Prezime", KorisnikPrezime.Text));
                if (KorisnikEmail.Text != "") NewKorisnik.Root.Add(new XElement("Email", KorisnikEmail.Text));
                else NewKorisnik.Root.Add(new XElement("Email", "Empty"));
                if(KorisnikOIB.Text != "") NewKorisnik.Root.Add(new XElement("OIB", KorisnikOIB.Text));
                else NewKorisnik.Root.Add(new XElement("OIB", "Empty"));
                NewKorisnik.Save(@"C:\Users\ucenik\source\repos\ZadatakZaOcjenuXMLERDGabrielMatosevic20211213\Korisnik" + NewKorisnik.Element("ID") + ".xml");
            }
        }
    }
}
