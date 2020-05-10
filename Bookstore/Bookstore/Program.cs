using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class Program
    {
        static void Main(string[] args)
        {
            Books B1 = new Books();
            int secim, secim2;
            Fantasy F1 = new Fantasy();
             
            F1.AddFantasyBook();

            Console.WriteLine("Hoşgeldiniz\n");

            Console.Clear();
        AnaMenu:
            Console.WriteLine(" 1.Kitap Ekle.\n 2.Kitap Sorgula. \n 3.Emanet Kitap Ver. \n 4.Kitap Listele. \n 5.Kitap Bilgileri Düzenle. \n 6.Çıkış. ");
            Console.Write("Seçiminizi Yapın ve klavyeden Enter'a basın. : ");
            secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)    //switch case kullanarak işlemlerin ayrı ayrı kodlarını yazıyoruz.
            {
                case 1:
                    
                    Console.Write("Kitap Adını giriniz: ");
                    B1.name = Console.ReadLine();
                    Console.Write("Bandrol numarasını giriniz: ");
                    B1.bandrol = Console.ReadLine();
                    Console.Write("Fiyatı giriniz: ");
                    B1.price = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Kitabın Basım Yılını giriniz: ");
                    B1.Year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n 1.Bilim Kurgu \n 2.Polisiye \n 3.Macera \n 4.Fantastik ");
                    Console.Write("Kitabın türünü seçiniz: ");
                    B1.kind = Console.ReadLine();
                    B1.AddBooks(B1);
                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz. \n\n");
                    System.Threading.Thread.Sleep(2000);
                    goto AnaMenu;

                case 2:
                    
                    Console.Write("Sorgulamak istediğiniz kitabın adını giriniz: ");
                    string nameSorgula = Console.ReadLine();
                    B1.kitapSorgula(nameSorgula);
                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz. \n\n");
                    System.Threading.Thread.Sleep(1500);
                    goto AnaMenu;

                case 3:
                    Console.Write("Emanet olarak alınmak istenen kitabın adını giriniz: ");
                    string emanet = Console.ReadLine();
                    B1.emanetKitap(emanet);
                    System.Threading.Thread.Sleep(2000);
                    goto AnaMenu;
                
                case 4:

                    Console.WriteLine("Görüntülemek istediğiniz kategoriyi giriniz. ");
                    Console.WriteLine(" 1.Bilim Kurgu \n 2.Polisiye \n 3.Macera \n 4.Fantastik \n 5.Ana Menü ");
                    secim2 = Convert.ToInt32(Console.ReadLine());

                    if (secim2 == 4)
                    {
                        B1.listele(F1.FantasyHash);
                    }
                    if (secim2 == 1)
                    {
                        B1.listele(ScienceFiction.ScienceHash);
                    }
                    if (secim2 == 3)
                    {
                        B1.listele(Adventure.AdventureHash);
                    }
                    if (secim2 == 2)
                    {
                        B1.listele(Detective.DetectiveHash);
                    }
                    Console.WriteLine("Ana menüye yönlendiriliyorsunuz. \n\n");
                    System.Threading.Thread.Sleep(3000);
                    goto AnaMenu;
            }
            

            //girilen kitabın türüne göre ilgili class'ın Hashtable'ını yazdırıyoruz:

            

        }

    }

}
