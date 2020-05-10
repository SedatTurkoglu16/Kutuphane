using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class Detective
    {
        public static Hashtable DetectiveHash = new Hashtable();

        static Detective()
        {
            DetectiveHash.Add("67956846", "Da Vinci Şifresi");
            DetectiveHash.Add("36246756", "Olasılıksız ");
            DetectiveHash.Add("34627864", "Siyah Kan");
            DetectiveHash.Add("75683635", "Bab-ı Esrar");
            DetectiveHash.Add("26537467", "Cingöz Recai");
            DetectiveHash.Add("13648755", "Akıl Oyunlarının Gölgesinde");
            DetectiveHash.Add("34547658", "Ejderha Dövmeli Kız");
            DetectiveHash.Add("14565474", "Aklından Bir Sayı Tut");
            DetectiveHash.Add("87686468", "Doğu Ekspresinde Cinayet");
            DetectiveHash.Add("35645746", "Melekler ve Şeytanlar");
            DetectiveHash.Add("24746845", "Sultanı Öldürmek");
        }

        
    }
}
