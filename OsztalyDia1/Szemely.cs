using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OsztalyDia1
{
    public abstract class Szemely
    {
        public int _id;
        public string _nev;
        
        public Szemely(int id, string nev)
        {

            _id = id;
            _nev = nev;

        }

        public virtual void Nev()
        {

            Console.WriteLine(string.Format("ID: {0}", this._id));
            Console.WriteLine(string.Format("Név: {0}", this._nev));

        }

    }
}
