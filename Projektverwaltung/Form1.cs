using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektverwaltung
{
    public partial class Form1 : Form
    {
        Frm_Projekt frm_projekt = new Frm_Projekt();
        IProjektService projektService = null;
        BindingList<Projekt> projekte = new BindingList<Projekt>();

        static string service = ConfigurationManager.AppSettings["projektService"];

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            frm_projekt.ok = false;
            frm_projekt.ShowDialog();
            if (frm_projekt.ok == true)
            {
                //Neues Projekt aus dem Formular Frm_Projekt abholen und auf der ListBox speichern
                projekte.Add(frm_projekt.projekt);
                Sort();
            }
        }

        private void Sort()
        {
            //Not macht erfinderisch ...

            List<Projekt> projekte_liste = new List<Projekt>();

            foreach (Projekt projekt in lstProjekte.Items)
            {
                projekte_liste.Add(projekt);
            }

            projekte_liste.Sort();

            projekte.Clear();

            foreach (Projekt projekt in projekte_liste)
            {
                projekte.Add(projekt);
            }

            lstProjekte.DataSource = null;
            lstProjekte.DataSource = projekte_liste;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Projekte aus XML-File laden
            projektService = (XMLProjektService)Activator.CreateInstance(Type.GetType(service));
            projekte = projektService.LadeProjekte();
            lstProjekte.DataSource = projekte;
            Sort();

        }

        private void lstProjekte_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Details des ausgewählten Projekts in den Labels darstellen
            Projekt projekt = (Projekt)lstProjekte.SelectedItem;

            if (projekt != null)
            {
                lblEinnahmen.Text = projekt.Einnahmen.ToString("c");
                lblGewinn.Text = projekt.Projektgewinn.ToString("c");
                lblProjektbeginn.Text = projekt.Projektbeginn.ToString("d");
                lblProjektende.Text = projekt.Projektende.ToString("d");
                lblProjektkosten.Text = projekt.Projektkosten.ToString("c");
                lblProjektname.Text = projekt.Projektname;
                lblKunde.Text = projekt.Kunde.ToString();
            }


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Projekte in XML-File speichern
            projektService.SpeichereProjekte(projekte);
        }
    }
}
