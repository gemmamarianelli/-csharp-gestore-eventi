using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        //ATTRIBUTI

        private string titolo;
        private string data;
        private int capienzaMassima;
        private int postiPrenotati;

        public Evento(string titolo, string data, int capienzaMassima, int postiPrenotati)
        {
            this.titolo = titolo;
            this.data = data;
            this.capienzaMassima = 150;
            this.postiPrenotati = postiPrenotati;
        }

        //GETTERS
        public string GetTitolo() {
            return titolo;
        }
        public string GetData()
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
       
        public string SetData()
        {
            return data;
        }
        public string SetTitolo()
        {
            return titolo;
        }
        
        
        public void PrenotaPosti()
        {
            if (postiPrenotati > 150)
            {
                throw new Exception("non puoi prenotare più di 150 posti");
            }
            if (postiPrenotati < 0)
            {
                throw new Exception("posto non disponibile");
            }
             
           
        }
       public void DisdiciPosti()
        {
            
        }
       
       
    }
}
