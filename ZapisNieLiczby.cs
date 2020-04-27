using System.IO;
namespace Kombinacje
{
    public class ZapisNieLiczby
    {
        public void ZapiszNieLiczbe(string NieLiczba)
        {
            string folderZapisu = Path.Combine(Directory.GetCurrentDirectory(), " Niepoprawne ", " wyjscie nie liczby " + Globalne.numerUtworzonegoPlikuF + ". txt ");
            using (StreamWriter sw = File.AppendText(folderZapisu ) )
            {
                sw.WriteLine(" Blad "+ NieLiczba +" to nie jest liczba ") ;
                Globalne.numerUtworzonegoPlikuF ++;
                return ;
            }
        }

    }
}