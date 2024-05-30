using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace vertreterUmsatz
{
    class Program
    {
        static double zeigeListen(ArrayList Vertreter, ArrayList Umsatz)
        {
            double umsatzsumme = 0.0;
            for (int i = 0; i < Vertreter.Count; i++)
            {
                Console.WriteLine(i + " Vertreter: " + Vertreter[i] + "\nUmsatz: " + Umsatz[i]);
                umsatzsumme = umsatzsumme + Convert.ToDouble(Umsatz[i]);
                Console.WriteLine("----------------------------------------");

            }
            return umsatzsumme;
        }
        static void Main(string[] args)
        {
            ArrayList Vertreter = new ArrayList();
            ArrayList Umsatz = new ArrayList();

            double gesamtUmsatz=0;

            int i = 1;
            while (true)
            {
                Console.WriteLine("Hier können sie Vertreter mit ihrem Umsatz aufnehmen");
                Console.WriteLine("Vertreter Name eingeben");
                string eingabeName = Console.ReadLine();
                if (eingabeName == "")
                {
                    break;
                }
                Vertreter.Add(eingabeName);
                Console.WriteLine("Vertreter Umsatz eingeben");
                double eingabeUmsatz = Convert.ToDouble(Console.ReadLine());
                Umsatz.Add(eingabeUmsatz);

                
                
            }
            gesamtUmsatz = zeigeListen(Vertreter, Umsatz);
            Console.WriteLine("Gesamt Umsatz: " + gesamtUmsatz);
            Console.WriteLine("Möchtest du einen Vertreter löschen? j/n");
            string eingabeLoeschen = Convert.ToString(Console.ReadLine());
            if (eingabeLoeschen == "j")
            {
                zeigeListen(Vertreter, Umsatz);
                Console.WriteLine("Wenn möchtest du löschen?");
                int eingabeLoescheName = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < Vertreter.Count; j++)
                {
                    if (eingabeLoescheName == j)
                    {
                        Vertreter.Remove(Vertreter[j]);
                        gesamtUmsatz = gesamtUmsatz - Convert.ToDouble(Umsatz[j]);
                        Umsatz.Remove(Umsatz[j]);
                        zeigeListen(Vertreter, Umsatz);
                        Console.ReadKey();
                        
                    }
                    else { Console.WriteLine("Name nicht gefunden"); }
                }
                Console.WriteLine("Gesamt Umsatz: " + gesamtUmsatz);
                Console.ReadKey();
            }



        }
    }
}
