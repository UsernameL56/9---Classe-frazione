﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeFrazioni
{

    public class Frazione
    {
        // attributi
        protected int _numeratore;
        protected int _denominatore;

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

        // metodi
        public int MCD(int num, int den)
        {
            int temp;
            while(den != 0)
            {
                temp = den;
                den = num % den;
                num = temp;
            }
            return num;
        }
        public (int, int) semplificaFrazione(int num, int den)
        {
            int mcd = MCD(num, den);
            num /= mcd;
            den /= mcd;
            return (num, den);
        }

        public (int, int) sommaFrazione(Frazione copiaFrazione)
        {
            int mcd = _denominatore * copiaFrazione.Denominatore / MCD(_denominatore, copiaFrazione.Denominatore);

            int ris1 = _numeratore * (mcd / _denominatore);
            int ris2 = copiaFrazione.Numeratore * (mcd / copiaFrazione.Denominatore);

            int risNum = ris1 + ris2;

            return (risNum, mcd);
        }

        public (int, int) sottrazioneFrazione(Frazione copiaFrazione)
        {
            int mcd = _denominatore * copiaFrazione.Denominatore / MCD(_denominatore, copiaFrazione.Denominatore);

            int ris1 = _numeratore * (mcd / _denominatore);
            int ris2 = copiaFrazione.Numeratore * (mcd / copiaFrazione.Denominatore);

            int risNum = ris1 - ris2;

            return (risNum, mcd);
        }

        public (int, int) moltiplicazioneFrazione(Frazione copiaFrazione)
        {
            int risNum = _numeratore * copiaFrazione.Numeratore;
            int risDen = _denominatore * copiaFrazione.Denominatore;

            return (risNum, risDen);
        }

        public (int, int) divisioneFrazione(Frazione copiaFrazione)
        {
            int risNum = _numeratore * copiaFrazione.Denominatore;
            int risDen = _denominatore * copiaFrazione.Numeratore;

            return (risNum, risDen);
        }
    }
}
