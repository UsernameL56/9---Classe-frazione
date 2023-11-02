using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeFrazioni
{

    public class Estensione : Frazione
    {
        public Estensione(int _numeratore, int _denominatore) : base(_numeratore, _denominatore)
        {

        }

        public double decimaleFrazione(int num, int den)
        {
            double ris = Convert.ToDouble(num) / Convert.ToDouble(den);

            return ris;
        }

        public (int, int) elevamentoFrazione(int num, int den, double x)
        {
            double risNum = Math.Pow(Convert.ToDouble(num), x);
        }
    }
}
