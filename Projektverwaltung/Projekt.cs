using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektverwaltung
{
    public class Projekt : IComparable<Projekt>
    {
        private string projektname;

        DateTime projektbeginn;
        DateTime projektende;

        private double einnahmen;
        private double projektkosten;

        private Kunde kunde;

        public Projekt() { }

        public Projekt(string projektname, DateTime projektbeginn, DateTime projektende, double einnahmen, double projektkosten, Kunde kunde)
        {
            this.Projektname = projektname;
            this.Projektbeginn = projektbeginn;
            this.Projektende = projektende;
            this.Einnahmen = einnahmen;
            this.Projektkosten = projektkosten;
            this.Kunde = kunde;
        }

        public string Projektname { get => projektname; set => projektname = value; }
        public DateTime Projektbeginn { get => projektbeginn; set => projektbeginn = value; }
        public DateTime Projektende { get => projektende; set => projektende = value; }
        public double Einnahmen { get => einnahmen; set => einnahmen = value; }
        public double Projektkosten { get => projektkosten; set => projektkosten = value; }

        public double Projektgewinn { get => Einnahmen - Projektkosten; }
        public Kunde Kunde { get => kunde; set => kunde = value; }

        public int CompareTo(Projekt other)
        {
            if(other.Projektgewinn > Projektgewinn)
            {
                return 1;
            }

            else
            {
                if (other.Projektgewinn == Projektgewinn)
                {
                    return 0;
                }

                else
                {
                    return -1;
                }

            }
        }

        public override string ToString()
        {
            return projektname;
        }
    }
}
