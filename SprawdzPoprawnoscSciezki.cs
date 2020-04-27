using System;
using System.IO;

namespace Kombinacje
{
    class SprawdzPoprawnoscSciezki
    {
        public void SprawdzPoprawnosc(string katalog)
        {
            try
            {
                using (StreamReader plik = new StreamReader(" temp . txt ") )
                {
                    String sciezka = plik.ReadToEnd();
                    if (Directory.Exists (sciezka ) )
                    {
                        Globalne.katalog = sciezka ;
                    }
                    else
                    {
                        Console.WriteLine(" {0} Podana sciezka nie jest katalogiem lub katalog nie istnieje ", sciezka ) ;
                        Environment.Exit(0) ;
                    }
                }

            }
            catch (Exception e )
            {
                Console.WriteLine(" Nie moglem odczytac pliku ") ;
                Console.WriteLine(e.Message ) ;
                Environment.Exit(0) ;
            }
        }
    }
}