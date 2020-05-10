using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    public class Fantasy
    {
        public Hashtable FantasyHash = new Hashtable();
        public Hashtable FantasyHash2 = new Hashtable();


        public void AddFantasyBook()
        {
            FantasyHash.Add("57835685", "Harry Potter");
            FantasyHash.Add("87536345", "Yüzüklerin Efendisi ");
            FantasyHash.Add("29837683", "Hobbit");
            FantasyHash.Add("79664583", "Taht Oyunları");
            FantasyHash.Add("24659722", "Kara Şövalye");
            FantasyHash.Add("28494627", "Alice Harikalar Diyarında");
            FantasyHash.Add("92684373", "Kara Kule");
            FantasyHash.Add("21235457", "Kuzey Işıkları");
            FantasyHash.Add("95756234", "Eragon");
            FantasyHash.Add("34572577", "Kıyamet Gösterisi");
            FantasyHash.Add("76856733", "Rüzgarın Adı");


        }

        
    }
}
