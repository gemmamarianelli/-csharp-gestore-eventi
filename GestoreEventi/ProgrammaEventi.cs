using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class ProgrammaEventi
    {
        private string Titolo;
        private List<Evento> eventi;


        public ProgrammaEventi(string titolo, List<Evento> eventi)
        {
            this.Titolo = titolo;
            this.eventi = eventi;
        }


    }
}
