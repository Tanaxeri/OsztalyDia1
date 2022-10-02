using System;
using System.Collections.Generic;

namespace OsztalyDia1
{
    public class Edzo : Szemely
    {
        public string _felhasznalo;
        public string _ujedzo;

        public Edzo(int id, string nev, string felhasznalo) : base(id, nev)
        {

            this._felhasznalo = felhasznalo;

        }



        public override void Nev()
        {

            Console.WriteLine(string.Format("ID: {0}", this._id));
            Console.WriteLine(string.Format("Név: {0}", this._nev));
            Console.WriteLine(string.Format("Felhasználó: {0}", this._felhasznalo));

        }

    }
}
