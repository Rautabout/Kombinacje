using System;
using System.IO;

namespace Kombinacje
{
    class TworzenieFolderu
    {
        public void TworzFolder(string folderZapisu)
        {
            try // stworzenie folderu
            {
            if (Directory.Exists (folderZapisu ) )
            {
            Console.WriteLine(" Foldery zapisu juz istnieja ");
            SprawdzPlikiWFolderze sprawdzPlikiWFolderze = new
            SprawdzPlikiWFolderze();
            sprawdzPlikiWFolderze.SprawdzCzySaPliki() ;
            return ;
            }
            Directory.CreateDirectory(folderZapisu ) ;
            Console.WriteLine(" Folder utworzony pod sciezka {0} ",
            folderZapisu ) ;
            return ;
            }
            catch (Exception e )
            {
            Console.WriteLine(" Nie udalo sie : {0} ", e.Message ) ;
            }

        }
    }
}