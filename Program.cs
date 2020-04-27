using System.IO;


namespace Kombinacje
{
    static class Globalne
    {
        public static int numerUtworzonegoPlikuP;
        public static int numerUtworzonegoPlikuF;
        public static string katalog;
        public static string folderZapisuPoprawnychPlikow = Path.Combine(Directory.GetCurrentDirectory(), " Poprawne ");
        public static string folderZapisuNiepoprawnychPlikow = Path.Combine(Directory.GetCurrentDirectory(), " Niepoprawne ");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Globalne.numerUtworzonegoPlikuP = 1;
            Globalne.numerUtworzonegoPlikuF = 1;
            TworzenieFolderu stworzFolder = new TworzenieFolderu();
            stworzFolder.TworzFolder(Globalne.folderZapisuNiepoprawnychPlikow ) ;
            stworzFolder.TworzFolder(Globalne.folderZapisuPoprawnychPlikow ) ;
            CzytaniePlikow czytaniePlikow = new CzytaniePlikow();
            czytaniePlikow.CzytajPliki() ;
        }

    }
}