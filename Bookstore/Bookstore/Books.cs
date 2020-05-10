using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    public class Books
    {
        public string name;
        public string bandrol;
        public double price;
        private decimal year;
        public string kind;
        Fantasy F1 = new Fantasy();

        public void AddBooks(Books book)
        {
            if (book.kind == "1")
            {
                ScienceFiction.ScienceHash.Add(book.bandrol, book.name);
                Console.WriteLine("Girmiş olduğunuz kitap başarıyla eklendi.");
            }
            if (book.kind == "2")
            {
                Detective.DetectiveHash.Add(book.bandrol, book.name);
                Console.WriteLine("Girmiş olduğunuz kitap başarıyla eklendi.");
            }
            if (book.kind == "3")
            {
                Adventure.AdventureHash.Add(book.bandrol, book.name);
                Console.WriteLine("Girmiş olduğunuz kitap başarıyla eklendi.");
            }
            if (book.kind == "4")
            {
                F1.FantasyHash.Add(book.bandrol, book.name);
                Console.WriteLine("Girmiş olduğunuz kitap başarıyla eklendi.");
            }
        }
         

        public void listele(Hashtable hashtable)
        {
            int i = 1;
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("{0}. {1}", i, entry.Value);
                i++;
            }
        }

        public decimal Year
        {
            get { return this.year; }
            set
            {
                if (value < 1990)
                {
                    Console.WriteLine("Basım tarihi 1990'dan eski olduğundan kayıt için uygun değil \n Lütfen geçerli bir kitap giriniz.");

                }
                else
                {
                    Console.WriteLine("kayıt için uygun");
                    this.year = value;
                }
            }

        }

        public void kitapSorgula(string isim)
        {
            bool control = F1.FantasyHash.ContainsValue(isim);
            bool control2 = Detective.DetectiveHash.ContainsValue(isim);
            bool control3 = Adventure.AdventureHash.ContainsValue(isim);
            bool control4 = ScienceFiction.ScienceHash.ContainsValue(isim);

            if (control == true)
            {
                Console.WriteLine("Aradığınız kitap mevcuttur.");
            }
            
            if (control2 == true)
            {
                Console.WriteLine("Aradığınız kitap mevcuttur.");
            }
            
            if (control3 == true)
            {
                Console.WriteLine("Aradığınız kitap mevcuttur.");
            }

            if (control4 == true)
            {
                Console.WriteLine("Aradığınız kitap mevcuttur.");
            }
        }

        public void emanetKitap(string isim)
        {
            bool control = F1.FantasyHash.ContainsValue(isim);
            bool control2 = Detective.DetectiveHash.ContainsValue(isim);
            bool control3 = Adventure.AdventureHash.ContainsValue(isim);
            bool control4 = ScienceFiction.ScienceHash.ContainsValue(isim);

            string temp = null;

            if (control == true)
            {
               
                foreach (DictionaryEntry entry in F1.FantasyHash)
                {
                    if (isim == (string)entry.Value)
                    {
                        temp = (string)entry.Key;
                    }
                }
                
                Console.WriteLine("Aradığınız kitap mevcuttur.\n");
                Console.WriteLine("Bu kitabı emanet olarak vermeyi onaylıyor musunuz? (E/h)");
                string secim = Console.ReadLine();
                if (secim == "E" || secim == "e")
                {
                    F1.FantasyHash.Remove(temp);
                    Console.WriteLine("Kitap emanet olarak verildi. Ve kitabın sistemden çıkışı yapıldı.");
                }
                if (secim == "H" || secim == "h")
                {
                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz. \n\n");
                }
            }
            
            if (control2 == true)
            {
                foreach (DictionaryEntry entry in Adventure.AdventureHash)
                {
                    if (isim == (string)entry.Value)
                    {
                        temp = (string)entry.Key;
                    }
                }
                Console.WriteLine("Aradığınız kitap mevcuttur.\n");
                Console.WriteLine("Bu kitabı emanet olarak vermeyi onaylıyor musunuz? (E/h)");
                string secim = Console.ReadLine();
                if (secim == "E" || secim == "e")
                {
                    Adventure.AdventureHash.Remove(temp);
                    Console.WriteLine("Kitap emanet olarak verildi. Ve kitabın sistemden çıkışı yapıldı.");
                }
                if (secim == "H" || secim == "h")
                {
                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz. \n\n");
                }
                
            }
            
            if (control3 == true)
            {
                Console.WriteLine("Aradığınız kitap mevcuttur.");

                foreach (DictionaryEntry entry in Detective.DetectiveHash)
                {
                    if (isim == (string)entry.Value)
                    {
                        temp = (string)entry.Key;
                    }
                }
                Console.WriteLine("Aradığınız kitap mevcuttur.\n");
                Console.WriteLine("Bu kitabı emanet olarak vermeyi onaylıyor musunuz? (E/h)");
                string secim = Console.ReadLine();
                if (secim == "E" || secim == "e")
                {
                    Detective.DetectiveHash.Remove(temp);
                    Console.WriteLine("Kitap emanet olarak verildi. Ve kitabın sistemden çıkışı yapıldı.");
                }
                if (secim == "H" || secim == "h")
                {
                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz. \n\n");
                }
                
            }
           
            if (control4 == true)
            {
                Console.WriteLine("Aradığınız kitap mevcuttur.");

                foreach (DictionaryEntry entry in ScienceFiction.ScienceHash)
                {
                    if (isim == (string)entry.Value)
                    {
                        temp = (string)entry.Key;
                    }
                }
                Console.WriteLine("Aradığınız kitap mevcuttur.\n");
                Console.WriteLine("Bu kitabı emanet olarak vermeyi onaylıyor musunuz? (E/h)");
                string secim = Console.ReadLine();
                if (secim == "E" || secim == "e")
                {
                    ScienceFiction.ScienceHash.Remove(temp);
                    Console.WriteLine("Kitap emanet olarak verildi. Ve kitabın sistemden çıkışı yapıldı.");
                }
                if (secim == "H" || secim == "h")
                {
                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz. \n\n");
                }
                
            }
            else
            {
                Console.WriteLine("Girmiş olduğunuz kitap kütüphanede mevcut değildir");
            }
        }
    }
}
