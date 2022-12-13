using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        //ATTRIBUTI

        private string titolo;
        private double data;
        private int capienzaMassima;
        private int postiPrenotati;

        public Evento(string titolo, double data, int capienzaMassima, int postiPrenotati)
        {
            this.titolo = titolo;
            this.data = data;
            this.capienzaMassima = capienzaMassima;
            this.postiPrenotati = postiPrenotati;
        }

        //GETTERS
        public string GetTitolo() {
            return titolo;
        }
        public double GetData()
        {
            return data;
        }
        public int GetCapienzaMassima()
        {
            return capienzaMassima;
        }
        public int GetPostiPrenotati()
        {
            return postiPrenotati;
        }

        //SETTERS
        public string SetTitolo()
        {
            return this.titolo;
        }
        public double SetData()
        {
            return this.data;
        }

        //COSTRUTTORI
        
        
       
       
        
    }
}
