using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class ScienceFiction:Books
    {
        public static Hashtable ScienceHash = new Hashtable();

        static ScienceFiction()
        {
            ScienceHash.Add("24564342", "Kozmos");
            ScienceHash.Add("24564672", "Fahrenheit 451");
            ScienceHash.Add("75673532", "Zaman Makinesi");
            ScienceHash.Add("82929835", "Ben Robot");
            ScienceHash.Add("86572875", "Otostopçunun Galaksi Rehberi");
            ScienceHash.Add("98946723", "Görünmez Adam");
            ScienceHash.Add("48472456", "Mars Yıllıkları");
            ScienceHash.Add("11243468", "Dünyaların Savaşı");
            ScienceHash.Add("66363465", "Vakıf");
            ScienceHash.Add("45363467", "1984");
            ScienceHash.Add("76573565", "Dune Çocukları");
        }

    
    }
}
