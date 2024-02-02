using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CalcoloImposta
{
    internal class Contribuente
    {
        private string name { get; set; }
        private string cognome { get; set; }
        private string giorno { get; set; }
        private string mese { get; set; }
        private string anno { get; set; }
        public string codiceFiscale { get; set; }

      
        private string comuneResidenza { get; set; }
      



        public void Menu()
        {

            Console.WriteLine("\n1) INSERISCI I TUOI DATI");
            Console.WriteLine("2) ESCI");

        }

        public string GetName()
        {
            Console.WriteLine("Nome :");
            return name = Console.ReadLine();

        }
        public string GetCognome() //
        {
            Console.WriteLine("Cognome :");
            return cognome = Console.ReadLine();
        }
        public string GetGiorno()  //
        {

            Console.WriteLine("\nINSERISCI ANNO DI NASCITA\n\r");
            Console.WriteLine("Giorno :");
            return giorno = Console.ReadLine();

        }
        public string GetMese()//
        {
            Console.WriteLine("\nMese :");
            return mese = Console.ReadLine();
        }
        public string GetAnno()//
        {
            Console.WriteLine("\nAnno :");
            return anno = Console.ReadLine();
        }
        public void GetCodiceFiscale()
        {

            Console.WriteLine("Inserisci codice Fiscale");
            codiceFiscale = Console.ReadLine();


            if (codiceFiscale.Length == 16)
            {
                Console.WriteLine($"{codiceFiscale} Codice Fiscale valido");
            }
            else
            {
                Console.WriteLine("\nCodice Fiscale NON VALIDO");
                GetCodiceFiscale();
            }

        }

        private int sesso { get; set; }


        public void GetSesso()

        {
            Console.WriteLine("\nSCEGLI GENERE\n 1)Maschio \n2)Femmina \n3)None");
            int sesso;
            int.TryParse(Console.ReadLine(), out sesso);

            switch (sesso)
            {

                case 1:
                    Console.WriteLine("\nSesso : Maschio");

                    break;
                case 2:
                    Console.WriteLine("\nSesso : Femmina");
                    break;
                case 3:
                    Console.WriteLine("\nSesso : None");
                    break;
                default:
                    Console.WriteLine("non valido");
                    break;

            }
        }
        public string GetComuneResidenza()
        {
            Console.WriteLine("IL TUO COMUNE DI RESIDENZA");
            return comuneResidenza = Console.ReadLine();

        }
        private double redditoAnnualeLordo { get; set; }

        public void CalcoloImposta()       
        {
            Console.WriteLine("Reddito annuale");
            double redditoAnnualeLordo;
            double.TryParse(Console.ReadLine(), out redditoAnnualeLordo);  // rendo leggibile il dato numerico
                                                                            // creo i vari casi dell'imposta
            if (redditoAnnualeLordo <= 15000)
            {
                Console.WriteLine($"La tua imposta è {redditoAnnualeLordo *0.23}");            
            }
            else if(redditoAnnualeLordo <= 28000)
            {
                Console.WriteLine($"La tua imposta è {3450 + (redditoAnnualeLordo - 15000)*0.27 }");
            }
            else if (redditoAnnualeLordo <= 55000)
            {
                Console.WriteLine($"La tua imposta è {6960 + (redditoAnnualeLordo - 28000) * 0.38}");
            }
            else if (redditoAnnualeLordo <= 75000)
            {
                Console.WriteLine($"La tua imposta è {17220 + (redditoAnnualeLordo - 55000) * 0.41}");
            }
            else if (redditoAnnualeLordo >= 75001)
            {
                Console.WriteLine($"La tua imposta è {25420 + (redditoAnnualeLordo - 75000) * 0.43}");
            }
     
        }

           public void GetStorare()
           {
            Console.WriteLine($"NOME: {name}");
            Console.WriteLine($"COGNOME:{cognome}\n");
            Console.WriteLine($"ANNO DI NASCITA\n{giorno}/{mese}/{anno}");
            Console.WriteLine($" CODICE FISCALE \n{codiceFiscale}");
            Console.WriteLine($"SESSO{sesso}");
            Console.WriteLine($"COMUNE DI RESIDENZA {comuneResidenza}");
            Console.WriteLine($"IMPOSTA DA VERSARE IN BASE AL REDDITO{redditoAnnualeLordo}");
            }



    }

}
