using System.IO;

namespace Kombinacje
{
    public class SkryptWykonaniaKombinacji
    {
        public static void WykonajKombinacjeLiczby(int[] TablicaLiczb, int Liczba, int ResztaLiczby, int indexLiczby)
        {
            string folderZapisu = Path.Combine(Directory.GetCurrentDirectory(), " Poprawne ", " wyjscie " + Globalne.numerUtworzonegoPlikuP + ". txt ");

            if (ResztaLiczby< 0)
            {
                return ;
            }
            if (ResztaLiczby == 0)
            {
                using (StreamWriter sw = File.AppendText(folderZapisu ))
                {
                    for (var i = 0; i<indexLiczby ; i ++)
                    {
                        sw.Write(TablicaLiczb[i] + " ") ;
                    }
                    sw.WriteLine() ;
                    return ;
                }   
            }

            var poprzedniaLiczba = (indexLiczby == 0) ? 1 : TablicaLiczb[indexLiczby - 1];
            for (var j = poprzedniaLiczba ; j <= Liczba ; j ++)
            {
                TablicaLiczb[indexLiczby] = j ;
                WykonajKombinacjeLiczby(TablicaLiczb , Liczba , ResztaLiczby - j , indexLiczby + 1);
            }

        }
        public void KombinacjeLiczby(int Liczba)
        {

            var TablicaLiczb = new int[Liczba];
            WykonajKombinacjeLiczby(TablicaLiczb , Liczba , Liczba , 0);
                    Globalne.numerUtworzonegoPlikuP ++;

        }
    }
}