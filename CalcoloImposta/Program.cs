using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcoloImposta
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Contribuente persona = new Contribuente(); ////
            Console.WriteLine("=============== BENVENUTO ==============");           // stampo il menù \
            Console.WriteLine("CALCOLA IMPOSTA DA VERSARE \f\n");

            // NECESSARIO PER PROVARE A TIRAR FUORI UN NUMERO DA INPUT

            bool esci = true;

            while (esci)
            {
                persona.Menu();
                int scelta;

                int.TryParse(Console.ReadLine(), out scelta);                     

                switch (scelta)          // Do una scelta se uscire o continuare
                {
                    case 1:
                        persona.GetName();
                        persona.GetCognome();
                        persona.GetGiorno();
                        persona.GetMese();
                        persona.GetAnno();
                        persona.GetCodiceFiscale();
                        persona.GetSesso();
                        persona.GetComuneResidenza();
                        persona.CalcoloImposta();
                        Console.ReadLine();
                        persona.GetStorare();

                        break;
                    case 2:
                        persona.GetStorare();
                        break;
                    case 3:

                        esci = false;
                        break;
                }


            }

        }


    }
}

