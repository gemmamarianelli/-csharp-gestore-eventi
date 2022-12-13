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
            titoloGiusto(titolo);
            impostData(data);
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
       
        public void SetData(string data)
        {
            this.data = data;
        }
        public void SetTitolo(string titolo)
        {
            this.titolo = titolo;
        }
        
        public void impostData(string data)
        {
       
            string dataStringa = Console.ReadLine();
            DateTime corrente = DateTime.Now;
            DateTime dataInserita = DateTime.Parse(dataStringa);
            if (dataInserita < corrente)
            {
                throw new Exception("la data inserita è passata");

            }

            this.data = data;

        }
        public void titoloGiusto(string titolo)
        {
            if (titolo == null)
            {
                throw new Exception("titolo evento non valido");
            }
            this.titolo = titolo;

        }
        public void PrenotaPosti(int postiDaprenotare)
        {
            postiPrenotati = postiPrenotati + postiDaprenotare;


            if (postiDaprenotare > 150)
            {
                throw new Exception("non puoi prenotare più di 150 posti");
            }
            if (postiDaprenotare < 0)
            {
                throw new Exception("posto non disponibile");
            }
            
           
        }
        public void DisdiciPosti(int postiDaRimuovere)
        {
            postiPrenotati = postiPrenotati - postiDaRimuovere;
            if (postiDaRimuovere == 0)
            {
                throw new Exception("non hai posti da rimuovere");
            }
        }
        public override string ToString()
        {
            return data.ToString() + " - " + titolo.ToString();
        }


    }
}
