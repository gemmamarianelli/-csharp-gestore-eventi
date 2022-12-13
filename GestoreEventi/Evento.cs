using System;
using System.Collections.Generic;
using System.Data;
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
        public string SetTitolo(string Titolo)
        {
            if (titolo == null|| titolo == "")
            {
               throw new Exception( "titolo evento non valido");
            }
            return titolo;
        }
        public string SetData()
        {
            if(data == null)
            {
                throw new Exception("data non disponibile");
            }
            string dataStringa = Console.ReadLine();
            DateTime corrente = DateTime.Now;
            DateTime dataInserita = DateTime.Parse(dataStringa);
            if (dataInserita < corrente)
            {
                throw new Exception("la data inserita è passata");

            }
            return dataStringa;
           
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
