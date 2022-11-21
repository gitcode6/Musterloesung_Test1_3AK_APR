using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektverwaltung
{
    public interface IProjektService
    {
        BindingList<Projekt> LadeProjekte();
        void SpeichereProjekte(BindingList<Projekt> projekte);
        BindingList<Kunde> LadeKunden();
    }
}
