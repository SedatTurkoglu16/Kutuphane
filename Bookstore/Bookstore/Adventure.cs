using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    public class Adventure
    {
        public static Hashtable AdventureHash = new Hashtable();

        static Adventure()
        {
            AdventureHash.Add("56745745", "Başlangıç");
            AdventureHash.Add("56967946", "Sherlock Holmes’ün Maceraları ");
            AdventureHash.Add("23464557", "Dijital Kale");
            AdventureHash.Add("79664575", "Labirent");
            AdventureHash.Add("24659722", "Beyoğlu Macerası");
            AdventureHash.Add("28494627", "Şimşek Hırsızı");
            AdventureHash.Add("92684373", "Moby Dick");
            AdventureHash.Add("21235457", "Tom Sawyer");
            AdventureHash.Add("95756234", "Denizler Altında Yirmi Bin fersah");
            AdventureHash.Add("34572577", "80 Günde Devr-i Alem");
            AdventureHash.Add("76856733", "Puslu Kıtalar Atlası");
        }

    }
}
