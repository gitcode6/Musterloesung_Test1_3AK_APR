using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektverwaltung
{
    public class Kunde
    {
        private int id;
        private string firmenname;

        public int Id { get => id; set => id = value; }
        public string Firmenname { get => firmenname; set => firmenname = value; }

        public Kunde()
        {
        }

        public Kunde(int id, string firmenname)
        {
            this.id = id;
            this.firmenname = firmenname;
        }

        public override string ToString()
        {
            return firmenname;
        }
    }
}
