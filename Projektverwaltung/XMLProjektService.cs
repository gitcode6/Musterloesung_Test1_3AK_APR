using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Projektverwaltung
{
    public class XMLProjektService : IProjektService
    {
        private XmlTextReader reader = null;
        private XmlTextWriter writer = null;

        private static string fileNameProjekte = ConfigurationManager.AppSettings["projekteFileName"];

        private static string fileNameKunden = ConfigurationManager.AppSettings["kundenFileName"];
        public BindingList<Kunde> LadeKunden()
        {
            BindingList<Kunde> kunde = new BindingList<Kunde>();

            reader = new XmlTextReader(fileNameKunden);

            while (reader.Read())
            {
                if(reader.Name == "Kunde")
                {
                    kunde.Add(ReadKunde());
                }
            }

            return kunde;
        }

        private Kunde ReadKunde()
        {
            Kunde kunde = new Kunde();

            while(reader.Read() && reader.Name != "Kunde")
            {
                if(reader.Name == "ID")
                {
                    kunde.Id = Convert.ToInt32(reader.ReadElementContentAsString());
                }

                if (reader.Name == "Firmenname")
                {
                    kunde.Firmenname = reader.ReadElementContentAsString();
                }
            }

            return kunde;
        }

        public BindingList<Projekt> LadeProjekte()
        {
            var customers = LadeKunden().ToList<Kunde>();

            BindingList<Projekt> list = new BindingList<Projekt>();

            if (File.Exists(fileNameProjekte))
            {
                reader = new XmlTextReader(fileNameProjekte);
                while (reader.Read())
                {
                    if (reader.Name == "Projekt")
                    {
                        list.Add(LadeProjekt(customers));
                    }
                }
                reader.Close();
            }

            
            return list;
        }

        private Projekt LadeProjekt(List<Kunde> customers)
        {
            Projekt projekt = new Projekt();
            while (reader.Read() && reader.Name != "Projekt")
            {
                if (reader.Name == "Projektname")
                {
                    projekt.Projektname = reader.ReadElementContentAsString();
                }

                if (reader.Name == "Projektbeginn")
                {
                    projekt.Projektbeginn = DateTime.Parse(reader.ReadElementContentAsString());
                }

                if (reader.Name == "Projektende")
                {
                    projekt.Projektende = DateTime.Parse(reader.ReadElementContentAsString());
                }

                if (reader.Name == "Einnahmen")
                {
                    projekt.Einnahmen = Convert.ToDouble(reader.ReadElementContentAsString());
                }

                if (reader.Name == "Projektkosten")
                {
                    projekt.Projektkosten = Convert.ToDouble(reader.ReadElementContentAsString());
                }

                if(reader.Name == "Kunde")
                {
                    int id = Convert.ToInt32(reader.ReadElementContentAsString());
                    var x = customers.Find(y=>y.Id == id);
                    projekt.Kunde = x;
                }
            }



            return projekt;
        }

        public void SpeichereProjekte(BindingList<Projekt> projekte)
        {
            writer = new XmlTextWriter(fileNameProjekte, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            writer.WriteStartElement("Projekte");
            foreach (Projekt projekt in projekte)
            {
                SpeichereProjekt(projekt);
            }
            writer.WriteEndElement();
            writer.Flush();
            writer.Close();
        }

        private void SpeichereProjekt(Projekt projekt)
        {
            writer.WriteStartElement("Projekt");
            writer.WriteElementString("Projektname", projekt.Projektname);
            writer.WriteElementString("Projektbeginn", projekt.Projektbeginn.ToString());
            writer.WriteElementString("Projektende", projekt.Projektende.ToString());
            writer.WriteElementString("Einnahmen", projekt.Einnahmen.ToString());
            writer.WriteElementString("Projektkosten", projekt.Projektkosten.ToString());
            writer.WriteElementString("Kunde", projekt.Kunde.Id.ToString());
            writer.WriteEndElement();
        }
    }
}
