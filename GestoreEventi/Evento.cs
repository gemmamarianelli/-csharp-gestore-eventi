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
            if(postiPrenotati < 0)
            {
                Console.WriteLine("Posto non valido");
            }
            return postiPrenotati;
        }

        //SETTERS
        public string SetTitolo(string Titolo)
        {
             Console.WriteLine("inserisci titolo: ");
           string nome =  Console.ReadLine();
            if (nome == null)
            {
               throw new Exception( "titolo evento non valido");
            }
            return nome;
        }
        public double SetData()
        {
            return this.data;
        }

        
        
        public void PrenotaPosti()
        {
          
        }
       public void DisdiciPosti()
        {
            
        }
       
        
    }
}
