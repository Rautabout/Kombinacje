using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kombinacje
{
    class SprawdzPlikiWFolderze
    {
        public void SprawdzCzySaPliki()
        {
            while (File.Exists(Path.Combine(Globalne.folderZapisuNiepoprawnychPlikow, "wyjscie nie liczby" + Globalne.numerUtworzonegoPlikuF + ".txt")) == true)
            {
                Globalne.numerUtworzonegoPlikuF++;
            }
            while (File.Exists(Path.Combine(Globalne.folderZapisuPoprawnychPlikow, "wyjscie" + Globalne.numerUtworzonegoPlikuP + ".txt")) == true)
            {
                Globalne.numerUtworzonegoPlikuP++;
            }
        }
    }
}
