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
    public partial class Frm_Projekt : Form
    {
        public bool ok = false;
        public Projekt projekt = null;
        private BindingList<Kunde> kunden= new BindingList<Kunde>();

        static string service = ConfigurationManager.AppSettings["projektService"];


        IProjektService projektService = (XMLProjektService) Activator.CreateInstance(Type.GetType(service));
        public Frm_Projekt()
        {
            InitializeComponent();
        }

        private void Frm_Projekt_Load(object sender, EventArgs e)
        {
            txtEinnahmen.Text = "";
            txtProjektbeginn.Text = "";
            txtProjektende.Text = "";
            txtProjektkosten.Text = "";
            txtProjektname.Text = "";

            kunden = projektService.LadeKunden();
            cmbKunde.DataSource = kunden;

            //Kunden aus DB laden und in Combobox einfügen
            
           
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            ok = false;
            Hide();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //hier auf globaler Variable 'projekt' neues Projekt mit Eingaben der Textboxen erzeugen

            
            projekt = new Projekt(txtProjektname.Text, Convert.ToDateTime(txtProjektbeginn.Text), Convert.ToDateTime(txtProjektende.Text), Convert.ToDouble(txtEinnahmen.Text), Convert.ToDouble(txtProjektkosten.Text), (Kunde)cmbKunde.SelectedItem);

            Debug.WriteLine((Kunde)cmbKunde.SelectedItem);
            ok = true;
            Hide();
        }

        private void Frm_Projekt_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }
    }
}
