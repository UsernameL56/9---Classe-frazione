using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeFrazioni
{
    public class Class1
    {
    }

    public class Frazione
    {
        // attributi
        private int _numeratore;
        private int _denominatore;

        // costruttore
        public Frazione(int _numeratore, int _denominatore) 
        {
            Numeratore = _numeratore;
            Denominatore = _denominatore;
        }
        //costruttore di copia
        public Frazione(Frazione frazionePrecedente)
        {
            Numeratore = frazionePrecedente.Numeratore;
            Denominatore = frazionePrecedente.Denominatore;
        }

        // metodi accessor
        public int Numeratore { get { return _numeratore; } set { _numeratore = value; } }
        public int Denominatore { get { return _denominatore; } set { _denominatore = value; } }

    }
}
