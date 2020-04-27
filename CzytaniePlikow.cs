using System;
using System.IO;

namespace Kombinacje
{
    public class CzytaniePlikow
    {
    public void CzytajPliki()
    {

        SprawdzPoprawnoscSciezki sprawdzPoprawnoscSciezki = new SprawdzPoprawnoscSciezki();
        sprawdzPoprawnoscSciezki.SprawdzPoprawnosc(Globalne.katalog ) ;
        try
        {
            DirectoryInfo Katalog = new DirectoryInfo(Globalne.katalog);

            foreach (var plik in Katalog.GetFiles("*. txt "))
            {
            Console.WriteLine(plik ) ;
            try
            {
                using (StreamReader odczytZPliku = plik.OpenText() )
                {
                    string linia;
                    while ((linia = odczytZPliku.ReadLine() ) != null )
                    {
                        Console.WriteLine(linia ) ;
                        if (Int32.TryParse (linia, out int liczba ) )
                        {
                            SkryptWykonaniaKombinacji skryptWykonaniaKombinacji = new SkryptWykonaniaKombinacji();
                            skryptWykonaniaKombinacji.KombinacjeLiczby( liczba ) ;
                        }
                        else
                        {
                            ZapisNieLiczby zapisNieLiczby = new ZapisNieLiczby();
                            zapisNieLiczby.ZapiszNieLiczbe(linia ) ;
                        }
                    }
                }
            }
                catch (Exception e )
                {
                    Console.WriteLine(" Nie moglem odczytac pliku :") ;
                    Console.WriteLine(e.Message ) ;
                }
            }
        }
        catch (Exception e )
        {
            Console.WriteLine(" {0} ", Globalne.katalog ) ;
            Console.WriteLine(e.Message ) ;
        }

        }
    }
}